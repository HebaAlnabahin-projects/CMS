using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Core.Exceptions
{
    public class DuplicateEmailOrPhone : Exception
    {
        public DuplicateEmailOrPhone():base("Duplicate Email or Phone Exception")
        {

        }
    }
}
