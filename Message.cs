﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api
{
    public class Message
    {
        public string Text { get; set; }

        public Message(string message, int id)
        {
            this.Text = message;
        }


    }
}
