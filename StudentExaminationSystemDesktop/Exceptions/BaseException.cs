using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Exceptions
{
    internal class BaseException : Exception
    {
        public string Caption { get; set; }

        public BaseException(string message, string caption) : base(message)
        {
            Caption = caption;
        }
    }
}
