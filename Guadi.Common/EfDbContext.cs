using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Guadi.Common.Data
{

    /// <summary>
    /// EF数据访问上下文
    /// </summary>
    [Export("EF",typeof(DbContext))]
    public class EfDbContext:DbContext
    {
        public EfDbContext()
            : base("default")
        {
        }

        public EfDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public EfDbContext(DbConnection existingConnection)
            : base(existingConnection, true)
        {
            
        }
    }
}
