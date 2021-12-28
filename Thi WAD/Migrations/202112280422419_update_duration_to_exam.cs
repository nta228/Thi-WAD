using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;
namespace Thi_WAD.Migrations
{
    public partial class update_duration_to_exam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Exams", "ExamDuration", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Exams", "ExamDuration", c => c.String());
        }
    }
}