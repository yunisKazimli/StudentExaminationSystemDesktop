using StudentExaminationSystemDesktop.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Admin
{
    public partial class AdminForm
    {
        private void Logout()
        {
            _mainForm.OpenForm(new EntranceForm(_mainForm));
        }
    }
}
