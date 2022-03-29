using EasyIM_PC_SDK.Api;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// 消息回调监听器
        /// </summary>
        private static IMMsgHandleListener msgHandleListener;

        public static void InitAccessKeyId(string accessKeyId) 
        {
            AccessKeyId = accessKeyId;
            
        }

        public static EasyIMClient InitClient(string userName, string password) 
        {
            var userApi = new UserApi();
            var result = userApi.GetServerInfo(userName, password);
            if (result!= null && result.Message != null && result.Message.Equals("该用户已经登陆"))
            {
                result = userApi.GetServerInfo(userName);
            }
            serverInfo = result.Data;
            //serverInfo = new ServerInfo();
            //serverInfo.ServerIp = "192.168.101.84";
            //serverInfo.ServerTcpPort = 11211;

            defaultEasyIMClient = new EasyIMClient(result.Data);
            Task.Run(() =>
            {
                defaultEasyIMClient.RunClientAsync().Wait();
            });
            return defaultEasyIMClient;
        }

        public static void ReConnectIMClient() 
        {
            defaultEasyIMClient = new EasyIMClient(serverInfo);
            defaultEasyIMClient.RunClientAsync().Wait();
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

        public static void SetMsgHandleListener(IMMsgHandleListener listener) 
        {
            msgHandleListener = listener;
        }

        public static IMMsgHandleListener GetMsgHandleListener() 
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
