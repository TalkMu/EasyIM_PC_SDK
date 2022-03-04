using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace EasyIM_PC_SDK.Codec
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  ModelEncoder 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 16:43:03 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 16:43:03 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class ModelEncoder : MessageToByteEncoder<IMMessage>
    {
        protected override void Encode(IChannelHandlerContext context, IMMessage message, IByteBuffer output)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(JsonHelper.ToJsonStr(message));
            IByteBuffer initialMessage = Unpooled.Buffer(messageBytes.Length);
            initialMessage.WriteBytes(messageBytes);
            output.WriteBytes(initialMessage);
        }
    }
}
