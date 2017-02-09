using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Member
{
    class ValidationException :Exception
    {
        public ValidationException(String errorMessage):base(errorMessage)
        {
            
        }

        public String GetMessage()
        {
            return base.Message;
        }
    }
}
