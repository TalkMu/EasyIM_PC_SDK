using EasyIM_PC_SDK.Constant;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyIM_PC_SDK.Api
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  AuthenticationApi 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2022/3/3 13:56:54 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 13:56:54 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class AuthenticationApi
    {
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="AccessKeyId">应用Key</param>
        /// <returns></returns>
        public string GetToken(string AccessKeyId) 
        {
            string url = BaseConstant.IM_SERVICE_HOST + "/platform/mobilAuth";
            List<KeyValuePair<string, string>> paramList = new List<KeyValuePair<string, string>>();
            paramList.Add(new KeyValuePair<string, string>("accessKeyId", AccessKeyId));
            string result = HttpHelper.PostForm(url, paramList);
            var apiResult = JsonHelper.ToBean<ApiResult<string>>(result);
            return apiResult.Data;
        }
    }
}
