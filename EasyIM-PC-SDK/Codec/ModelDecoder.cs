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
     * 文件名：  ModelDecoder 
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
    public class ModelDecoder : LengthFieldBasedFrameDecoder
    {
        /// <summary>
        /// 数据包基本长度（1字节（标记）+4字节（数据长度））
        /// </summary>
        private static int BASE_SIZE = 5;

        public ModelDecoder(int maxFrameLength, int lengthFieldOffset, int lengthFieldLength, int lengthAdjustment, int initialBytesToStrip, bool failFast) : base(maxFrameLength, lengthFieldOffset, lengthFieldLength, lengthAdjustment, initialBytesToStrip, failFast)
        {

        }

        protected override object Decode(IChannelHandlerContext context, IByteBuffer input)
        {
            // 可读区域长度
            var length = input.ReadableBytes;
            if (length < BASE_SIZE)
            {
                return null;
            }
            input.MarkReaderIndex();
            var mark = input.ReadByte();
            try
            {
                if (mark == 0x02)
                {
                    byte[] msgLengthByte = new byte[4];
                    // 获取长度
                    input.ReadBytes(msgLengthByte);
                    var msgLength = System.BitConverter.ToInt32(msgLengthByte, 0);
                    if (msgLength > length)
                    {
                        input.ResetReaderIndex();
                        return null;
                    }
                    var msgContentBuf = input.ReadBytes(msgLength);
                    input.Clear();
                    var msgContent = msgContentBuf.GetString(0, msgLength, Encoding.UTF8);
                    IMMessage imMessage = JsonHelper.ToBean<IMMessage>(msgContent);
                    return imMessage;
                }
            }
            catch (Exception e)
            {
                LogHelper.ErrorFormat("解码失败:{0}", e.Message);
            }
            return null;
        }
    }
}
