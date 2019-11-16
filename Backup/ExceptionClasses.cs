using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExamples.ExceptionClasses
{
    class UserDefinedException : Exception 
    {   
        public UserDefinedException() : base("User Defined Exception")
        {
        }
        public UserDefinedException(string message) : base(message)
        {            
        }
        public static void ThrowUserDefinedException()
        {
            throw new UserDefinedException("Thrown User defined Exception.");
        }
        public static void ThrowUserDefinedException(string message)
        {
            throw new UserDefinedException(message);
        }
    }
}
