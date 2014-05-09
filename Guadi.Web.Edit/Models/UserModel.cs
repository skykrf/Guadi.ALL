using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guadi.Web.Edit.Models
{
    public class UserModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        public string ContractEmail { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContractNumber { get; set; }

        /// <summary>
        /// 会员等级
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 会员状态
        /// </summary>
        public string Status { get; set; }

    }


    /// <summary>
    /// 
    /// </summary>
    public class UserListData
    {
        public int total { get; set; }

        public List<UserModel> rows { get; set; }
    }

}