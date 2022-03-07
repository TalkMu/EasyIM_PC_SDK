using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service;
using System;
using System.Collections.Generic;
using System.Text;


namespace EasyIM_PC_SDK_Demo
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  MessageCallBackListener 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/7 13:33:21 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/7 13:33:21 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class MessageCallBackListener : IMMsgHandleListener
    {
        public void Handle(IMMessage msg)
        {
            LogHelper.DebugFormat("实现回调：{0}",JsonHelper.ToJsonStr(msg));
        }
    }
}
