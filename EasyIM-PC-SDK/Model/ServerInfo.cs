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
     * 文件名：  ServerInfo 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/3 16:56:00 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 16:56:00 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class ServerInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// WebSocket端口
        /// </summary>
        public int ServerWebSocketPort { get; set; }
        /// <summary>
        /// 服务TCP端口
        /// </summary>
        public int ServerTcpPort { get; set; }
        /// <summary>
        /// 服务IP
        /// </summary>
        public string ServerIp { get; set; }
        /// <summary>
        /// HTTP端口
        /// </summary>
        public int ServerHttpPort { get; set; }
        public string RocketMQTopic { get; set; }
        /// <summary>
        /// 是否强制登录
        /// </summary>
        public bool IsForcedLanding { get; set; }
        public string DeviceType { get; set; }
        public string DeviceToken { get; set; }
    }
}
