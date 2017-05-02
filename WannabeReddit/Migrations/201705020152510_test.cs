namespace WannabeReddit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostVotes", "PostId", "dbo.Posts");
            DropIndex("dbo.PostVotes", new[] { "PostId" });
            DropTable("dbo.PostVotes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PostVotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        VoteCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.PostVotes", "PostId");
            AddForeignKey("dbo.PostVotes", "PostId", "dbo.Posts", "Id", cascadeDelete: true);
        }
    }
}
