﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Staff
    {
        public int code;
        public string name;
        
        Teacher teacher;
      
        public Staff()
        {
            teacher = new Teacher();
        }
        public string whoAmI()
        {
            string info = teacher.getInfo() + "-staff";
            return info; 
        }
    }
}
