using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Guadi.Common.Data;
using Guadi.User.Models;

namespace Guadi.User.DAO.Impl
{

    /// <summary>
    /// 仓储操作层实现--用户信息
    /// </summary>
    [Export(typeof(IUserRepository))]
    public partial class UserRepository:EfRepositoryBase<Users,long>,IUserRepository
    {
    }
}
