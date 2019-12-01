using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace BusinessLogicLayer
{
    public  class InputValidator
    {
        //Checks if Player's name is correct or not.
        public static bool isValidName(string playerName)
        {
            bool isValid = true;
            
            if(playerName=="")
            {
                isValid = false;
            }
            else
            {
                for(int index=0;index<playerName.Length;index++)
                {
                    if(playerName[index]>='0'&&playerName[index]<='9')
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }
        //--------------------------------------------------------------------------------- 
        //--------------------------------------------------------------------------------- 

        //Checks if Player's Cnic is correct ot not.
        public static bool isValidCnic(string playerCnic)
        {
            bool isValid = true;
            Regex cnicRegex = new Regex(@"^\d{5}\-?\d{7}\-?\d{1}$");
            bool isMatch = cnicRegex.IsMatch(playerCnic);
            if (playerCnic == ""|| !isMatch)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
        //--------------------------------------------------------------------------------- 
        //--------------------------------------------------------------------------------- 

    }//End Class.
}//End Namespace.
