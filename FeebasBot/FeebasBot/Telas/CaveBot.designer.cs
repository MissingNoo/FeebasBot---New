namespace FeebasBot.Forms
{
    partial class CaveBot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaveBot));
            this.view = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTP = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnGotoLabel = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.btnLabel = new System.Windows.Forms.Button();
            this.btnElse = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.waittime = new System.Windows.Forms.TextBox();
            this.btnWait = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMvDown = new System.Windows.Forms.Button();
            this.btnMvUp = new System.Windows.Forms.Button();
            this.cPauseTarget = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.AllowUserToAddRows = false;
            this.view.AllowUserToDeleteRows = false;
            this.view.AllowUserToOrderColumns = true;
            this.view.AllowUserToResizeColumns = false;
            this.view.AllowUserToResizeRows = false;
            this.view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view.Location = new System.Drawing.Point(12, 12);
            this.view.MultiSelect = false;
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(353, 316);
            this.view.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(88, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "❌";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(44, 275);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(32, 32);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(6, 311);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(32, 32);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(44, 311);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(32, 32);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(82, 311);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(32, 32);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnTP);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnGotoLabel);
            this.panel1.Controls.Add(this.txtLabel);
            this.panel1.Controls.Add(this.btnLabel);
            this.panel1.Controls.Add(this.btnElse);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.waittime);
            this.panel1.Controls.Add(this.btnWait);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(371, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 346);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Pokemon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(82, 89);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTP
            // 
            this.btnTP.Location = new System.Drawing.Point(82, 118);
            this.btnTP.Name = "btnTP";
            this.btnTP.Size = new System.Drawing.Size(75, 23);
            this.btnTP.TabIndex = 21;
            this.btnTP.Text = "Teleport";
            this.btnTP.UseVisualStyleBackColor = true;
            this.btnTP.Click += new System.EventHandler(this.btnTP_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(161, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Say";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGotoLabel
            // 
            this.btnGotoLabel.Location = new System.Drawing.Point(84, 60);
            this.btnGotoLabel.Name = "btnGotoLabel";
            this.btnGotoLabel.Size = new System.Drawing.Size(75, 23);
            this.btnGotoLabel.TabIndex = 17;
            this.btnGotoLabel.Text = "Gotolabel";
            this.btnGotoLabel.UseVisualStyleBackColor = true;
            this.btnGotoLabel.Click += new System.EventHandler(this.btnGotoLabel_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(3, 34);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(75, 20);
            this.txtLabel.TabIndex = 16;
            // 
            // btnLabel
            // 
            this.btnLabel.Location = new System.Drawing.Point(84, 32);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(75, 23);
            this.btnLabel.TabIndex = 15;
            this.btnLabel.Text = "Label";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // btnElse
            // 
            this.btnElse.Location = new System.Drawing.Point(165, 60);
            this.btnElse.Name = "btnElse";
            this.btnElse.Size = new System.Drawing.Size(75, 23);
            this.btnElse.TabIndex = 14;
            this.btnElse.Text = "Else";
            this.btnElse.UseVisualStyleBackColor = true;
            this.btnElse.Click += new System.EventHandler(this.btnElse_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(165, 89);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(165, 31);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 12;
            this.btnColor.Text = "If Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.btnColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "RightClick";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "LeftClick";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // waittime
            // 
            this.waittime.Location = new System.Drawing.Point(3, 5);
            this.waittime.Name = "waittime";
            this.waittime.Size = new System.Drawing.Size(75, 20);
            this.waittime.TabIndex = 9;
            this.waittime.Text = "1";
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(84, 3);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(75, 23);
            this.btnWait.TabIndex = 8;
            this.btnWait.Text = "Wait";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(44, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 132);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnMvDown
            // 
            this.btnMvDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMvDown.BackgroundImage")));
            this.btnMvDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMvDown.Location = new System.Drawing.Point(50, 334);
            this.btnMvDown.Name = "btnMvDown";
            this.btnMvDown.Size = new System.Drawing.Size(32, 32);
            this.btnMvDown.TabIndex = 21;
            this.btnMvDown.UseVisualStyleBackColor = true;
            this.btnMvDown.Click += new System.EventHandler(this.btnMvDown_Click);
            // 
            // btnMvUp
            // 
            this.btnMvUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMvUp.BackgroundImage")));
            this.btnMvUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMvUp.Location = new System.Drawing.Point(12, 334);
            this.btnMvUp.Name = "btnMvUp";
            this.btnMvUp.Size = new System.Drawing.Size(32, 32);
            this.btnMvUp.TabIndex = 20;
            this.btnMvUp.UseVisualStyleBackColor = true;
            this.btnMvUp.Click += new System.EventHandler(this.btnMvUp_Click);
            // 
            // cPauseTarget
            // 
            this.cPauseTarget.AutoSize = true;
            this.cPauseTarget.Location = new System.Drawing.Point(126, 342);
            this.cPauseTarget.Name = "cPauseTarget";
            this.cPauseTarget.Size = new System.Drawing.Size(161, 17);
            this.cPauseTarget.TabIndex = 22;
            this.cPauseTarget.Text = "Pausar se estiver targetando";
            this.cPauseTarget.UseVisualStyleBackColor = true;
            this.cPauseTarget.CheckedChanged += new System.EventHandler(this.cPauseTarget_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wButton
            // 
            this.wButton.Location = new System.Drawing.Point(3, 89);
            this.wButton.Name = "wButton";
            this.wButton.Size = new System.Drawing.Size(75, 23);
            this.wButton.TabIndex = 24;
            this.wButton.Text = "Waypoint";
            this.wButton.UseVisualStyleBackColor = true;
            this.wButton.Click += new System.EventHandler(this.wButton_Click);
            // 
            // CaveBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cPauseTarget);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMvDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.btnMvUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CaveBot";
            this.Text = "CaveChrome";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaveBot_FormClosing);
            this.Load += new System.EventHandler(this.CaveBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox waittime;
        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.Button btnElse;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Button btnGotoLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnMvDown;
        private System.Windows.Forms.Button btnMvUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cPauseTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button wButton;
    }
}