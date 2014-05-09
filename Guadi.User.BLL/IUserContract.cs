using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guadi.User.DAO;
using Guadi.Common.Tools;
using Guadi.User.Models;

namespace Guadi.User.BLL
{

    /// <summary>
    /// 用户模块核心业务契约
    /// </summary>
    public interface IUserContract
    {
        #region 属性

        /// <summary>
        /// 获取 用户信息查询数据集
        /// </summary>
        IQueryable<Users> Users { get; }

        #endregion

        #region 公共方法

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        OperationResult Login(LoginInfo loginInfo);

        #endregion
    }
}
