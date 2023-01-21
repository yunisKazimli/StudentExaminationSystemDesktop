using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using StudentExaminationSystemDesktop.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StudentExaminationSystemDesktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
//eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI3ZGJlMjQwYy04ODc4LTQyYzktOThhZi1mMTM1Nzc1M2QzNTIiLCJqdGkiOiI5OGQ0ZmUxNy02MDViLTQxNTMtODBmMy01NjI2ZjQ4MTQ1MjIiLCJyb2xlIjoiQWRtaW4iLCJuYmYiOjE2NzQzMjIzMjIsImV4cCI6MTY3NDQwODcyMiwiaWF0IjoxNjc0MzIyMzIyLCJpc3MiOiJDb21wYXJBY2FkZW15IiwiYXVkIjoiQ29tcGFyQWNhZGVteSJ9.1ZnSs7p_9qoDlUyDuTHO2RudGBXFHmEDhVWwtgzBMvE