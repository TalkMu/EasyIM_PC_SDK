# EasyIM_PC_SDK (NET45/Standard/Core) SDK for .NET
项目描述


## 目录
- [目录说明](#目录说明)
- [安装](#安装)
- [初始化](#初始化)
- [待办列表](#待办列表)

### 目录说明
```
EasyIM-PC-SDK
├── EasyIM-PC-SDK
│  ├── /Api         #IM管理API
│  ├── /Auth
│  ├── /Codec       #编码/解码
│  ├── /Constant    
│  ├── /Handle      #配置拦截器、编码器、解码器等
│  ├── /Helper      #常用工具
│  ├── /Model
│  ├── /Result
│  ├── /Service     #消息回调接口
│  │  ├── /Impl     #消息回调默认实现
├── EasyIM-PC-SDK-Demo
```
### 安装

### 初始化
```
// 初始化应用ID
IMConfiguration.InitAccessKeyId("51599b3420acb5f2e7d7c2ce9b2b8e90");
// 配置消息回调监听
IMConfiguration.SetMsgHandleListener(new MessageCallBackListener());
// 初始化已有的账号密码
var client = IMConfiguration.InitIMAccount("zhangsan", "zhangsan");
// 启动客户端连接
client.Run().Wait();
// 构建消息体
IMMessage message = new IMMessage();
message.Message = "你好,管理员";  // 消息内容
message.Receiver = "admin"; // 接收人
message.UrlMapping = SocketUrlConstant.LOGIN; // 路由
// 发送消息
client.SendMsg(message);
```
### 待办列表
* [ ] 登录/注销
  * [ ] 登录
  * [ ] 注销
* [ ] 用户管理
  * [ ] 注册账号
  * [ ] 修改资料
  * [ ] 删除账号
  * [ ] 查询账号
* [ ] 好友管理
  * [ ] 添加好友
  * [ ] 删除好友
  * [ ] 查询好友列表
  * [ ] 拉黑好友
* [ ] 群聊管理
  * [ ] 创建群聊
  * [ ] 解散群聊
  * [ ] 添加群成员
  * [ ] 移除群成员