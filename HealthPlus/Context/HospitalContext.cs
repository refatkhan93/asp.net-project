﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HealthPlus.Models;

namespace HealthPlus.Context
{
    public class HospitalContext:DbContext
    {
        public DbSet<Service> Service { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<DoctorCategory> DoctorCategory { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Receptionist> Receptionist { get; set; }
        public DbSet<Blood> Blood { get; set; }
        public DbSet<Nurse> Nurse { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public DbSet<SystemAdmin> SystemAdmin { get; set; }
        
    }
}