using System;
using System.Collections.Generic;
using System.Text;

namespace Ex23_GuiIntroAndCustomExceptions
{
    public class InvalidPresidentName : Exception
    {
        public InvalidPresidentName()
        {

        }

        public InvalidPresidentName(string message) : base(message)
        {

        }

        public InvalidPresidentName(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
