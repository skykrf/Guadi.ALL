using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guadi.Product.Models;
using Guadi.Common.Tools;
using Guadi.Product.Models.ContractModels.Area;
using Guadi.Product.Models.DbModels.Area;

namespace Guadi.Product.BLL
{

    /// <summary>
    /// 地域模块核心业务契约
    /// </summary>
    public interface IAreaContract
    {
        #region 属性

        /// <summary>
        /// 获取  国际信息查询数据集
        /// </summary>
        IQueryable<Countrys> Countrys { get; }

        #endregion

        #region 公共方法

        /// <summary>
        /// 添加新的国家
        /// </summary>
        /// <returns></returns>
        OperationResult AddNewCountry(CountryEditModel model);

        #endregion
    }
}
