using EasyIM_PC_SDK;
using EasyIM_PC_SDK.Api;
using EasyIM_PC_SDK.Helper;
using System;

namespace EasyIM_PC_SDK_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IMConfiguration.InitApiClient("51599b3420acb5f2e7d7c2ce9b2b8e90");
            UserApi userApi = new UserApi();
            var result =  userApi.Login("zhangsan", "zhangsan");
            LogHelper.InfoFormat("登录:{0}", JsonHelper.ToJsonStr(result));
            Console.ReadLine();
        }
    }
}
