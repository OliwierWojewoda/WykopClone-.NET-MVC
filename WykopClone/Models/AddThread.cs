﻿using static WykopClone.Models.Thread;

namespace WykopClone.Models
{
    public class AddThread
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        //public int Photo { get; set; }
        public CategoryType Category { get; set; } = Thread.CategoryType.Inna;
    }
}
