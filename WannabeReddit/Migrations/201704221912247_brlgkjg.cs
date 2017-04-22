namespace WannabeReddit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brlgkjg : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Posts", new[] { "User_Id" });
            DropColumn("dbo.Posts", "UserId");
            RenameColumn(table: "dbo.Posts", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Posts", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Posts", new[] { "UserId" });
            AlterColumn("dbo.Posts", "UserId", c => c.Int());
            RenameColumn(table: "dbo.Posts", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Posts", "UserId", c => c.Int());
            CreateIndex("dbo.Posts", "User_Id");
        }
    }
}
