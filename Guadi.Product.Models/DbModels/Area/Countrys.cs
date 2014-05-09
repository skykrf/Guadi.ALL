using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Guadi.Common.Data;

namespace Guadi.Product.Models.DbModels.Area
{
    /// <summary>
    /// 国家
    /// </summary>
    public class Countrys:DataBase<int>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [Required]
        public double Longitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [Required]
        public double Latitude { get; set; }
    }
}
