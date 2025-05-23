namespace CourseWork
{
    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static string FullName { get; set; }

        public static void Clear()
        {
            Username = null;
            Role = null;
            FullName = null;
        }
    }
}