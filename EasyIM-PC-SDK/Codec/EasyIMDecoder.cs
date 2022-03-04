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
     * 文件名：  EasyIMDecoder 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 16:43:21 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 16:43:21 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class EasyIMDecoder : ByteToMessageDecoder
    {
        protected override void Decode(IChannelHandlerContext context, IByteBuffer input, List<object> output)
        {
            byte[] array = new byte[input.ReadableBytes];
            input.GetBytes(input.ReaderIndex, array, 0, input.ReadableBytes);
            input.Clear();
            output.Add(Encoding.UTF8.GetString(array));
        }
    }
}
