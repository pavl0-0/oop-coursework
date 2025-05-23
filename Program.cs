namespace CourseWork
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Applicants_Handbook());
        }

        public static bool IsExitingProgram = false;

        public static void ExitApplication()
        {
            IsExitingProgram = true;
            Application.Exit();   
        }
    }
}