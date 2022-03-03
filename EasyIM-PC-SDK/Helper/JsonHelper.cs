using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyIM_PC_SDK.Helper
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  JsonHelper 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2022/3/3 14:49:38 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 14:49:38 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class JsonHelper
    {
        /// <summary>
        /// 创建JObject
        /// </summary>
        /// <returns></returns>
        public JObject CreateObj()
        {
            return new JObject();
        }

        /// <summary>
        /// 创建JArray
        /// </summary>
        /// <returns></returns>
        public JArray CreateArray()
        {
            return new JArray();
        }

        /// <summary>
        /// JSON字符串转JObject对象
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public JObject ParseObj(string jsonStr)
        {
            return new JObject(jsonStr);
        }

        /// <summary>
        /// JSON字符串转JArray对象
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public JArray ParseArray(string jsonStr)
        {
            return new JArray(jsonStr);
        }

        /// <summary>
        /// 对象转JSON字符串
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJsonStr(Object obj)
        {
            if (obj == null)
            {
                return "";
            }
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// SON字符串转为实体类对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T ToBean<T>(string jsonStr) where T : class
        {
            return JsonConvert.DeserializeObject<T>(jsonStr);
        }
    }
}
