﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    class Artist {
        public string Type { get; set; }
        public string Gen { get; set; }
        public decimal Pay { get; set; }
        public virtual People People { get; set; }
        public int PeopleId { get; set; }
    }
}