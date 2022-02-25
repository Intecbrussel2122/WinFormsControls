﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsControls
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsVIP { get; set; }
        public int Country { get; set; }

        public override string ToString()
        {
            return $"{Id}-{FirstName}-{LastName}-{Age}-{IsVIP}-{Country}";
        }
    }
}
