﻿using Dotmim.Sync.Builders;


using Dotmim.Sync.Log;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotmim.Sync.SqlServer.Builders
{
    public class SqlChangeTrackingBuilderTrigger : SqlBuilderTrigger
    {


        public SqlChangeTrackingBuilderTrigger(SyncTable tableDescription, DbConnection connection, DbTransaction transaction = null)
            : base(tableDescription, connection, transaction)
        {
        }

        public override Task<bool> NeedToCreateTriggerAsync(DbTriggerType type) => Task.FromResult(false);
    }
}
