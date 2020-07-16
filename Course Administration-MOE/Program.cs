using Course_Administration_MOE.Scenario.Approve_Course;
using System;
using System.Collections.Generic;
using System.Text;

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
            ActionApproveCourse ApproveCourse = new ActionApproveCourse();
            ApproveCourse.approveCourse();

            CreateClassrun CreateNewClassrun = new CreateClassrun();
            CreateNewClassrun.createClassrun();
        }
    }
}
