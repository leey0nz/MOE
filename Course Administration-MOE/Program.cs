using Course_Administration_MOE.Scenario.Approve_Course;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Course_Administration_MOE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Parallel.Invoke
            (
                () => CreateNewClassRun(),
                () => ApproveCourse()
            );
        }

        public static void CreateNewClassRun()
        {
            CreateClassrun CreateNewClassrun = new CreateClassrun();
            CreateNewClassrun.createClassrun();
        }

        public static void ApproveCourse()
        {
            ActionApproveCourse ApproveCourse = new ActionApproveCourse();
            ApproveCourse.approveCourse();
        }
    }
}
