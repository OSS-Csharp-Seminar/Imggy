﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public class Album
    {
        public int id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public string name { get; set; }
        public bool isPublic { get; set; }
        public DateTime dateOfCreation { get; set; }
        public List<Post> posts { get; set; }
    }
}