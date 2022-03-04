using EasyIM_PC_SDK.Constant;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Result;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EasyIM_PC_SDK.Api
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  UserApi 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2022/3/3 13:56:29 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 13:56:29 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class UserApi
    {
        private ApiClient apiClient { get; set; }

        public UserApi():this(IMConfiguration.GetDefaultApiClient())
        {
            
        }
        public UserApi(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public ApiResult<string> Register(string userName,string password) 
        {
            string url = BaseConstant.IM_SERVICE_HOST + "/register";
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
            keyValues.Add("userName", userName);
            keyValues.Add("pwd", password);
            string result = apiClient.Execute(url, JsonHelper.ToJsonStr(keyValues));
            var apiResult = JsonHelper.ToBean<ApiResult<string>>(result);
            return apiResult;
        }

        /// <summary>
        /// 获取TCP服务器信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="isForcedLanding">是否强制登录 默认值：false</param>
        /// <param name="deviceType">客户端类型 默认值：PC</param>
        /// <returns></returns>
        public ApiResult<ServerInfo> GetServerInfo(string userName, string password,bool isForcedLanding = false,string deviceType = "PC") 
        {
            string url = BaseConstant.IM_SERVICE_HOST + "/login";
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
            keyValues.Add("userName", userName);
            keyValues.Add("pwd", password);
            keyValues.Add("isForcedLanding", isForcedLanding);
            keyValues.Add("deviceType", deviceType);
            string result = apiClient.Execute(url, JsonHelper.ToJsonStr(keyValues));
            var apiResult = JsonHelper.ToBean<ApiResult<ServerInfo>>(result);
            return apiResult;
        }
    }
}
