using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NoDataToShowException:ApplicationException
    {
        string errormessage;
        public NoDataToShowException(string message)
        {
            this.errormessage = message;
        }

        public string ErrorMessage { get => errormessage; set => errormessage=value; }

    }
}
