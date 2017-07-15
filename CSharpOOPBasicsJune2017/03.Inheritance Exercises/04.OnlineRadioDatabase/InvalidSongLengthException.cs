﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OnlineRadioDatabase
{
   public class InvalidSongLengthException : InvalidSongException
    {
        private const string Message = "Invalid song length.";

        public InvalidSongLengthException()
            :base(Message)
        {

        }

        public InvalidSongLengthException(string message) 
            :base(message)
        {
        }
    }
}
