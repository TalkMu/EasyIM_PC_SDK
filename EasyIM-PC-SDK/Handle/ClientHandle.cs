using DotNetty.Buffers;
using DotNetty.Transport.Channels;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace EasyIM_PC_SDK.Handler
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  ClientHandle 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 10:08:09 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 10:08:09 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class ClientHandle : SimpleChannelInboundHandler<string>
    {
        public override void ChannelActive(IChannelHandlerContext context)
        {
            // 客户端与服务端建立连接时调用
            base.ChannelActive(context);
            LogHelper.DebugFormat("IM 服务连接成功");
        }

        public override void ChannelInactive(IChannelHandlerContext context)
        {

            base.ChannelInactive(context);
            LogHelper.DebugFormat("客户端断开了连接");

            // 重新连接
            var channel = context.Channel;
            channel.CloseAsync();

            IMConfiguration.ReConnectIMClient();
        }

        protected override void ChannelRead0(IChannelHandlerContext ctx, string msg)
        {
            LogHelper.DebugFormat("ChannelRead0-读取来自服务器的消息：{0}", msg);
            //if (msg.MessageType == MessageType.PONG)
            //{
            //    LogHelper.DebugFormat("ChannelRead0-掉线，正在重新连接。。。。");
            //    // 掉线
            //    IMConfiguration.ReConnectIMClient();
            //}
            //else if (msg.MessageType == MessageType.PING)
            //{
            //    LogHelper.DebugFormat("心跳包");
            //    // 心跳
            //}
            //回调消息
            //CallBackMsg(msg);
            //ctx.WriteAndFlushAsync(Unpooled.CopiedBuffer(msg));
        }

        private void CallBackMsg(IMMessage msg) 
        {
            var msgHandleListener = IMConfiguration.GetMsgHandleListener();
            if (msgHandleListener != null)
            {
                msgHandleListener.Handle(msg);
            }
        }


    }
}
