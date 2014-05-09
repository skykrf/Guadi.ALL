using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guadi.Common.Data
{
    /// <summary>
    /// 数据库连接串名称
    /// </summary>
    public sealed class DbConnectionConfig
    {
        /// <summary>
        /// 用户数据库连接串名称
        /// </summary>
        public static string UserDbConnectionString = "UserDbConnectionString";

        /// <summary>
        /// 产品数据库连接串名称
        /// </summary>
        public static string ProductDbConnectionString = "ProductDbConnectionString";

        /// <summary>
        /// 订单数据库连接串名称
        /// </summary>
        public static string OrderDbConnectionString = "OrderDbConnectionString";

        /// <summary>
        /// 基础数据库连接串名称
        /// </summary>
        public static string CommonDbConnectionString = "CommonDbConnectionString";
    }
}
