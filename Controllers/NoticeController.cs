using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NoticeBoardApp.Models;
using NoticeBoardApp.Models.ViewModels;
using NoticeBoardApp.Repositories.Interfaces;

namespace NoticeBoardApp.Controllers
{
    public class NoticeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public NoticeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var noticesInDb = await _unitOfWork.NoticeRepository.GetAllAsync();
            noticesInDb = noticesInDb.Where(n => !n.IsDeleted);
            
            if(User.IsInRole(RolesAndPolicies.Roles.Administrator))
                return View("Index", noticesInDb);
            else if (User.IsInRole(RolesAndPolicies.Roles.RegularUser))
            {
                List<Notice> sortedNotices = await SortNoticesByReadAndUnread(noticesInDb);

                return View("ReadOnlyIndex", sortedNotices);
            }
            else
                return View("ReadOnlyIndex", noticesInDb);            
        }

        private async Task<List<Notice>> SortNoticesByReadAndUnread(IEnumerable<Notice> noticesInDb)
        {
            var user = await _unitOfWork.AccountRepository.FindByNameAsync(User.Identity.Name);
            var noticeViewedByUser = await _unitOfWork.NoticeViewerRepository.GetNoticeViewedByUserAsync(user.Id);

            var sortedNotices = new List<Notice>();
            var readNotices = new List<Notice>();

            foreach (var notice in noticesInDb)
            {
                if (noticeViewedByUser.Any(nv => nv.Notice.Id == notice.Id))
                {
                    readNotices.Add(notice);
                }
                else
                {
                    sortedNotices.Add(notice);
                }
            }

            sortedNotices.AddRange(readNotices);
            return sortedNotices;
        }




        [Authorize(Roles = RolesAndPolicies.Roles.Administrator)]
        public IActionResult Create()
        {
            var model = new NoticeFormViewModel();
            return View("NoticeForm", model);
        }


        [Authorize(Roles = RolesAndPolicies.Roles.Administrator)]
        public async Task<IActionResult> Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) return NotFound();

            var noticeInDb = await _unitOfWork.NoticeRepository.GetAsync(id);
            
            if (noticeInDb == null) return NotFound();
            
            var model = new NoticeFormViewModel
            {
                Id = noticeInDb.Id,
                Title = noticeInDb.Title,
                SubTitle = noticeInDb.SubTitle,
                Details = noticeInDb.Details
            };

            return View("NoticeForm", model);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RolesAndPolicies.Roles.Administrator)]
        public async Task<IActionResult> Save(NoticeFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _unitOfWork.AccountRepository.FindByNameAsync(User.Identity.Name);

                if (!string.IsNullOrWhiteSpace(model.Id))
                {
                    var noticeInDb = await _unitOfWork.NoticeRepository.GetAsync(model.Id);

                    if (noticeInDb == null)
                    {
                        ModelState.AddModelError("", "Some error occured. Please, refresh the page and try again.");
                        return View("NoticeForm", model);
                    }

                    noticeInDb.Id = model.Id;
                    noticeInDb.Title = model.Title;
                    noticeInDb.SubTitle = model.SubTitle;
                    noticeInDb.Details = model.Details;
                }
                else
                {
                    var notice = new Notice
                    {
                        Title = model.Title,
                        SubTitle = model.SubTitle,
                        Details = model.Details,
                        CreatedOn = DateTime.Now,
                        CreatedBy = user.Id,
                        ModifiedOn = DateTime.Now,
                        ModifiedBy = user.Id
                    };

                    await _unitOfWork.NoticeRepository.CreateAsync(notice);

                }

                await _unitOfWork.CompleteAsync();

                return RedirectToAction("Index", "Notice");
            }

            return View("NoticeForm", model);
        }


        
        
        
        public async Task<IActionResult> Details(string id)
        {
            if (string.IsNullOrEmpty(id)) return NotFound();

            var noticeInDb = await _unitOfWork.NoticeRepository.GetAsync(id);

            if (noticeInDb == null) return NotFound();

            // Total View Update: Start
            noticeInDb.TotalViews++;
            await _unitOfWork.CompleteAsync();
            // Total View Update: End

            // Add To NoticeViewer: Start
            await InsertNoticeViewedByUser(noticeInDb.Id);
            // Add To NoticeViewer: End


            var model = new NoticeViewModel
            {
                Id = id,
                Title = noticeInDb.Title,
                SubTitle = noticeInDb.SubTitle,
                Details = noticeInDb.Details,
                Creator = noticeInDb.Creator,
                CreatedOn = noticeInDb.CreatedOn,
                Modifier = noticeInDb.Modifier,
                ModifiedOn = noticeInDb.ModifiedOn,
                TotalViews = noticeInDb.TotalViews
            };

            if (User.IsInRole(RolesAndPolicies.Roles.Administrator))
                return View("Details", model);
            else
                return View("ReadOnlyDetails", model);
        }


        private async Task InsertNoticeViewedByUser(string noticeId)
        {
            if(User.Identity.Name == null) return;

            var user = await _unitOfWork.AccountRepository.FindByNameAsync(User.Identity.Name);

            var noticeViewerInDb = await _unitOfWork.NoticeViewerRepository.GetAsync(user.Id, noticeId);

            if(noticeViewerInDb == null)
            {
                var noticeViewer = new NoticeViewer
                {
                    UserId = user.Id,
                    NoticeId = noticeId
                };
                await _unitOfWork.NoticeViewerRepository.CreateAsync(noticeViewer);
                await _unitOfWork.CompleteAsync();
            }
        }



        [Authorize(Roles = RolesAndPolicies.Roles.Administrator)]
        public async Task<IActionResult> Delete(string id)
        {
            if (string.IsNullOrEmpty(id)) return BadRequest();

            var noticeInDb = await _unitOfWork.NoticeRepository.GetAsync(id);

            if(noticeInDb == null) return NotFound();

            noticeInDb.IsDeleted = true;
            var rowsAffected = await _unitOfWork.CompleteAsync();

            if(rowsAffected > 0) return Ok();

            else return BadRequest();
        }


    }
}
