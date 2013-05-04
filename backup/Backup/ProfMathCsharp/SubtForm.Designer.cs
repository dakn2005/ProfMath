/*
 * Created by SharpDevelop.
 * User: Njuguna
 * Date: 12/28/2010
 * Time: 11:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProfMathCsharp
{
	partial class SubtForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtForm));
			this.one100 = new System.Windows.Forms.RadioButton();
			this.lblcounter = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.picface = new System.Windows.Forms.PictureBox();
			this.cmdnext = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.txtans = new System.Windows.Forms.TextBox();
			this.Groupnum = new System.Windows.Forms.GroupBox();
			this.one10 = new System.Windows.Forms.RadioButton();
			this.one1000 = new System.Windows.Forms.RadioButton();
			this.one1 = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.two100 = new System.Windows.Forms.RadioButton();
			this.Groupden = new System.Windows.Forms.GroupBox();
			this.two10 = new System.Windows.Forms.RadioButton();
			this.two1000 = new System.Windows.Forms.RadioButton();
			this.two1 = new System.Windows.Forms.RadioButton();
			this.cmdreset = new System.Windows.Forms.Button();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picface)).BeginInit();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
			this.Groupnum.SuspendLayout();
			this.Groupden.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// one100
			// 
			this.one100.AutoSize = true;
			this.one100.Location = new System.Drawing.Point(14, 74);
			this.one100.Name = "one100";
			this.one100.Size = new System.Drawing.Size(43, 17);
			this.one100.TabIndex = 3;
			this.one100.TabStop = true;
			this.one100.Text = "100";
			this.one100.UseVisualStyleBackColor = true;
			this.one100.Click += new System.EventHandler(this.radionumerator);
			// 
			// lblcounter
			// 
			this.lblcounter.BackColor = System.Drawing.Color.Transparent;
			this.lblcounter.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcounter.ForeColor = System.Drawing.Color.White;
			this.lblcounter.Location = new System.Drawing.Point(376, 387);
			this.lblcounter.Name = "lblcounter";
			this.lblcounter.Size = new System.Drawing.Size(44, 30);
			this.lblcounter.TabIndex = 33;
			this.lblcounter.Text = "0";
			this.lblcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(24, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 30);
			this.label4.TabIndex = 31;
			this.label4.Text = "Subtraction";
			// 
			// Label2
			// 
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(14, 158);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(138, 51);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "Label2";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(230, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(272, 99);
			this.label3.TabIndex = 30;
			this.label3.Text = "label3";
			// 
			// picface
			// 
			this.picface.BackColor = System.Drawing.Color.Transparent;
			this.picface.Image = ((System.Drawing.Image)(resources.GetObject("picface.Image")));
			this.picface.Location = new System.Drawing.Point(227, 298);
			this.picface.Name = "picface";
			this.picface.Size = new System.Drawing.Size(71, 72);
			this.picface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picface.TabIndex = 29;
			this.picface.TabStop = false;
			// 
			// cmdnext
			// 
			this.cmdnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdnext.Image = global::ProfMathCsharp.Properties.Resources.AdobeAcrobat;
			this.cmdnext.Location = new System.Drawing.Point(252, 390);
			this.cmdnext.Name = "cmdnext";
			this.cmdnext.Size = new System.Drawing.Size(102, 37);
			this.cmdnext.TabIndex = 26;
			this.cmdnext.Text = "NEXT";
			this.cmdnext.UseVisualStyleBackColor = false;
			this.cmdnext.Click += new System.EventHandler(this.CmdnextClick);
			// 
			// GroupBox1
			// 
			this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.GroupBox1.Controls.Add(this.PictureBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.PictureBox3);
			this.GroupBox1.Controls.Add(this.txtans);
			this.GroupBox1.Location = new System.Drawing.Point(24, 69);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(192, 358);
			this.GroupBox1.TabIndex = 25;
			this.GroupBox1.TabStop = false;
			// 
			// PictureBox1
			// 
			this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
			this.PictureBox1.Location = new System.Drawing.Point(74, 121);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(16, 16);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 10;
			this.PictureBox1.TabStop = false;
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.White;
			this.Label1.Location = new System.Drawing.Point(14, 24);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(138, 51);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Label1";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PictureBox3
			// 
			this.PictureBox3.BackColor = System.Drawing.Color.Black;
			this.PictureBox3.Location = new System.Drawing.Point(16, 235);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(148, 2);
			this.PictureBox3.TabIndex = 7;
			this.PictureBox3.TabStop = false;
			// 
			// txtans
			// 
			this.txtans.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtans.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtans.Location = new System.Drawing.Point(16, 243);
			this.txtans.Name = "txtans";
			this.txtans.Size = new System.Drawing.Size(153, 61);
			this.txtans.TabIndex = 0;
			this.txtans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtansKeyDown);
			this.txtans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtansKeyPress);
			// 
			// Groupnum
			// 
			this.Groupnum.BackColor = System.Drawing.Color.Transparent;
			this.Groupnum.Controls.Add(this.one100);
			this.Groupnum.Controls.Add(this.one10);
			this.Groupnum.Controls.Add(this.one1000);
			this.Groupnum.Controls.Add(this.one1);
			this.Groupnum.Location = new System.Drawing.Point(592, 69);
			this.Groupnum.Name = "Groupnum";
			this.Groupnum.Size = new System.Drawing.Size(99, 134);
			this.Groupnum.TabIndex = 23;
			this.Groupnum.TabStop = false;
			this.Groupnum.Text = "Numerator";
			// 
			// one10
			// 
			this.one10.AutoSize = true;
			this.one10.Location = new System.Drawing.Point(14, 49);
			this.one10.Name = "one10";
			this.one10.Size = new System.Drawing.Size(37, 17);
			this.one10.TabIndex = 2;
			this.one10.TabStop = true;
			this.one10.Text = "10";
			this.one10.UseVisualStyleBackColor = true;
			this.one10.Click += new System.EventHandler(this.radionumerator);
			// 
			// one1000
			// 
			this.one1000.AutoSize = true;
			this.one1000.Location = new System.Drawing.Point(14, 97);
			this.one1000.Name = "one1000";
			this.one1000.Size = new System.Drawing.Size(49, 17);
			this.one1000.TabIndex = 3;
			this.one1000.TabStop = true;
			this.one1000.Text = "1000";
			this.one1000.UseVisualStyleBackColor = true;
			this.one1000.Click += new System.EventHandler(this.radionumerator);
			// 
			// one1
			// 
			this.one1.AutoSize = true;
			this.one1.Location = new System.Drawing.Point(14, 26);
			this.one1.Name = "one1";
			this.one1.Size = new System.Drawing.Size(31, 17);
			this.one1.TabIndex = 0;
			this.one1.TabStop = true;
			this.one1.Text = "1";
			this.one1.UseVisualStyleBackColor = true;
			this.one1.Click += new System.EventHandler(this.radionumerator);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Image = global::ProfMathCsharp.Properties.Resources.emoticon;
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label5.Location = new System.Drawing.Point(252, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(250, 23);
			this.label5.TabIndex = 32;
			this.label5.Text = "Answer 20 Questions to move to the next level";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// two100
			// 
			this.two100.AutoSize = true;
			this.two100.Location = new System.Drawing.Point(14, 72);
			this.two100.Name = "two100";
			this.two100.Size = new System.Drawing.Size(43, 17);
			this.two100.TabIndex = 3;
			this.two100.TabStop = true;
			this.two100.Text = "100";
			this.two100.UseVisualStyleBackColor = true;
			this.two100.Click += new System.EventHandler(this.radiodenominator);
			// 
			// Groupden
			// 
			this.Groupden.BackColor = System.Drawing.Color.Transparent;
			this.Groupden.Controls.Add(this.two100);
			this.Groupden.Controls.Add(this.two10);
			this.Groupden.Controls.Add(this.two1000);
			this.Groupden.Controls.Add(this.two1);
			this.Groupden.Location = new System.Drawing.Point(592, 224);
			this.Groupden.Name = "Groupden";
			this.Groupden.Size = new System.Drawing.Size(99, 150);
			this.Groupden.TabIndex = 24;
			this.Groupden.TabStop = false;
			this.Groupden.Text = "Denomenator";
			// 
			// two10
			// 
			this.two10.AutoSize = true;
			this.two10.Location = new System.Drawing.Point(14, 49);
			this.two10.Name = "two10";
			this.two10.Size = new System.Drawing.Size(37, 17);
			this.two10.TabIndex = 2;
			this.two10.TabStop = true;
			this.two10.Text = "10";
			this.two10.UseVisualStyleBackColor = true;
			this.two10.Click += new System.EventHandler(this.radiodenominator);
			// 
			// two1000
			// 
			this.two1000.AutoSize = true;
			this.two1000.Location = new System.Drawing.Point(14, 95);
			this.two1000.Name = "two1000";
			this.two1000.Size = new System.Drawing.Size(49, 17);
			this.two1000.TabIndex = 0;
			this.two1000.TabStop = true;
			this.two1000.Text = "1000";
			this.two1000.UseVisualStyleBackColor = true;
			this.two1000.Click += new System.EventHandler(this.radiodenominator);
			// 
			// two1
			// 
			this.two1.AutoSize = true;
			this.two1.Location = new System.Drawing.Point(14, 26);
			this.two1.Name = "two1";
			this.two1.Size = new System.Drawing.Size(31, 17);
			this.two1.TabIndex = 0;
			this.two1.TabStop = true;
			this.two1.Text = "1";
			this.two1.UseVisualStyleBackColor = true;
			this.two1.Click += new System.EventHandler(this.radiodenominator);
			// 
			// cmdreset
			// 
			this.cmdreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.cmdreset.FlatAppearance.BorderSize = 0;
			this.cmdreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdreset.Image = global::ProfMathCsharp.Properties.Resources.AdobeAcrobat;
			this.cmdreset.Location = new System.Drawing.Point(359, 423);
			this.cmdreset.Name = "cmdreset";
			this.cmdreset.Size = new System.Drawing.Size(102, 37);
			this.cmdreset.TabIndex = 27;
			this.cmdreset.Tag = "Reset Data";
			this.cmdreset.Text = "RESET";
			this.cmdreset.UseVisualStyleBackColor = false;
			this.cmdreset.Click += new System.EventHandler(this.CmdresetClick);
			// 
			// PictureBox2
			// 
			this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
			this.PictureBox2.Location = new System.Drawing.Point(221, 69);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(365, 305);
			this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox2.TabIndex = 28;
			this.PictureBox2.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::ProfMathCsharp.Properties.Resources.close_button;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(192)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(647, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 44);
			this.button1.TabIndex = 34;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// SubtForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::ProfMathCsharp.Properties.Resources.lightgreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblcounter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.picface);
			this.Controls.Add(this.cmdnext);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Groupnum);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Groupden);
			this.Controls.Add(this.cmdreset);
			this.Controls.Add(this.PictureBox2);
			this.DoubleBuffered = true;
			this.Name = "SubtForm";
			this.Size = new System.Drawing.Size(714, 479);
			this.Load += new System.EventHandler(this.SubtFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.picface)).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
			this.Groupnum.ResumeLayout(false);
			this.Groupnum.PerformLayout();
			this.Groupden.ResumeLayout(false);
			this.Groupden.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.Button cmdreset;
		internal System.Windows.Forms.RadioButton two1;
		internal System.Windows.Forms.RadioButton two1000;
		internal System.Windows.Forms.RadioButton two10;
		internal System.Windows.Forms.GroupBox Groupden;
		internal System.Windows.Forms.RadioButton two100;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.RadioButton one1;
		internal System.Windows.Forms.RadioButton one1000;
		internal System.Windows.Forms.RadioButton one10;
		internal System.Windows.Forms.GroupBox Groupnum;
		internal System.Windows.Forms.TextBox txtans;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button cmdnext;
		internal System.Windows.Forms.PictureBox picface;
		internal System.Windows.Forms.PictureBox PictureBox1;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblcounter;
		internal System.Windows.Forms.RadioButton one100;
	}
}
