﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using ERPDemoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ERPDemoAPI.Models.Context;

public partial class ERPDemoAPIContext : DbContext
{
    public ERPDemoAPIContext()
    {
    }

    public ERPDemoAPIContext(DbContextOptions<ERPDemoAPIContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}