﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDrugie.ViewModels {
    public class AnimalPicture {
        public string FileName { get; set; }

        public AnimalPicture(string fileName) {
            FileName = fileName;
        }
    }
}
