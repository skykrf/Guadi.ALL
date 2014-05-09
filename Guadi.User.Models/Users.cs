using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guadi.Common.Data;

namespace Guadi.User.Models
{

    public class Users:DataBase<long>
    {
        /// <summary>
        /// 登录名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
