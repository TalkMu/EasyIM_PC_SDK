using System;
using System.Collections.Generic;
using System.Text;


namespace EasyIM_PC_SDK.Model
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  IMMessage 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 11:17:43 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 11:17:43 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class IMMessage : SocketMessage
    {
        /// <summary>
        /// 发送人
        /// </summary>
        public string Sender { get; set; }
        /// <summary>
        /// 接收人
        /// </summary>
        public string Receiver { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        public string DeviceType { get; set; }
        /// <summary>
        /// 消息体
        /// </summary>
        public object MessageBody { get; set; }
        /// <summary>
        /// 扩展消息
        /// </summary>
        public Dictionary<string,object> Ext { get; set; }
        /// <summary>
        /// 文本消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType MessageType { get; set; }
        /// <summary>
        /// 消息时间
        /// </summary>
        public long MessageTime { get; set; }
        /// <summary>
        /// 消息ID
        /// </summary>
        public string MessageId { get; set; }
    }
}
