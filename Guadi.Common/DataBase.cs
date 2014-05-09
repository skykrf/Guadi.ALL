using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Guadi.Common.Data
{
    /// <summary>
    /// Guadi数据基础类(所有数据库表映射实体都必须继承该类)
    /// </summary>
    [Serializable]
    public class DataBase<TKey>
    {

        [Required,Column("Id")]
        public TKey Id { get; set; }

        [Required,Column("CreateTime")]
        public DateTime CreateTime { get; set; }

        [Required,Column("UpdateTime")]
        public DateTime UpdateTime { get; set; }

        [NotMapped]
        public EnumDataStatus DataStatus
        {
            get { return (EnumDataStatus) Enum.ToObject(typeof (EnumDataStatus), DataState); }
            set { DataState =(byte)value; }
        }

        [Required,Column("DataState")]
        public byte DataState { get; private set; }

    }


    /// <summary>
    /// 数据状态枚举
    /// </summary>
    public enum  EnumDataStatus:byte
    {
        /// <summary>
        /// 正常(默认)
        /// </summary>
        Normal=0,

        /// <summary>
        ///删除
        /// </summary>
        Deleted=1
    }
}
