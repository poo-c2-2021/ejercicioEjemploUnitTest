using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Net5
{
    public class UserPassException : Exception
    {
        public UserPassException() : base("USER O PASSWORD no pueden ser null")
        {
        }

        public UserPassException(string message) : base(message)
        {
        }

      
      
    }
}
