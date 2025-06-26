using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer.Concrete;

namespace DataAcessLayer.Concrete
{
	public class Context: DbContext
	{
		public Context() : base("name=ConnectionString")
		{
			//Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
			//Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
			//Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
			//Database.SetInitializer(new NullDatabaseInitializer<Context>());
		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Heading> Headings { get; set; }
		public DbSet<Content> Contents { get; set; }
		public DbSet<Writer> Writers { get; set; }
		
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Content>().HasRequired(c => c.Writer).WithMany(w => w.Contents).HasForeignKey(c => c.WriterID);
			modelBuilder.Entity<Heading>().HasRequired(h => h.Category).WithMany(c => c.Headings).HasForeignKey(h => h.CategoryID);
			modelBuilder.Entity<Heading>().HasRequired(h => h.Writer).WithMany(w => w.Headings).HasForeignKey(h => h.WriterID);
			base.OnModelCreating(modelBuilder);
		}
	}
	{
		
	}
}
