﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Samourai
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Force { get; set; }
        
        public Arme? Arme { get; set; }
    }
}
