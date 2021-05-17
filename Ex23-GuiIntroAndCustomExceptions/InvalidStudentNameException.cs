using System;
using System.Collections.Generic;
using System.Text;

namespace Ex23_GuiIntroAndCustomExceptions
{
    public class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException()
        {

        }

        public InvalidStudentNameException(string message) : base(message)
        {

        }

        public InvalidStudentNameException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
