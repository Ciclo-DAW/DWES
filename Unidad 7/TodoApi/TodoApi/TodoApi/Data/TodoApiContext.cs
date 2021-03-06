﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodoApiContext : IdentityDbContext<IdentityUser>
    {
        public TodoApiContext(DbContextOptions<TodoApiContext> options) : base(options)
        { }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
