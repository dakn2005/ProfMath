namespace ProfMathCsharp
{
    partial class AddForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.Label2 = new System.Windows.Forms.Label();
            this.two1000 = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.Groupden = new System.Windows.Forms.GroupBox();
            this.two100 = new System.Windows.Forms.RadioButton();
            this.two10 = new System.Windows.Forms.RadioButton();
            this.two1 = new System.Windows.Forms.RadioButton();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtans = new System.Windows.Forms.TextBox();
            this.cmdreset = new System.Windows.Forms.Button();
            this.cmdnext = new System.Windows.Forms.Button();
            this.one100 = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Groupnum = new System.Windows.Forms.GroupBox();
            this.one10 = new System.Windows.Forms.RadioButton();
            this.one1000 = new System.Windows.Forms.RadioButton();
            this.one1 = new System.Windows.Forms.RadioButton();
            this.picface = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblcounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Groupden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Groupnum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picface)).BeginInit();
            this.SuspendLayout();
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
            // Groupden
            // 
            this.Groupden.Controls.Add(this.two100);
            this.Groupden.Controls.Add(this.two10);
            this.Groupden.Controls.Add(this.two1000);
            this.Groupden.Controls.Add(this.two1);
            this.Groupden.Location = new System.Drawing.Point(590, 234);
            this.Groupden.Name = "Groupden";
            this.Groupden.Size = new System.Drawing.Size(99, 150);
            this.Groupden.TabIndex = 12;
            this.Groupden.TabStop = false;
            this.Groupden.Text = "Denomenator";
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
            // PictureBox3
            // 
            this.PictureBox3.BackColor = System.Drawing.Color.Black;
            this.PictureBox3.Location = new System.Drawing.Point(16, 235);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(148, 2);
            this.PictureBox3.TabIndex = 7;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(219, 79);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(365, 305);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 16;
            this.PictureBox2.TabStop = false;
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
            this.txtans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtans_KeyDown);
            this.txtans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtans_KeyPress);
            // 
            // cmdreset
            // 
            this.cmdreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdreset.FlatAppearance.BorderSize = 0;
            this.cmdreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdreset.Image = global::ProfMathCsharp.Properties.Resources.AdobeInCopy;
            this.cmdreset.Location = new System.Drawing.Point(357, 433);
            this.cmdreset.Name = "cmdreset";
            this.cmdreset.Size = new System.Drawing.Size(102, 37);
            this.cmdreset.TabIndex = 15;
            this.cmdreset.Tag = "Reset Data";
            this.cmdreset.Text = "RESET";
            this.cmdreset.UseVisualStyleBackColor = false;
            this.cmdreset.Click += new System.EventHandler(this.cmdreset_Click);
            // 
            // cmdnext
            // 
            this.cmdnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdnext.Image = global::ProfMathCsharp.Properties.Resources.AdobeInCopy;
            this.cmdnext.Location = new System.Drawing.Point(250, 400);
            this.cmdnext.Name = "cmdnext";
            this.cmdnext.Size = new System.Drawing.Size(102, 37);
            this.cmdnext.TabIndex = 14;
            this.cmdnext.Text = "NEXT";
            this.cmdnext.UseVisualStyleBackColor = false;
            this.cmdnext.Click += new System.EventHandler(this.cmdnext_Click);
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
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.PictureBox3);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.txtans);
            this.GroupBox1.Location = new System.Drawing.Point(22, 79);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(192, 358);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(71, 105);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 16);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // Groupnum
            // 
            this.Groupnum.Controls.Add(this.one100);
            this.Groupnum.Controls.Add(this.one10);
            this.Groupnum.Controls.Add(this.one1000);
            this.Groupnum.Controls.Add(this.one1);
            this.Groupnum.Location = new System.Drawing.Point(590, 79);
            this.Groupnum.Name = "Groupnum";
            this.Groupnum.Size = new System.Drawing.Size(99, 134);
            this.Groupnum.TabIndex = 11;
            this.Groupnum.TabStop = false;
            this.Groupnum.Text = "Numerator";
            this.Groupnum.Enter += new System.EventHandler(this.Groupnum_Enter);
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
            // picface
            // 
            this.picface.BackColor = System.Drawing.Color.Transparent;
            this.picface.Image = ((System.Drawing.Image)(resources.GetObject("picface.Image")));
            this.picface.Location = new System.Drawing.Point(225, 308);
            this.picface.Name = "picface";
            this.picface.Size = new System.Drawing.Size(71, 72);
            this.picface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picface.TabIndex = 18;
            this.picface.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(228, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 99);
            this.label3.TabIndex = 19;
            this.label3.Text = "Welcome, Karibu";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Add";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = global::ProfMathCsharp.Properties.Resources.emoticon;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(250, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Answer 20 Questions to move to the next level";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcounter
            // 
            this.lblcounter.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcounter.ForeColor = System.Drawing.Color.White;
            this.lblcounter.Location = new System.Drawing.Point(374, 397);
            this.lblcounter.Name = "lblcounter";
            this.lblcounter.Size = new System.Drawing.Size(44, 30);
            this.lblcounter.TabIndex = 22;
            this.lblcounter.Text = "0";
            this.lblcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProfMathCsharp.Properties.Resources.closebutton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(166)))), ((int)(((byte)(197)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(633, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 44);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ProfMathCsharp.Properties.Resources.AddfrmBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picface);
            this.Controls.Add(this.Groupden);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.cmdreset);
            this.Controls.Add(this.cmdnext);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Groupnum);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Name = "AddForm";
            this.Size = new System.Drawing.Size(714, 479);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.Groupden.ResumeLayout(false);
            this.Groupden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Groupnum.ResumeLayout(false);
            this.Groupnum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picface)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.PictureBox picface;

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RadioButton two1000;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox Groupden;
        internal System.Windows.Forms.RadioButton two100;
        internal System.Windows.Forms.RadioButton two10;
        internal System.Windows.Forms.RadioButton two1;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.TextBox txtans;
        internal System.Windows.Forms.Button cmdreset;
        internal System.Windows.Forms.Button cmdnext;
        internal System.Windows.Forms.RadioButton one100;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.GroupBox Groupnum;
        internal System.Windows.Forms.RadioButton one10;
        internal System.Windows.Forms.RadioButton one1000;
        internal System.Windows.Forms.RadioButton one1;
    }
}
