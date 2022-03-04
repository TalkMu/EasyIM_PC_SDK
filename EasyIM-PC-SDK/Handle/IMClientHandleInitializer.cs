using DotNetty.Handlers.Timeout;
using DotNetty.Transport.Channels;
using EasyIM_PC_SDK.Codec;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace EasyIM_PC_SDK.Handler
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  IMClientHandleInitializer 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 11:35:48 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 11:35:48 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class IMClientHandleInitializer : ChannelInitializer<IChannel>
    {
        private ClientHandle clientHandle = new ClientHandle();
        protected override void InitChannel(IChannel channel)
        {
            channel.Pipeline
                //  9 秒没发送消息 将IdleStateHandler 添加到 ChannelPipeline 中
                .AddLast(new IdleStateHandler(16, 9, 0))
                .AddLast(new EasyIMEncoder())
                .AddLast(new EasyIMDecoder())
                .AddLast(clientHandle);
        }
    }
}
