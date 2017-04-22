namespace WannabeReddit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablechanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "DatePosted", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "DatePosted");
        }
    }
}
