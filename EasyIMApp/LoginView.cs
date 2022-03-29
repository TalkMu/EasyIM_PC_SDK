using EasyIM_PC_SDK;
using EasyIM_PC_SDK.Model;
using EasyIM_PC_SDK.Service;
using EasyIM_PC_SDK.Service.Impl;
using EasyIMApp.VO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyIMApp
{

    public partial class LoginView : UIForm
    {
        private EasyIMClient easyIMClient;
        public LoginView()
        {
            InitializeComponent();
            
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginBtn.Text = "登录中...";
            LoginBtn.Enabled = false;
            LoginVO loginVO = new LoginVO();
            loginVO.UserName = UserName.Text;
            loginVO.Password = Password.Text;
            var client = IMConfiguration.InitClient(loginVO.UserName, loginVO.Password);
            
            while (!client.InitSuccess)
            {
                Thread.Sleep(2000);
            }
            // 初始化成功
            
            // 自动登录
            client.Login(loginVO.UserName);
            client.CallBack = msg =>
            {
                if (msg != null)
                {
                    this.Hide();
                    MainView mainView = new MainView();
                    mainView.Show();
                }
            };


            //Task.Run(() => 
            //{
            //    // 初始化客户端
            //    easyIMClient = IMConfiguration.InitIMAccount(loginVO.UserName, loginVO.Password);
            //    // 登录
            //    easyIMClient.Login(loginVO.UserName);
            //});
        }

        private void LoginSuccessAfter() 
        {
            this.Hide();
            MainView mainView = new MainView();
            mainView.Show();

        }
    }
}
