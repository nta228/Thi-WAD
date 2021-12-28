using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.CodeDom.Compiler;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace Thi_WAD.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class update_duration_to_exam : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(update_duration_to_exam));

        string IMigrationMetadata.Id
        {
            get { return "202112280422419_update_duration_to_exam"; }
        }

        string IMigrationMetadata.Source
        {
            get { return null; }
        }

        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}