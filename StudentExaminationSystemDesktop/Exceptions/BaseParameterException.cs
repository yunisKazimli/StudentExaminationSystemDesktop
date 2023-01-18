using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExaminationSystemDesktop.Exceptions
{
    internal class BaseParameterException : BaseException
    {
        public BaseParameterException(string message, string caption) : base(message, caption) { }
    }
}
