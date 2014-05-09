using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Guadi.Common.Tools;
using Guadi.User.Models;
using Guadi.User.DAO;

namespace Guadi.User.BLL.Impl
{
    public abstract class UserServices:ServicesBase,IUserContract
    {
        #region 属性

        #region 保护属性

        /// <summary>
        /// 获取或设置 用户信息数据访问对象
        /// </summary>
        [Import]
        protected IUserRepository UserRepository { get; set; }

        #endregion

        #region 公共属性
        public IQueryable<Users> Users { get { return UserRepository.Entities; }}
        #endregion

        #endregion

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="loginInfo">登录信息</param>
        /// <returns>业务操作结果</returns>
        public virtual OperationResult Login(LoginInfo loginInfo)
        {
            Users user = UserRepository.Entities.SingleOrDefault(p => p.UserName == loginInfo.Account);
            if (user == null)
            {
                return new OperationResult(OperationResultType.QueryNull,"指定账户的用户不存在。");
            }
            if (user.Password != loginInfo.Password)
            {
                return new OperationResult(OperationResultType.Warning,"登录密码不正确。");
            }
            return new OperationResult(OperationResultType.Success,"登录成功。",user);
        }

    }
}
