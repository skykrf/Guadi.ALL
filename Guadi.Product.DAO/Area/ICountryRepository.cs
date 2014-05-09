using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Guadi.Common.Data;
using Guadi.Product.Models;
using Guadi.Product.Models.DbModels.Area;

namespace Guadi.Product.DAO.Area
{

    /// <summary>
    ///仓储操作接口--国家信息
    /// </summary>
    public partial interface ICountryRepository:IRepository<Countrys,int>
    {}
}
