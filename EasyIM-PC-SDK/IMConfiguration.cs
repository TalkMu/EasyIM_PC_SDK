using EasyIM_PC_SDK.Helper;
using System;
using System.Collections.Generic;
using System.Text;


namespace EasyIM_PC_SDK
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  IMConfiguration 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/3 15:48:22 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 15:48:22 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class IMConfiguration
    {
        private static ApiClient defaultApiClient;

        public static void InitApiClient(string accessKeyId) 
        {
            defaultApiClient = new ApiClient(accessKeyId);
        }

        public static ApiClient GetDefaultApiClient() 
        {
            if (defaultApiClient == null)
            {
                throw new Exception("未初始化的defaultApiClient 请调用静态方法完成初始化:IMConfiguration.InitApiClient(accessKeyId)");
            }
            return defaultApiClient;
        }

        public static void SetDefaultApiClient(ApiClient apiClient) 
        {
            defaultApiClient = apiClient;
        }
    }
}
