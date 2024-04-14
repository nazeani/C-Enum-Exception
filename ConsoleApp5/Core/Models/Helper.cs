using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public static class Helper
    {
        public static bool NameOrSurname(string surname)
        {
            if (surname[1].ToString() == surname.ToUpper()&& surname.Length>=3)
            {
                return true;
            }
                return false;
                  
        }

       
    }
}
