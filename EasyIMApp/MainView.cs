using EasyIMApp.Helper;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sunny.UI.UIImageListBox;

namespace EasyIMApp
{
    public partial class MainView : UIForm
    {
        public MainView()
        {
            InitializeComponent();
            this.InitFriends();
        }

        public void InitFriends() 
        {
            for (int i = 0; i < 20; i++)
            {
                string url = "https://gimg2.baidu.com/image_search/src=http%3A%2F%2Fup.enterdesk.com%2Fedpic_source%2F30%2F90%2F40%2F309040a0602c672cebc6ab3a1bbbc8cd.jpg&refer=http%3A%2F%2Fup.enterdesk.com&app=2002&size=f9999,10000&q=a80&n=0&g=0n&fmt=auto?sec=1651200673&t=ab33500246faf9d3d1c5733f23c93f6e";
                this.uiImageListFriends.AddImage(BitmapHelper.UrlToBitmap(url), "好友" + i);
            }
        }

        public void InitGroups() 
        {
            
        }
    }
}
