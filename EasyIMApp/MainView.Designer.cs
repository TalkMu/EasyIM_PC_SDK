namespace EasyIMApp
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.uiImageListFriends = new Sunny.UI.UIImageListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.uiImageListGroups = new Sunny.UI.UIImageListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.uiImageListBox1 = new Sunny.UI.UIImageListBox();
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uiTabControl1.SuspendLayout();
            this.tabFriends.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.Controls.Add(this.tabPage2);
            this.uiTabControlMenu1.Controls.Add(this.tabPage3);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 80);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(0, 35);
            this.uiTabControlMenu1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.Padding = new System.Drawing.Point(0, 0);
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(300, 615);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(81, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(219, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "消息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiTabControl1);
            this.tabPage2.Location = new System.Drawing.Point(81, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(219, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "联系人";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabFriends);
            this.uiTabControl1.Controls.Add(this.tabPage5);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(222, 615);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabBackColor = System.Drawing.Color.White;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TabSelectedColor = System.Drawing.Color.White;
            this.uiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.Gray;
            // 
            // tabFriends
            // 
            this.tabFriends.Controls.Add(this.uiImageListFriends);
            this.tabFriends.Location = new System.Drawing.Point(0, 40);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Size = new System.Drawing.Size(222, 575);
            this.tabFriends.TabIndex = 0;
            this.tabFriends.Text = "好友";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // uiImageListFriends
            // 
            this.uiImageListFriends.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiImageListFriends.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiImageListFriends.Location = new System.Drawing.Point(4, 5);
            this.uiImageListFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiImageListFriends.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiImageListFriends.Name = "uiImageListFriends";
            this.uiImageListFriends.Padding = new System.Windows.Forms.Padding(2);
            this.uiImageListFriends.Size = new System.Drawing.Size(211, 565);
            this.uiImageListFriends.TabIndex = 0;
            this.uiImageListFriends.Text = "uiImageListBox2";
            this.uiImageListFriends.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.uiImageListGroups);
            this.tabPage5.Location = new System.Drawing.Point(0, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(222, 575);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "群聊";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // uiImageListGroups
            // 
            this.uiImageListGroups.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiImageListGroups.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiImageListGroups.Location = new System.Drawing.Point(4, 5);
            this.uiImageListGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiImageListGroups.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiImageListGroups.Name = "uiImageListGroups";
            this.uiImageListGroups.Padding = new System.Windows.Forms.Padding(2);
            this.uiImageListGroups.Size = new System.Drawing.Size(211, 565);
            this.uiImageListGroups.TabIndex = 0;
            this.uiImageListGroups.Text = "uiImageListBox2";
            this.uiImageListGroups.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(81, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(219, 615);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "其它";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // uiImageListBox1
            // 
            this.uiImageListBox1.FillColor = System.Drawing.Color.White;
            this.uiImageListBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiImageListBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiImageListBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiImageListBox1.Location = new System.Drawing.Point(465, 216);
            this.uiImageListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiImageListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiImageListBox1.Name = "uiImageListBox1";
            this.uiImageListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiImageListBox1.Size = new System.Drawing.Size(8, 8);
            this.uiImageListBox1.TabIndex = 2;
            this.uiImageListBox1.Text = "uiImageListBox1";
            this.uiImageListBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.uiImageListBox1);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.uiTabControl1.ResumeLayout(false);
            this.tabFriends.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabFriends;
        private TabPage tabPage5;
        private TabPage tabPage3;
        private Sunny.UI.UIImageListBox uiImageListBox1;
        private Sunny.UI.UIImageListBox uiImageListGroups;
        private Sunny.UI.UIImageListBox uiImageListFriends;
    }
}