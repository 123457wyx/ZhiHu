﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public  class job
    {
         [Key]
         public int jobid { get; set; }
        public string  id { get; set; }
        public string name { get; set; }
        public string introduction { get; set; }
        public string excerpt { get; set; }
        public string url { get; set; }
        public string avatarUrl { get; set; }
        public string type { get; set; }
        public virtual ICollection<employments> employments { get; set; }
    }
}
