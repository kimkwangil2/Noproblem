﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Repository.NopModels
{
    public class CommonBoards :BaseModel
    {
        public string Title { get; set; }
        public string Contents { get; set; }

        public string Tag { get; set; }
        public string UID { get; set; }

        public char DelYN { get; set; }
    }
}
