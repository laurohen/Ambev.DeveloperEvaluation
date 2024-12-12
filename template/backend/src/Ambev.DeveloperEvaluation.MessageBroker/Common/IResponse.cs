﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker.Common
{
    public interface IResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
