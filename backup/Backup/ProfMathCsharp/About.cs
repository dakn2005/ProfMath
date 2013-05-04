/*
 * Created by SharpDevelop.
 * User: Njuguna
 * Date: 12/30/2010
 * Time: 9:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProfMathCsharp
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		
		
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			label1.SetBounds(0,label1.Top+1,0,0,BoundsSpecified.Y);
			if (label1.Top==250)
			{
				label1.Visible=false;
				label1.Top=-50;
				label1.Visible=true;
			}
		}
		
		void AboutLoad(object sender, EventArgs e)
		{
			label1.Top=-50;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			Close();
		}
	}
}
