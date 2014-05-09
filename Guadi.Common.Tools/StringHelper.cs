using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Guadi.Common.Tools
{
    /// <summary>
    /// 字符串辅助操作类
    /// </summary>
    public class StringHelper
    {
        /// <summary>
        /// 把对象转换成Json字符串表示形式
        /// </summary>
        /// <param name="jsonObject"></param>
        /// <returns></returns>
        public static string BuildJsonString(object jsonObject)
        {
            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// 大写字母
        /// </summary>
        protected static readonly char[] BigAlphabets =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };

        /// <summary>
        /// 小写字母
        /// </summary>
        protected static readonly char[] SmallAlphabets =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
            };

        /// <summary>
        /// 数字
        /// </summary>
        protected static readonly char[] Digitals =
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

        /// <summary>
        /// 生成指定长度指定类型的随机字符串(默认为大写字母随机串)
        /// </summary>
        /// <param name="type">1:大写字母，2：小写字母，3：数字，4：大写字母和小写字母，5：大写字母和数字，6：小写字母和数字，7：大小写字母和数字</param>
        /// <param name="length">随机字符创长度</param>
        /// <returns></returns>
        public static string GenerateRandomString(int length,int type=1)
        {
            if (length < 0) return "";
            StringBuilder randomStrB=new StringBuilder(length);
            Random rd=new Random(Guid.NewGuid().GetHashCode());
            char[] sourceStr = BigAlphabets;
            string bigAlphabets = BigAlphabets.ToString();
            string smaAlphabets = SmallAlphabets.ToString();
            string digitals = Digitals.ToString();
            switch (type)
            {
                case 1:
                    sourceStr = BigAlphabets;
                    break;
                case 2:
                    sourceStr = SmallAlphabets;
                    break;
                case 3:
                    sourceStr = Digitals;
                    break;
                case 4:
                    sourceStr = (bigAlphabets+smaAlphabets).ToArray();
                    break;
                case 5:
                    sourceStr = (bigAlphabets + digitals).ToArray();
                    break;
                case 6:
                    sourceStr = (smaAlphabets + digitals).ToArray();
                    break;
                case 7:
                    sourceStr = (bigAlphabets + digitals + smaAlphabets).ToArray();
                    break;
            }
            randomStrB.Append(sourceStr[rd.Next(0, sourceStr.Length)]);
            return randomStrB.ToString();
        }

    }
}
