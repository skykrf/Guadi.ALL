using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guadi.Common.Data;
using Guadi.User.Models;

namespace Guadi.User.DAO
{

    /// <summary>
    /// 仓库操作接口-用户信息
    /// </summary>
    public partial interface IUserRepository:IRepository<Users,long>
    {
    }
}
