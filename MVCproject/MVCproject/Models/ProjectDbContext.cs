﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCproject.Models
{
    public class ProjectDbContext:DbContext
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Course> Courses { set; get; }
 
    }
}