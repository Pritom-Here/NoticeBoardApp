using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoticeBoardApp.Data.Migrations
{
    public partial class Seed_Notice_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'00887180-dcd4-4f9e-8fcb-d25895ae7f23', N'Fine Arts Spring 2022 (1st Semester) Result Published!', NULL, N'Aenean porta condimentum commodo. Quisque porttitor, mauris sed ullamcorper consequat, est ex pellentesque erat, in porta dolor tellus at est. Suspendisse eros turpis, blandit vel pulvinar ac, rhoncus eu lectus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec tristique sagittis massa. Donec sagittis vestibulum tellus, ut accumsan eros dignissim a. Cras pharetra ligula nec purus blandit, sit amet fermentum est accumsan. Etiam ut pellentesque augue, vel posuere risus. Donec luctus gravida ante eget imperdiet. Etiam volutpat ornare urna quis mollis. Nunc aliquam sagittis diam nec ultrices. Cras nec convallis lorem. Ut finibus elementum lacus, in lacinia ipsum consequat non. Suspendisse dictum rutrum leo ac faucibus. Etiam vestibulum eleifend urna, id ultrices nibh cursus et. Maecenas ut nulla sit amet turpis eleifend ultrices. ', N'2022-06-27 10:59:50', N'2022-06-27 10:59:50', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'17cfd6be-ceeb-4e2a-9107-9f0a8fe226ba', N'EEE Spring 2022 Exam Schedule!', NULL, N'Proin sed dolor eu ligula viverra fringilla. Suspendisse id dictum velit. Sed vel pretium massa. Etiam ornare commodo posuere. Nulla venenatis placerat mauris sit amet consequat. In hac habitasse platea dictumst. Curabitur bibendum et est a vehicula. Nam porta, ante lacinia egestas eleifend, nibh lacus ultricies ex, ornare pharetra nibh nibh vel erat. Nullam fringilla, neque non auctor finibus, mauris arcu cursus turpis, in dapibus metus elit eget turpis. Nam vel elit sit amet lacus imperdiet rhoncus. ', N'2022-06-27 10:58:45', N'2022-06-27 10:58:45', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(                
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'252d2c1a-08de-46ce-8876-360eb1f2e90c', N'Fall Semester 2022: Orientation Program', NULL, N'Curabitur aliquet nisi quis mattis rutrum. In consequat risus nec elit suscipit tincidunt. Quisque nec est lectus. Proin at sodales elit. Praesent dolor enim, ullamcorper et vulputate at, maximus ut enim. Vivamus nec elit ut diam egestas ornare. Cras euismod quis est quis consectetur. Morbi venenatis porta risus vel elementum. Cras orci risus, molestie ac feugiat non, viverra id lorem. Donec orci sapien, pharetra id laoreet et, eleifend in elit. Nam vitae purus luctus, sagittis sapien at, dapibus ligula. Nulla non est volutpat, aliquam eros ac, cursus metus. Sed nec auctor tortor. Etiam rutrum, nisl a cursus consectetur, sapien libero dapibus justo, fermentum iaculis enim lectus id nisi. Praesent et elementum urna. ', N'2022-06-26 23:21:23', N'2022-06-26 23:21:23', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 1)"                
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'4b6bbdb9-6c04-451f-b591-bb25dd4de55b', N'Summer Vacation Announcement', NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque gravida arcu eget nulla ullamcorper maximus. Mauris interdum nisl sapien, ut volutpat diam suscipit et. Fusce sit amet lorem ultrices, consequat nibh non, maximus nisl. Aenean et ornare risus. In blandit orci sed mi scelerisque consequat. Curabitur vitae est vitae sem cursus gravida non et nunc. Sed varius libero vehicula mauris sodales lacinia. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Aenean arcu risus, dapibus in congue vel, lacinia ac neque. Sed mattis felis id bibendum varius. Donec consectetur lectus est, in malesuada lacus posuere id. Nunc fermentum ipsum eget urna consectetur, et posuere erat fringilla. ', N'2022-06-25 20:26:42', N'2022-06-25 20:26:42', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 19)"                
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'4e68ebd4-0e70-4bea-88d5-c051952b01bb', N'All University Competitive Programming, 2022', NULL, N'Aliquam sit amet diam porta, aliquam est ac, volutpat justo. Aenean dapibus lorem sed mauris maximus, in pulvinar elit mattis. Donec tristique turpis quis dolor elementum vehicula. Vestibulum felis erat, bibendum sed magna in, volutpat faucibus lectus. Nam laoreet pellentesque ultrices. Nullam nec semper ipsum. Etiam rutrum, libero quis accumsan tristique, eros lacus dictum felis, et convallis metus erat eget turpis. Maecenas nisi tellus, blandit id velit finibus, tempus posuere libero. Vestibulum in felis sit amet felis dapibus sollicitudin a non nunc. Fusce in semper lectus. ', N'2022-06-27 11:12:56', N'2022-06-27 11:12:56', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'60c4a2a7-d05b-4e9e-90cd-36d8d46dcafd', N'Hackathon 2022!', NULL, N'Sed luctus semper maximus. Praesent hendrerit ante eu augue volutpat dignissim. Aliquam dapibus erat justo, consequat imperdiet augue accumsan et. Nunc cursus massa quis libero porta eleifend. Suspendisse in malesuada velit. Donec ac commodo sem. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus eu dui nec risus convallis maximus. Ut tincidunt vitae ex quis venenatis. Vivamus nisl dui, congue sed velit sit amet, suscipit cursus eros. Maecenas bibendum urna sed auctor tempor. Nam viverra eros sapien, sit amet tincidunt risus mattis vel. Vivamus porttitor tempus tincidunt. Vestibulum commodo gravida est, at placerat ante luctus nec. Donec consectetur aliquet venenatis. ', N'2022-06-27 11:15:04', N'2022-06-27 11:15:04', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"                
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'6233f307-f91a-431b-8949-ae8c51c22b85', N'University Robotics Challange 2022: Drone Masters!', NULL, N'Pellentesque pulvinar nulla dictum nunc lobortis, vitae congue quam varius. Etiam ante nibh, placerat non laoreet ac, pretium eu magna. Integer purus risus, interdum vitae imperdiet non, egestas et elit. Mauris sit amet ex eget neque convallis pharetra. Maecenas gravida diam nulla, in dapibus diam scelerisque eu. Aenean pharetra neque et condimentum fringilla. Maecenas quis orci hendrerit metus maximus placerat sed ac tortor. Nulla at est accumsan, aliquam justo auctor, lobortis nunc. Nunc non augue ut massa cursus tincidunt nec sit amet augue. Phasellus nunc justo, elementum vel elementum vehicula, feugiat pharetra erat. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Morbi condimentum metus eu molestie pharetra. Aliquam quis magna eget lorem consequat vehicula id a massa. ', N'2022-06-27 11:05:19', N'2022-06-27 11:05:19', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'64ff5047-6d5f-4b18-9c8b-2e0b02da51ff', N'Hack The Net, 2022!', NULL, N'Pellentesque at nulla at dolor suscipit bibendum nec in est. Morbi lectus eros, sodales vitae gravida non, finibus sit amet lacus. Suspendisse facilisis posuere ante, vel molestie orci finibus sed. Nulla molestie, velit ut hendrerit porttitor, eros odio dapibus orci, in tincidunt ante dui quis ligula. Integer ac volutpat est. In mattis efficitur nunc, non facilisis risus. In sit amet dapibus turpis. ', N'2022-06-27 11:11:17', N'2022-06-27 11:11:17', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'6c19a812-febf-4b76-84a2-9009cd594974', N'Fine Arts Spring 2022 (1st Semester) Marksheet Distribution', NULL, N'Nullam viverra ante eget tempus lobortis. Nam laoreet hendrerit risus consectetur pharetra. Vivamus pharetra accumsan maximus. Quisque leo nisi, feugiat a odio non, hendrerit faucibus ipsum. Etiam sodales nec ex eu varius. Nullam suscipit tempus erat, id aliquam massa consequat sed. Fusce fringilla purus eget elit mollis, ut rhoncus nunc sollicitudin. Mauris blandit a nisl vehicula rutrum. Sed diam augue, iaculis nec ante eu, auctor fermentum augue. Sed auctor lacus sed turpis hendrerit hendrerit. Pellentesque accumsan, libero nec tempus cursus, enim nisi sagittis purus, a facilisis est velit nec dui. Etiam posuere ligula id volutpat iaculis.', N'2022-06-27 11:01:09', N'2022-06-27 11:01:09', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'a0cff7fb-fcc5-4b90-aee1-6537aba4ce12', N'Study Tour With CSE Department', NULL, N'Cras ac euismod turpis, a vestibulum massa. Curabitur nunc est, lacinia eu ullamcorper in, venenatis et massa. Sed interdum tempus elementum. In eros erat, luctus in auctor id, ultricies id purus. Duis ultrices eget velit eget scelerisque. Etiam non cursus purus. Nulla posuere dolor at quam mollis vehicula. Cras et justo eget enim consequat commodo ut ac quam. Vestibulum a dui nisi. ', N'2022-06-26 23:24:36', N'2022-06-26 23:24:36', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'c06cc3fb-5d2e-4918-8b3b-3530b8aeca8a', N'New Faces On Campus', NULL, N'Ut est sem, volutpat suscipit ligula a, efficitur feugiat dolor. Praesent tempus eu mi feugiat ultricies. Fusce convallis risus turpis, eu porttitor ante imperdiet quis. Sed venenatis ex in dictum placerat. Donec sed molestie lacus, consequat vulputate lectus. Morbi varius sodales ante, ut vehicula libero gravida id. Donec nulla est, posuere eget ligula sed, facilisis scelerisque lacus. Phasellus sed ante consectetur, laoreet est et, interdum mi. Vivamus ac tincidunt arcu. Quisque ut ante ultrices, pellentesque arcu non, lacinia ligula. ', N'2022-06-26 23:20:20', N'2022-06-26 23:20:20', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'd34cd113-2818-48af-8252-2b7581c89232', N'Fall Semester Admission Test Date Announcement', NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consequat lectus vehicula rhoncus finibus. Etiam eget vehicula neque, a condimentum massa. Etiam ac mi fringilla, tristique quam sit amet, finibus magna. Nullam elit orci, scelerisque nec massa condimentum, cursus congue diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec felis elit, feugiat in lacinia ac, pulvinar eget ipsum. Morbi eleifend dolor sapien. Ut ut felis ac mauris hendrerit pellentesque. Phasellus interdum placerat erat, quis aliquam est viverra non. Vestibulum egestas lacus elit, id congue mi tempor tempor. Etiam sed purus at elit dictum ornare vitae vitae magna. Sed mattis auctor mi, sed vestibulum elit blandit ut. Cras quis ligula eros. Cras varius, justo eu pretium interdum, urna dolor pharetra metus, eu consectetur est tellus et mi. Mauris accumsan pellentesque faucibus. ', N'2022-06-26 23:18:57', N'2022-06-26 23:18:57', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'dbcd089a-9d20-419e-a49d-6cbb133ff0d9', N'Interuniversity Soccer Tournament 2022', NULL, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla pulvinar tempus dolor, quis interdum ex elementum ut. Mauris volutpat maximus augue euismod consequat. Aliquam porta euismod risus id iaculis. Praesent lobortis fermentum magna in fermentum. Aenean ut nisl posuere, interdum arcu sed, luctus eros. Etiam et massa sagittis, lobortis augue aliquet, consequat est. Morbi lectus risus, fringilla at lorem nec, hendrerit ultrices orci. Pellentesque et augue eros. Morbi non magna ante. ', N'2022-06-27 10:56:19', N'2022-06-27 10:56:19', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'e154bdce-7ed2-49bc-8901-529423831d7b', N'Get Ready For Some Debate!!!', N'Annual Debating Championship 2022', N'Morbi at risus lobortis, volutpat magna in, pulvinar felis. Proin id velit arcu. Duis viverra hendrerit felis, non ultricies nulla tempus id. Nulla fermentum velit tellus, id condimentum nunc ultrices nec. Aliquam eget sagittis massa. Integer et ipsum efficitur, ultricies nunc at, ullamcorper velit. Interdum et malesuada fames ac ante ipsum primis in faucibus. In tincidunt luctus risus, in suscipit lorem vulputate et. Maecenas non nunc posuere, tristique arcu eu, bibendum nunc. Donec egestas eleifend ligula ac dictum. Praesent id diam finibus diam posuere commodo. Nullam cursus ac lorem eget maximus. Vestibulum ac eleifend neque. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Ut ultrices velit ac leo molestie tristique. ', N'2022-06-27 11:09:16', N'2022-06-27 11:09:16', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 0)"
                );

            migrationBuilder.Sql(
                    $@"INSERT INTO[dbo].[Notices] ([Id], [Title], [SubTitle], [Details], [CreatedOn], [ModifiedOn], [CreatedBy], [ModifiedBy], [IsDeleted], [TotalViews]) 
                    VALUES(N'f71c448a-7110-491f-ac84-77683aefa55c', N'New Year Celebration', N'Get ready for some fun', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras commodo iaculis est. Proin a condimentum orci, sed aliquam nisl. Vivamus in dictum felis, porttitor aliquam neque. Quisque ut mollis ligula. Proin ultrices laoreet condimentum. Maecenas egestas erat sit amet tincidunt finibus. Ut sit amet odio nisi. Integer quis faucibus magna. Fusce ac mi mollis, accumsan diam ut, tincidunt est.', N'2022-06-25 22:21:39', N'2022-06-25 22:21:39', N'da67e904-6b45-4645-9493-ebd53b8d6a32', N'da67e904-6b45-4645-9493-ebd53b8d6a32', 0, 3)"
                );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
