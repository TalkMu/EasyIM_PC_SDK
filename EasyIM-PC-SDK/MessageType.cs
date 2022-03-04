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
     * 文件名：  MessageType 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 10:26:39 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 10:26:39 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public enum MessageType
    {
        /// <summary>
        /// 用户消息
        /// </summary>
        USERMESSAGE,
        /// <summary>
        /// 掉线
        /// </summary>
        PONG,
        /// <summary>
        /// 心跳
        /// </summary>
        PING,
        /// <summary>
        /// 系统消息
        /// </summary>
        SYSTEM
    }
}
