using System.ComponentModel.Composition;
using Guadi.Common.Data;
using Guadi.Product.Models.DbModels.Area;

namespace Guadi.Product.DAO.Area.Impl
{

    /// <summary>
    /// 仓储操作层实现
    /// </summary>
    [Export(typeof(ICountryRepository))]
    public partial class CountryRepository:EfRepositoryBase<Countrys,int>,ICountryRepository
    {}
}
