using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{

    /* Application: COMP123 Final Exam - Character Creator
     * Nick Morin - 300654901
     * 2016-08-19
     */ 
    public static class Program
    {
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
