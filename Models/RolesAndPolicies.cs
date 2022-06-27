namespace NoticeBoardApp.Models
{
    public class RolesAndPolicies
    {
        public static class Roles
        {
            public const string Administrator = "Administrator";
            public const string RegularUser = "RegularUser";
        }

        public static class Policies
        {
            public const string RequireAdmin = "RequireAdmin";
            public const string RequireRegularUser = "RequireRegularUser";
        }
    }
}
