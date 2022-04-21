using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI.Modele.Exceptions
{
    internal class ExceptionsLiaison : Exception
    {
        public ExceptionsLiaison()
        {

        }

        public ExceptionsLiaison(string message) : base(message)
        {

        }
    }
}
