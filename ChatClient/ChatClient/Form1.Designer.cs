﻿namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Server_IP = new System.Windows.Forms.TextBox();
            this.txt_Chat = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_Connect
            // 
            this.cmd_Connect.Location = new System.Drawing.Point(438, 23);
            this.cmd_Connect.Name = "cmd_Connect";
            this.cmd_Connect.Size = new System.Drawing.Size(85, 34);
            this.cmd_Connect.TabIndex = 6;
            this.cmd_Connect.Text = "Login";
            this.cmd_Connect.UseVisualStyleBackColor = true;
            this.cmd_Connect.Click += new System.EventHandler(this.cmd_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "대화명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "서버 IP";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(109, 31);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(91, 21);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Server_IP
            // 
            this.txt_Server_IP.Location = new System.Drawing.Point(293, 30);
            this.txt_Server_IP.Name = "txt_Server_IP";
            this.txt_Server_IP.Size = new System.Drawing.Size(125, 21);
            this.txt_Server_IP.TabIndex = 3;
            // 
            // txt_Chat
            // 
            this.txt_Chat.Location = new System.Drawing.Point(30, 84);
            this.txt_Chat.Multiline = true;
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Chat.Size = new System.Drawing.Size(524, 271);
            this.txt_Chat.TabIndex = 4;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(29, 382);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(524, 21);
            this.txt_Msg.TabIndex = 5;
            this.txt_Msg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Msg_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.txt_Server_IP);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Server_IP;
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Label label3;
    }
}

