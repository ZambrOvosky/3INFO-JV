﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenatinhaPlace.Entity {
    public class Func : People {
        public virtual People People { get; set; }
        public int PeopleId { get; set; }
        public string Address { get; set; }
        public byte[] Pic { get; set; } //https://stackoverflow.com/questions/4653095/how-to-store-images-using-entity-framework-code-first-ctp-5?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
        public virtual FuncType Type { get; set; }
        public int TypeId { get; set; }
    }
}
