namespace ProfMathCsharp
{
    partial class MainForm
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.statusStrip = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.PictureBox2 = new System.Windows.Forms.PictureBox();
        	this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        	this.cmdAdd = new System.Windows.Forms.Button();
        	this.cmdSubt = new System.Windows.Forms.Button();
        	this.cmdMult = new System.Windows.Forms.Button();
        	this.cmdDiv = new System.Windows.Forms.Button();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.timer2 = new System.Windows.Forms.Timer(this.components);
        	this.statusStrip.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
        	this.flowLayoutPanel1.SuspendLayout();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// statusStrip
        	// 
        	this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.toolStripStatusLabel,
        	        	        	this.toolStripStatusLabel1,
        	        	        	this.toolStripStatusLabel2,
        	        	        	this.toolStripStatusLabel3});
        	this.statusStrip.Location = new System.Drawing.Point(0, 414);
        	this.statusStrip.Name = "statusStrip";
        	this.statusStrip.Size = new System.Drawing.Size(781, 37);
        	this.statusStrip.TabIndex = 16;
        	this.statusStrip.Text = "StatusStrip";
        	// 
        	// toolStripStatusLabel
        	// 
        	this.toolStripStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel.Image")));
        	this.toolStripStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        	this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        	this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 32);
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Silver;
        	this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 32);
        	this.toolStripStatusLabel1.Text = "Time:";
        	// 
        	// toolStripStatusLabel2
        	// 
        	this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Gray;
        	this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
        	this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        	this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 32);
        	this.toolStripStatusLabel2.Text = "time";
        	// 
        	// toolStripStatusLabel3
        	// 
        	this.toolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        	this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
        	this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
        	this.toolStripStatusLabel3.Size = new System.Drawing.Size(138, 32);
        	this.toolStripStatusLabel3.Text = "KiaKen Software Systems";
        	// 
        	// PictureBox2
        	// 
        	this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
        	this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
        	this.PictureBox2.Location = new System.Drawing.Point(703, 337);
        	this.PictureBox2.Name = "PictureBox2";
        	this.PictureBox2.Size = new System.Drawing.Size(66, 69);
        	this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        	this.PictureBox2.TabIndex = 17;
        	this.PictureBox2.TabStop = false;
        	// 
        	// flowLayoutPanel1
        	// 
        	this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
        	this.flowLayoutPanel1.Controls.Add(this.cmdAdd);
        	this.flowLayoutPanel1.Controls.Add(this.cmdSubt);
        	this.flowLayoutPanel1.Controls.Add(this.cmdMult);
        	this.flowLayoutPanel1.Controls.Add(this.cmdDiv);
        	this.flowLayoutPanel1.Location = new System.Drawing.Point(143, 26);
        	this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        	this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 31);
        	this.flowLayoutPanel1.TabIndex = 19;
        	// 
        	// cmdAdd
        	// 
        	this.cmdAdd.Location = new System.Drawing.Point(3, 3);
        	this.cmdAdd.Name = "cmdAdd";
        	this.cmdAdd.Size = new System.Drawing.Size(83, 23);
        	this.cmdAdd.TabIndex = 0;
        	this.cmdAdd.Text = "Add";
        	this.cmdAdd.UseVisualStyleBackColor = true;
        	this.cmdAdd.Click += new System.EventHandler(this.CmdAddClick);
        	// 
        	// cmdSubt
        	// 
        	this.cmdSubt.Location = new System.Drawing.Point(92, 3);
        	this.cmdSubt.Name = "cmdSubt";
        	this.cmdSubt.Size = new System.Drawing.Size(83, 23);
        	this.cmdSubt.TabIndex = 1;
        	this.cmdSubt.Text = "Subtract";
        	this.cmdSubt.UseVisualStyleBackColor = true;
        	this.cmdSubt.Click += new System.EventHandler(this.CmdSubtClick);
        	// 
        	// cmdMult
        	// 
        	this.cmdMult.Location = new System.Drawing.Point(181, 3);
        	this.cmdMult.Name = "cmdMult";
        	this.cmdMult.Size = new System.Drawing.Size(83, 23);
        	this.cmdMult.TabIndex = 2;
        	this.cmdMult.Text = "Multiply";
        	this.cmdMult.UseVisualStyleBackColor = true;
        	this.cmdMult.Click += new System.EventHandler(this.CmdMultClick);
        	// 
        	// cmdDiv
        	// 
        	this.cmdDiv.Location = new System.Drawing.Point(270, 3);
        	this.cmdDiv.Name = "cmdDiv";
        	this.cmdDiv.Size = new System.Drawing.Size(83, 23);
        	this.cmdDiv.TabIndex = 3;
        	this.cmdDiv.Text = "Divide";
        	this.cmdDiv.UseVisualStyleBackColor = true;
        	this.cmdDiv.Click += new System.EventHandler(this.CmdDivClick);
        	// 
        	// panel1
        	// 
        	this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.panel1.BackColor = System.Drawing.Color.Transparent;
        	this.panel1.Location = new System.Drawing.Point(26, 57);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(632, 369);
        	this.panel1.TabIndex = 18;
        	// 
        	// exitToolStripMenuItem1
        	// 
        	this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
        	this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.exitToolStripMenuItem1.Text = "&Exit";
        	this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1Click);
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.toolStripMenuItem1,
        	        	        	this.themeToolStripMenuItem,
        	        	        	this.exitToolStripMenuItem1});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(781, 24);
        	this.menuStrip1.TabIndex = 17;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// toolStripMenuItem1
        	// 
        	this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.helpToolStripMenuItem,
        	        	        	this.aboutToolStripMenuItem});
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
        	this.toolStripMenuItem1.Text = "&File";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        	this.helpToolStripMenuItem.Text = "Help";
        	this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItemClick);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        	this.aboutToolStripMenuItem.Text = "About";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
        	// 
        	// themeToolStripMenuItem
        	// 
        	this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
        	this.themeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
        	this.themeToolStripMenuItem.Text = "&Theme";
        	this.themeToolStripMenuItem.Click += new System.EventHandler(this.ThemeToolStripMenuItemClick);
        	// 
        	// timer1
        	// 
        	this.timer1.Enabled = true;
        	this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
        	// 
        	// timer2
        	// 
        	this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        	this.ClientSize = new System.Drawing.Size(781, 451);
        	this.Controls.Add(this.PictureBox2);
        	this.Controls.Add(this.statusStrip);
        	this.Controls.Add(this.flowLayoutPanel1);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.menuStrip1);
        	this.Icon = global::ProfMathCsharp.Properties.Resources.FONT02;
        	this.Name = "MainForm";
        	this.Text = "ProfMath";
        	this.Load += new System.EventHandler(this.MainForm_Load);
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
        	this.statusStrip.ResumeLayout(false);
        	this.statusStrip.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
        	this.flowLayoutPanel1.ResumeLayout(false);
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdMult;
        private System.Windows.Forms.Button cmdSubt;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;

        #endregion

    }
}

