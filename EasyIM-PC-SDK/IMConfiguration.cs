using EasyIM_PC_SDK.Api;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service;
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

        private static EasyIMClient defaultEasyIMClient;

        private static ServerInfo serverInfo;

        private static string AccessKeyId;
        private static string Token;
        private static string UserName;
        private static string Password;

        /// <summary>
        /// 消息回调监听器
        /// </summary>
        private static CustomMsgHandleListener msgHandleListener;

        public static void InitAccessKeyId(string accessKeyId) 
        {
            AccessKeyId = accessKeyId;
            
        }

        public static EasyIMClient InitIMAccount(string userName, string password) 
        {
            UserName = userName;
            Password = password;
            var result = new UserApi().GetServerInfo(userName, password);
            
            serverInfo = new ServerInfo();
            serverInfo.ServerIp = "192.168.101.84";
            serverInfo.ServerTcpPort = 11211;

            defaultEasyIMClient = new EasyIMClient(serverInfo);
            return defaultEasyIMClient;
        }

        public static void ReConnectIMClient() 
        {
            defaultEasyIMClient = new EasyIMClient(serverInfo);
            defaultEasyIMClient.Run();
        }

        public static EasyIMClient GetEasyIMClient() 
        {
            if (defaultEasyIMClient == null)
            {
                throw new Exception("未初始化的defaultEasyIMClient 请调用静态方法完成初始化:IMConfiguration.InitIMAccount(userName,password)");
            }
            return defaultEasyIMClient;
        }

        public static string GetToken() 
        {
            if (Token == null)
            {
                Token = new AuthenticationApi().GetToken(AccessKeyId);
            }
            return Token;
        }

        public static void SetMsgHandleListener(CustomMsgHandleListener listener) 
        {
            msgHandleListener = listener;
        }

        public static CustomMsgHandleListener GetMsgHandleListener() 
        {
            return msgHandleListener;
        }

        public static ApiClient GetDefaultApiClient() 
        {
            if (defaultApiClient == null)
            {
                defaultApiClient = new ApiClient();
            }
            return defaultApiClient;
        }
    }
}
