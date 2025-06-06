namespace CourseWork
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            UniversitiesManager universitiesManager = new UniversitiesManager();
            Application.Run(new Applicants_Handbook(universitiesManager));
        }

        public static bool IsExitingProgram = false;

        public static void ExitApplication()
        {
            IsExitingProgram = true;
            Application.Exit();   
        }
    }
}