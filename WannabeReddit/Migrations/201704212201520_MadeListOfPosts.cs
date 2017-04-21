namespace WannabeReddit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeListOfPosts : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UpVotes", c => c.Int());
            AlterColumn("dbo.Posts", "DownVotes", c => c.Int());
            AlterColumn("dbo.Posts", "UserId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "DownVotes", c => c.Int(nullable: false));
            AlterColumn("dbo.Posts", "UpVotes", c => c.Int(nullable: false));
        }
    }
}
