using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guadi.Web.Edit.Models
{
    public class ProductAddModel
    {
        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品中文名
        /// </summary>
        public string ProductChineseName { get; set; }

        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// 销售价
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public decimal MarketPrice { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        public decimal LowstPrice { get; set; }

        /// <summary>
        /// 是否上架
        /// </summary>
        public bool IsOnSale { get; set; }

        /// <summary>
        /// 产品分类ID
        /// </summary>
        public int CategoryId { get; set; }

    }
}