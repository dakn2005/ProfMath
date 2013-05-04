/*
 * Created by SharpDevelop.
 * User: Njuguna
 * Date: 12/30/2010
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfMathCsharp
{
	/// <summary>
	/// Description of Splashcs.
	/// </summary>
	public partial class Splashcs : Form
	{
		short dots;
        private static Splashcs _instance;

        public static Splashcs getInstance 
        {
            get { return _instance; }
        }

		public Splashcs()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            _instance = this;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SplashcsKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Escape)
				Application.Exit();
		}
		
		void SplashcsLoad(object sender, EventArgs e)
		{
			Opacity=0;
			//StartPosition= FormStartPosition.CenterScreen;
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			Opacity+=0.1;
			if (Opacity==1)
				Timer1.Enabled=false;
		}
		
		void Timer2Tick(object sender, EventArgs e)
		{
			dots++;
			Label4.Text+=".";
			if (dots==5)
			{
				Timer2.Enabled=false;
				Hide();
                new MainForm().Show();
                
			}
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
