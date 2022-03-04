using DotNetty.Buffers;
using DotNetty.Codecs;
using DotNetty.Transport.Channels;
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
     * 文件名：  StringEncoder 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 17:29:28 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 17:29:28 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class StringEncoder : MessageToByteEncoder<string>
    {
        protected override void Encode(IChannelHandlerContext context, string message, IByteBuffer output)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            IByteBuffer initialMessage = Unpooled.Buffer(messageBytes.Length);
            initialMessage.WriteBytes(messageBytes);
            output.WriteBytes(initialMessage);
        }
    }
}
