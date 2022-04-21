using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI.Modele.Exceptions
{
    internal class ExceptionsDuree : Exception
    {
        public ExceptionsDuree()
        {

        }

        public ExceptionsDuree(string message) : base(message)
        {

        }
    }
}
