using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace ProfMathCsharp
{
    public partial class MainForm : Form
    {
        #region 'dim' forms
        
		AddForm af;
		SubtForm sf;
		MultForm mf;
		DivForm df;
		bool confirm=System.IO.File.Exists(Application.StartupPath + "\\pic.txt");
		FileStream fs;
		StreamWriter sw;
		StreamReader sr;
		
		#endregion
        
        public MainForm()
        {
        	InitializeComponent();
        }
          
        
        void ExitToolStripMenuItem1Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }
        
        void ThemeToolStripMenuItemClick(object sender, EventArgs e)
        {
        	OpenFileDialog op=new OpenFileDialog();
        	op.Title="Select Background";
        	op.Filter = "All Pictures(*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";
            op.InitialDirectory = Environment.CurrentDirectory + @"\pics";
        	op.ShowDialog();
        	this.BackgroundImageLayout= ImageLayout.Stretch;
        	if (op.FileName.Equals("") || op.FileName.Equals(null))
        		return;
        	else
        	{
        		this.BackgroundImage=Image.FromFile(op.FileName);
	        	
        		if (confirm)
	        		fs=new FileStream(Application.StartupPath + "\\pic.txt", FileMode.Truncate);
        		else
        			fs = new FileStream(Application.StartupPath + "\\pic.txt", FileMode.CreateNew);                   
        		
                  	//
                  	
                sw = new StreamWriter(fs);
                sw.WriteLine(op.FileName);
                sw.Close();sw.Dispose();
                fs.Close();fs.Dispose();
        	}
        	/*
        	If confirm = True Then
                    Dim fs1 As FileStream
                    Dim sw1 As StreamWriter
                    fs1 = New FileStream(Application.StartupPath & "\pic.txt", FileMode.Truncate)
                    sw1 = New StreamWriter(fs1)
                    sw1.WriteLine(.FileName)
                    sw1.Close() : fs1.Close()
                Else
                    Dim fs As FileStream
                    Dim sw As StreamWriter
                    fs = New FileStream(Application.StartupPath & "\pic.txt", FileMode.CreateNew)
                    sw = New StreamWriter(fs)
                    If Not .FileName = "" Then sw.WriteLine(.FileName)
                    sw.Close()
                    fs.Close()
                End If
        	 * */
        }
        
        void CmdAddClick(object sender, EventArgs e)
        {
        	panel1.Controls.Clear();
        	
        	if (af == null || af.IsDisposed)
        	{
        		af=new AddForm();
        		panel1.Controls.Add(af);
        	}
        	else
        		panel1.Controls.Add(af);
        }
        
        void CmdSubtClick(object sender, EventArgs e)
        {
        	panel1.Controls.Clear();
        	if (sf==null || sf.IsDisposed)
        	{
        		sf=new SubtForm();
        		panel1.Controls.Add(sf);
        	}
        	else
        		panel1.Controls.Add(sf);
        }
        
        void CmdMultClick(object sender, EventArgs e)
        {
        	panel1.Controls.Clear();
        	if (mf==null || mf.IsDisposed)
        	{
        		mf=new MultForm();
        		panel1.Controls.Add(mf);
        	}
        	else
        		panel1.Controls.Add(mf);
        }
        
        void CmdDivClick(object sender, EventArgs e)
        {
        	panel1.Controls.Clear();
        	if (df==null || df.IsDisposed)
        	{
        		df=new DivForm();
        		panel1.Controls.Add(df);
        	}
        	else
        		panel1.Controls.Add(df);
        }
        
        void MainForm_Load(object sender, EventArgs e)
        {
        	 WindowState=FormWindowState.Maximized;
             
             try
             {
                 if (confirm)
                 {
                     fs = new FileStream(Application.StartupPath + "\\pic.txt", FileMode.Open);
                     sr = new StreamReader(fs);
                     this.BackgroundImage = Image.FromFile(sr.ReadLine());
                     sr.Close(); sr.Dispose();
                     fs.Close(); fs.Dispose();
                 }
             }
             catch (Exception ee){
                 sr.Close(); sr.Dispose();
                 fs.Close(); fs.Dispose();
                 MessageBox.Show(ee.Message + "\n" + ee.Source);
             }
        	 /*
        	  * Public confirm As Boolean = System.IO.File.Exists(Application.StartupPath & "\pic.txt")
        	  *If confirm = True Then
                Dim fs As FileStream
                Dim sr As StreamReader
                fs = New FileStream(Application.StartupPath & "\pic.txt", FileMode.Open)
                sr = New StreamReader(fs)
                'Dim op As New OpenFileDialog
                'op.FileName = sr.ReadLine
                Me.PictureBox1.Image = Image.FromFile(sr.ReadLine())
                sr.Close() : fs.Close()
        	  *  
        	  * */
        	 
        	 
        }
        
        void Timer1Tick(object sender, EventArgs e)
        {
        	toolStripStatusLabel2.Text=string.Format("{0:D}",DateAndTime.Now.ToString());
        }
        
        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
        	timer2.Enabled=true;
        	new About().ShowDialog();
        	Opacity=1;
        }
        
        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
        	int t=(int)MessageBox.Show("Do you really want to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (t == (int)DialogResult.Yes)
            {
                Splashcs.getInstance.Close();
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        
        void HelpToolStripMenuItemClick(object sender, EventArgs e)
        {
        	//Interaction.Shell(); used from the VisualBasic namespace
        	System.Diagnostics.Process.Start("user\\user1.html");
        }
        
        void Timer2Tick(object sender, EventArgs e)
        {
        	Opacity=Opacity-0.1;
        	if (Opacity==0.8)
        	{
        		timer2.Enabled=false;
        		//new About().ShowDialog();
        	}
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}