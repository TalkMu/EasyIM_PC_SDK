using DotNetty.Buffers;
using EasyIM_PC_SDK;
using EasyIM_PC_SDK.Api;
using EasyIM_PC_SDK.Constant;
using EasyIM_PC_SDK.Helper;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service.Impl;
using System;
using System.Text;

namespace EasyIM_PC_SDK_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IMConfiguration.InitAccessKeyId("51599b3420acb5f2e7d7c2ce9b2b8e90");
            IMConfiguration.SetMsgHandleListener(new MessageCallBackListener());
            var client = IMConfiguration.InitClient("zhangsan", "zhangsan");
            client.RunClientAsync().Wait();
            client.Login("zhangsan");
            while (true)
            {
                Console.WriteLine("input you data:");

                var content = Console.ReadLine();
                IMMessage message = new IMMessage();
                message.Message = content;
                message.UrlMapping = SocketUrlConstant.LOGIN;
                client.SendMsg(message);
                if (content.Equals("q"))
                {
                    break;
                }
            }
        }
    }
}
