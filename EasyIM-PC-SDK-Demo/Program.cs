using DotNetty.Buffers;
using EasyIM_PC_SDK;
using EasyIM_PC_SDK.Api;
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
            IMConfiguration.SetMsgHandleListener(new MsgCallBackListener());
            var client = IMConfiguration.InitIMAccount("zhangsan", "zhangsan");
            client.Run().Wait();
            while (true)
            {
                Console.WriteLine("input you data:");

                var content = Console.ReadLine();

                client.SendMsg(content);

                if (content.Equals("q"))
                {
                    break;
                }
            }
        }
    }
}
