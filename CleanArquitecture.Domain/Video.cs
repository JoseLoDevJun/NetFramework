﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArquitecture.Domain
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StreamrId {  get; set; }
        public virtual Streamer? Streamer { get; set; }
    }
}
