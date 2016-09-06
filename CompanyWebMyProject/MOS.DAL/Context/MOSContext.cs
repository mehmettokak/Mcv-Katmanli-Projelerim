using CompanyWeb.Entity.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CompanyWeb.DAL.Context
{
    public class CompanyWebContext : DbContext
    {
        public CompanyWebContext() : base("CompanyWebContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLang > EmployeeLangs { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderLang> SliderLangs { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<ReferenceLang> ReferenceLang { get; set; }
        public  DbSet<Page> Pages { get; set; }
        public DbSet<PageLang> PageLangs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyLang> CompanyLangs { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryLang> CategoryLangs { get; set; }
      


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // İlişkileri kuruyoruz one-to-many olarak.

            #region Category=>CategoryLang=>Languages Relation

            #region Category=>CategoryLangs

            modelBuilder.Entity<CategoryLang>()
                .HasRequired(x => x.Category)
                .WithMany(x => x.CategoryLangs)
                .HasForeignKey(x => x.CategoryId);
            #endregion

            #region Category=>Categories
            modelBuilder.Entity<Category>()
                .HasRequired(x => x.MainCategory)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.MainId);

            #endregion

            #region Languages=>Categories

            modelBuilder.Entity<CategoryLang>()
                .HasRequired(x => x.Language)
                .WithMany(x => x.CategoryLangs)
                .HasForeignKey(x => x.LanguageId);

            #endregion

            //#region Category=>Product

            //modelBuilder.Entity<Product>()
            //    .HasRequired(x => x.Category)
            //    .WithMany(x => x.Products)
            //    .HasForeignKey(x => x.CategoryId);

            //#endregion

            #endregion


            //#region Product=>ProductLang=>Language Relation

            //#region Product=>ProductLang

            //modelBuilder.Entity<ProductLang>()
            //     .HasRequired(x => x.Product)
            //     .WithMany(x => x.ProductLangs)
            //     .HasForeignKey(x => x.ProdutId);
            //#endregion

            //#region Languages=>ProductLang
            //modelBuilder.Entity<ProductLang>()
            //     .HasRequired(x => x.Language)
            //     .WithMany(x => x.ProductLangs)
            //     .HasForeignKey(x => x.LanguageId);


            //#endregion

            //#endregion

            #region Employee=>EmployeeLang=>Language Relation
            #region Emplooye=>EmployeeLang

            modelBuilder.Entity<EmployeeLang>()
                .HasRequired(x => x.Employee)
                .WithMany(x => x.EmployeeLangs)
                .HasForeignKey(x => x.EmployeeId);
            #endregion

            #region Languages=>EmployeLang

            modelBuilder.Entity<EmployeeLang>()
                .HasRequired(x => x.Language)
                .WithMany(x => x.EmployeeLangs)
                .HasForeignKey(x => x.LanguageId);

            #endregion

            #region Employee=>SocialLink
            modelBuilder.Entity<SocialLink>()
                .HasRequired(x => x.Employee)
                .WithMany(x => x.SocialLinks)
                .HasForeignKey(x => x.EmployeeID);
            #endregion

            #endregion

            #region Slider=>SliderLang=>Language Relation
            #region Slider=>SliderLang

            modelBuilder.Entity<SliderLang>()
                .HasRequired(x => x.Slider)
                .WithMany(x => x.SliderLangs)
                .HasForeignKey(x => x.SliderId);
            #endregion

            #region Languages=>SLiderLang

            modelBuilder.Entity<SliderLang>()
                .HasRequired(x => x.Language)
                .WithMany(x => x.SliderLangs)
                .HasForeignKey(x => x.LanguageId);

            #endregion

            #endregion

            #region Reference=>ReferenceLang=>Language Relation
            #region Reference=>ReferenceLang

            modelBuilder.Entity<ReferenceLang>()
                .HasRequired(x => x.Reference)
                .WithMany(x => x.ReferenceLangs)
                .HasForeignKey(x => x.ReferenceId);
            #endregion

            #region Languages=>ReferenceLang

            modelBuilder.Entity<ReferenceLang>()
                .HasRequired(x => x.Language)
                .WithMany(x => x.ReferenceLangs)
                .HasForeignKey(x => x.LanguageId);

            #endregion

            #endregion

            #region Page=>PageLang=>Language Relation

            #region Page=>PageLang

            modelBuilder.Entity<PageLang>()
                .HasRequired(x => x.Page)
                .WithMany(x => x.PageLangs)
                .HasForeignKey(x => x.PageId);
            #endregion

            #region Languages=>PageLang

            modelBuilder.Entity<PageLang>()
                .HasRequired(x => x.Language)
                .WithMany(x => x.PageLangs)
                .HasForeignKey(x => x.LanguageId);

            #endregion

            #endregion

            #region Company=>CompanyLang=>Language Relation

            #region Company=>CompanyLang

            modelBuilder.Entity<CompanyLang>()
                 .HasRequired(x => x.Company)
                 .WithMany(x => x.CompanyLangs)
                 .HasForeignKey(x => x.CompanyId);
            #endregion

            #region Languages=>CompanyLang
            modelBuilder.Entity<CompanyLang>()
                 .HasRequired(x => x.Language)
                 .WithMany(x => x.CompanyLangs)
                 .HasForeignKey(x => x.LanguageId);


            #endregion

            #endregion


        }
    }
}
