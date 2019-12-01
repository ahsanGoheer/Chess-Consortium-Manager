using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NoDataToShowException:ApplicationException
    {
        //Attribute.
        string errormessage;
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

        //Constructor.
        public NoDataToShowException(string message)
        {
            this.errormessage = message;
        }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 

        //Property
        public string ErrorMessage { get => errormessage; set => errormessage=value; }
        //---------------------------------------------------------------------------------------------- 
        //---------------------------------------------------------------------------------------------- 


    }//End Class.
}//End Namespace.
