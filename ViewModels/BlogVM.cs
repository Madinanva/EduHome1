﻿using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ComponentViewModels
{
    public class BlogVM
    {
        public IEnumerable<Subscribe> Subscribes { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public IEnumerable<BlogMessage> BlogMessages { get; set; }
    }
}