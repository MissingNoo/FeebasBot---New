namespace FeebasBot
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bConfig = new System.Windows.Forms.Button();
            this.bCave = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Timer(this.components);
            this.Open = new System.Windows.Forms.Timer(this.components);
            this.Troca = new System.Windows.Forms.Timer(this.components);
            this.stop = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.bMinimize);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // bMinimize
            // 
            this.bMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Location = new System.Drawing.Point(141, 0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(24, 39);
            this.bMinimize.TabIndex = 2;
            this.bMinimize.Text = "-";
            this.bMinimize.UseVisualStyleBackColor = true;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bClose
            // 
            this.bClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Location = new System.Drawing.Point(165, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(24, 39);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "X";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FeebasBotNew";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // bStart
            // 
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Location = new System.Drawing.Point(0, 39);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(189, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Iniciar";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Location = new System.Drawing.Point(0, 61);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(189, 23);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "Parar";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // nIcon
            // 
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "FeebasBot";
            this.nIcon.Visible = true;
            this.nIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nIcon_MouseDoubleClick);
            // 
            // bConfig
            // 
            this.bConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfig.Location = new System.Drawing.Point(0, 105);
            this.bConfig.Name = "bConfig";
            this.bConfig.Size = new System.Drawing.Size(189, 23);
            this.bConfig.TabIndex = 4;
            this.bConfig.Text = "Configurações";
            this.bConfig.UseVisualStyleBackColor = true;
            this.bConfig.Click += new System.EventHandler(this.bConfig_Click);
            // 
            // bCave
            // 
            this.bCave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCave.Location = new System.Drawing.Point(0, 83);
            this.bCave.Name = "bCave";
            this.bCave.Size = new System.Drawing.Size(189, 23);
            this.bCave.TabIndex = 3;
            this.bCave.Text = "Cavebot";
            this.bCave.UseVisualStyleBackColor = true;
            this.bCave.Click += new System.EventHandler(this.bCave_Click);
            // 
            // Run
            // 
            this.Run.Interval = 200;
            this.Run.Tick += new System.EventHandler(this.Run_Tick);
            // 
            // Open
            // 
            this.Open.Enabled = true;
            this.Open.Interval = 1000;
            this.Open.Tick += new System.EventHandler(this.Open_Tick);
            // 
            // Troca
            // 
            this.Troca.Interval = 250;
            this.Troca.Tick += new System.EventHandler(this.Troca_Tick);
            // 
            // stop
            // 
            this.stop.Enabled = true;
            this.stop.Tick += new System.EventHandler(this.stop_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 128);
            this.Controls.Add(this.bCave);
            this.Controls.Add(this.bConfig);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chrome";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.Button bConfig;
        private System.Windows.Forms.Button bCave;
        private System.Windows.Forms.Timer Run;
        private System.Windows.Forms.Timer Open;
        private System.Windows.Forms.Timer Troca;
        private System.Windows.Forms.Timer stop;
    }
}

