﻿using DotNetty.Transport.Channels;
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
     * 文件名：  SocketMessage 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 11:21:12 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 11:21:12 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class SocketMessage
    {
        public IChannel channel { get; set; }

        public string Token { get; set; }
    }
}
