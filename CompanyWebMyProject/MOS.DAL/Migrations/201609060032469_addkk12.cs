namespace CompanyWeb.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addkk12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CategoryLang", "Content", c => c.String());
            AlterColumn("dbo.CategoryLang", "Name", c => c.String());
            AlterColumn("dbo.CategoryLang", "Link", c => c.String(maxLength: 50));
            AlterColumn("dbo.CompanyLang", "Adress", c => c.String(maxLength: 100));
            AlterColumn("dbo.CompanyLang", "Copyright", c => c.String(maxLength: 50));
            AlterColumn("dbo.Company", "EMail", c => c.String(maxLength: 60));
            AlterColumn("dbo.Company", "Phone1", c => c.String(maxLength: 11));
            AlterColumn("dbo.Company", "Phone2", c => c.String(maxLength: 11));
            AlterColumn("dbo.Company", "Fax", c => c.String(maxLength: 11));
            AlterColumn("dbo.Company", "FacebookUrl", c => c.String(maxLength: 200));
            AlterColumn("dbo.Company", "TwitterUrl", c => c.String(maxLength: 200));
            AlterColumn("dbo.Company", "LinkedinUrl", c => c.String(maxLength: 200));
            AlterColumn("dbo.EmployeeLang", "Title", c => c.String(maxLength: 50));
            AlterColumn("dbo.EmployeeLang", "Description", c => c.String(maxLength: 240));
            AlterColumn("dbo.Employee", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employee", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employee", "AvatarURL", c => c.String(maxLength: 200));
            AlterColumn("dbo.Employee", "Email", c => c.String(maxLength: 60));
            AlterColumn("dbo.Employee", "MobilePhone", c => c.String(maxLength: 11));
            AlterColumn("dbo.PageLang", "Title", c => c.String(maxLength: 100));
            AlterColumn("dbo.Page", "Code", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReferenceLang", "LogoName", c => c.String(maxLength: 50));
            AlterColumn("dbo.ReferenceLang", "Testimonial", c => c.String(maxLength: 600));
            AlterColumn("dbo.Reference", "ImageURL", c => c.String(maxLength: 200));
            AlterColumn("dbo.Reference", "WebURL", c => c.String(maxLength: 200));
            AlterColumn("dbo.SliderLang", "Title", c => c.String(maxLength: 80));
            AlterColumn("dbo.Slider", "ImageUrl", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Slider", "ImageUrl", c => c.String());
            AlterColumn("dbo.SliderLang", "Title", c => c.String());
            AlterColumn("dbo.Reference", "WebURL", c => c.String(maxLength: 400));
            AlterColumn("dbo.Reference", "ImageURL", c => c.String(maxLength: 400));
            AlterColumn("dbo.ReferenceLang", "Testimonial", c => c.String());
            AlterColumn("dbo.ReferenceLang", "LogoName", c => c.String());
            AlterColumn("dbo.Page", "Code", c => c.String());
            AlterColumn("dbo.PageLang", "Title", c => c.String());
            AlterColumn("dbo.Employee", "MobilePhone", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employee", "Email", c => c.String(maxLength: 255));
            AlterColumn("dbo.Employee", "AvatarURL", c => c.String(maxLength: 400));
            AlterColumn("dbo.Employee", "LastName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Employee", "FirstName", c => c.String(maxLength: 255));
            AlterColumn("dbo.EmployeeLang", "Description", c => c.String());
            AlterColumn("dbo.EmployeeLang", "Title", c => c.String());
            AlterColumn("dbo.Company", "LinkedinUrl", c => c.String());
            AlterColumn("dbo.Company", "TwitterUrl", c => c.String());
            AlterColumn("dbo.Company", "FacebookUrl", c => c.String());
            AlterColumn("dbo.Company", "Fax", c => c.String());
            AlterColumn("dbo.Company", "Phone2", c => c.String());
            AlterColumn("dbo.Company", "Phone1", c => c.String());
            AlterColumn("dbo.Company", "EMail", c => c.String());
            AlterColumn("dbo.CompanyLang", "Copyright", c => c.String());
            AlterColumn("dbo.CompanyLang", "Adress", c => c.String());
            AlterColumn("dbo.CategoryLang", "Link", c => c.String(maxLength: 400));
            AlterColumn("dbo.CategoryLang", "Name", c => c.String(maxLength: 200));
            DropColumn("dbo.CategoryLang", "Content");
        }
    }
}
