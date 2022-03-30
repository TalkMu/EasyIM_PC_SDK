using EasyIM_PC_SDK;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyIMApp
{
    internal class MessageCallBackListener : IMMsgHandleListener
    {
        public void Handle(IMMessage msg)
        {
            var client = IMConfiguration.GetEasyIMClient();
            if (msg.Message.Equals("登录成功"))
            {
                try
                {
                    
                    client.LoginSuccess = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (client != null && client.CallBack != null)
            {
                client.CallBack(msg);
            }
            LogHelper.DebugFormat("实现回调：{0}", JsonHelper.ToJsonStr(msg));
        }
    }
}
