﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WherePigsFlyFms.Models;

namespace WherePigsFlyFms.Data
{
    public class FmsDbContext : DbContext
    {
        public FmsDbContext() : base("name=FmsDb")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Animals> Animals { get; set; }
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
    }
}