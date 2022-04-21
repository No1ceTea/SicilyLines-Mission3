using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI.Modele.Exceptions
{
    internal class ExceptionsTarif : Exception
    {
        public ExceptionsTarif()
        {

        }

        public ExceptionsTarif(string message) : base(message)
        {

        }
    }
}
