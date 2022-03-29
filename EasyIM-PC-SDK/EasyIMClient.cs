using DotNetty.Buffers;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using EasyIM_PC_SDK.Api;
using EasyIM_PC_SDK.Constant;
using EasyIM_PC_SDK.Handler;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service;
using EasyIM_PC_SDK.Service.Impl;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EasyIM_PC_SDK
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  EasyIMClient 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 14:20:12 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 14:20:12 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    /// <summary>
    /// 登录监听
    /// </summary>
    public class EasyIMClient
    {
        public Action<IMMessage> CallBack;

        private static IChannel channel;
        private static MultithreadEventLoopGroup eventLoopGroup = new MultithreadEventLoopGroup();
        private ServerInfo serverInfo;
        /// <summary>
        /// 是否初始化成功
        /// </summary>
        public bool InitSuccess { get; set; }

        public IMMsgHandleListener msgHandleListener { get; set; }


        /// <summary>
        /// 退出登录监听
        /// </summary>
        public Action<IMMessage> OnOutLogin { get; set; }
        

        public EasyIMClient(ServerInfo serverInfo){
            this.serverInfo = serverInfo;
        }

        public IChannel Login(string userName)
        {
            IMMessage message = new IMMessage();
            message.Message = "login";
            message.DeviceType = "PC";
            message.Sender = userName;
            message.UrlMapping = SocketUrlConstant.LOGIN;
            message.MessageType = MessageType.USERMESSAGE;
            message.Token = IMConfiguration.GetToken();
            channel.WriteAndFlushAsync(message);
            return channel;
        }

        public async Task RunClientAsync()
        {
            try
            {
                var bootstrap = new Bootstrap();
                bootstrap.Group(eventLoopGroup)
                    .Channel<TcpSocketChannel>()
                    .Handler(new IMClientHandleInitializer());
                channel = await bootstrap.ConnectAsync(new IPEndPoint(IPAddress.Parse(serverInfo.ServerIp), serverInfo.ServerTcpPort));
                //await clientChannel.CloseAsync();
                //channel.WriteAndFlushAsync("hahaha");
                if (channel != null)
                {
                    InitSuccess = true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.ErrorFormat(ex.StackTrace);
            }
            finally
            {
                //await multithreadEventLoopGroup.ShutdownGracefullyAsync();
            }
        }

        public void SendMsg(IMMessage msg)
        {
            channel.WriteAndFlushAsync(msg);
        }
    }
}
