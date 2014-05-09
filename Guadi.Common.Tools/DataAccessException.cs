using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Guadi.Common.Tools
{

    /// <summary>
    /// 数据访问层异常类，用于封装数据访问层引发的异常，以供业务逻辑层抓取
    /// </summary>
    [Serializable]
    public class DataAccessException:Exception
    {

        public DataAccessException()
        {
        }

        /// <summary>
        /// 使用异常消息实例化一个新实例
        /// </summary>
        /// <param name="message"></param>
        public DataAccessException(string message) : base(message)
        {
        }

        /// <summary>
        /// 使用异常消息与一个内部异常实例化一个新实例
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public DataAccessException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        ///     使用可序列化数据实例化一个新实例
        /// </summary>
        /// <param name="info">保存序列化对象数据的对象。</param>
        /// <param name="context">有关源或目标的上下文信息。</param>
        protected DataAccessException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
