using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Guadi.Common.Data;
using Guadi.Product.Models;
using Guadi.Product.DAO.Area;
using Guadi.Common.Tools;
using Guadi.Product.Models.ContractModels.Area;
using Guadi.Product.Models.DbModels.Area;

namespace Guadi.Product.BLL.Impl
{

    /// <summary>
    /// 地域模块业务实现
    /// </summary>
    [Export(typeof(IAreaContract))]
    internal abstract class AreaServices:ServiceBase,IAreaContract
    {
        #region 属性

        #region 受保护的属性

        /// <summary>
        /// 获取或设置 国家数据访问对象
        /// </summary>
        [Import]
        protected ICountryRepository CountryRepository { get; set; }

        #endregion

        #region 公共属性

        public IQueryable<Countrys> Countrys {
            get { return CountryRepository.Entities; }
        }

        #endregion

        #endregion

        #region 方法
        /// <summary>
        /// 添加新的国家
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual OperationResult AddNewCountry(CountryEditModel model)
        {
            Countrys country =
                CountryRepository.Entities.SingleOrDefault(
                    p => p.Name.Equals(model.Name) && p.DataStatus == EnumDataStatus.Normal);
            if (country != null)
            {
                return new OperationResult(OperationResultType.Warning,"该国家已经存在。");
            }
            Countrys newModel=new Countrys()
                {
                    CreateTime = DateTime.Now,
                    DataStatus = EnumDataStatus.Normal,
                    Latitude = model.Latitude,
                    Longitude = model.Longitude,
                    Name = model.Name,
                    UpdateTime = DateTime.Now
                };
            CountryRepository.Insert(newModel);
            return new OperationResult(OperationResultType.Success,"添加国家成功。");
        }
        #endregion
    }
}
