using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace EasyIM_PC_SDK.Service.Impl
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 sdfykjyxgs.cn All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-GNAF83O 
     * 文件名：  MsgCallBackListener 
     * 版本号：  V1.0.0.0 
     * 创建人：  admin 
     * 创建时间：2022/3/4 11:28:11 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/4 11:28:11 
     * 修改人  ：admin
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class MsgCallBackListener : CustomMsgHandleListener
    {
        public void Handle(IMMessage msg)
        {
            LogHelper.DebugFormat("自定义消息回调处理:{0}", JsonHelper.ToJsonStr(msg));
        }
    }
}
