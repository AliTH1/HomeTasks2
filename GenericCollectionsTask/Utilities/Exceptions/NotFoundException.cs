﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsTask.Utilities.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
