namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFollowingsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Followings",
                c => new
                    {
                        FolloweerId = c.String(nullable: false, maxLength: 128),
                        FolloweeId = c.String(nullable: false, maxLength: 128),
                        Follwee_Id = c.String(maxLength: 128),
                        Flolower_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FolloweerId, t.FolloweeId })
                .ForeignKey("dbo.AspNetUsers", t => t.Follwee_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Flolower_Id)
                .Index(t => t.Follwee_Id)
                .Index(t => t.Flolower_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Followings", "Flolower_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Followings", "Follwee_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Followings", new[] { "Flolower_Id" });
            DropIndex("dbo.Followings", new[] { "Follwee_Id" });
            DropTable("dbo.Followings");
        }
    }
}
