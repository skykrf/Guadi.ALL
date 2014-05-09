using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guadi.Product.Models.ContractModels.Area
{
    public class CountryEditModel
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        public double Latitude { get; set; }
    }
}
