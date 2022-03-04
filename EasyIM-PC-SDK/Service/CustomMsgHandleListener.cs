using EasyIM_PC_SDK.Model;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * ========================================================================
 * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
 * ========================================================================
 * 机器名称：DESKTOP-GNAF83O 
 * 文件名：  CustomMsgHandleListener 
 * 版本号：  V1.0.0.0 
 * 创建人：  admin 
 * 创建时间：2022/3/4 11:10:14 
 * 描述    :
 * =====================================================================
 * 修改时间：2022/3/4 11:10:14 
 * 修改人  ：admin
 * 版本号  ：V1.0.0.0 
 * 描述    ：
*/
namespace EasyIM_PC_SDK.Service
{

    public interface CustomMsgHandleListener
    {
        /// <summary>
        /// 消息回调处理
        /// </summary>
        /// <param name="msg"></param>
        void Handle(IMMessage msg);
    }
}
