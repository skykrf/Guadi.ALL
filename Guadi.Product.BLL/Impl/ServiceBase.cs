using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using Guadi.Common.Data;

namespace Guadi.Product.BLL.Impl
{
    /// <summary>
    /// 核心业务实现基类
    /// </summary>
    internal abstract class ServiceBase
    {
        /// <summary>
        /// 获取或设置 工作单元对象，用于处理同步业务的实务操作
        /// </summary>
        [Import]
        protected IUnitOfWork UnitOfWork { get; set; }
    }
}
