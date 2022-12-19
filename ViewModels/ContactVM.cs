﻿using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class ContactVM
    {
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<Subscribe> Subscribes { get; set; }
    }
}
