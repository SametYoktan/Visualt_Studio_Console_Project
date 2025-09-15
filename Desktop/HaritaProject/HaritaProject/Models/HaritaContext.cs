using System.Collections.Generic;
using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
namespace HaritaProject.Models
{
	public class HaritaContext:DbContext
	{
		public HaritaContext(DbContextOptions<HaritaContext> options) : base(options)
		{

		}
		public DbSet<Student> Student { get; set; }
		// Yeni tabloları DbContext'e ekliyoruz
	}
}
