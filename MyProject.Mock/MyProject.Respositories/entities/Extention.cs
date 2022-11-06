using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Respositories.entities
{
   static class Extention
    {
        public  static bool Valid(this int evenAccount){
            return (evenAccount % 2 == 0);
        }
    }
}
