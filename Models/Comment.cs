﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_test.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Text { get; set; }
    }
}