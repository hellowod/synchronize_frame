﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsycServer
{
    public class CProto
    {
        public const int CONNECT = 100;
        public const int READY = 101;
        public const int SYNC_POS = 102;
        public const int SYNC_KEY = 103;
        public const int START = 104;
    }
}
