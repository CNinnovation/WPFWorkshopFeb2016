﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PriorityBindingSample
{
    public class SomeDataInfo
    {
        public string Info1
        {
            get
            {
                return "please wait...";
            }
        }

        public string Info2
        {
            get
            {
                Thread.Sleep(3000);
                return "some more waiting is necessary...";
            }
        }

    }
}
