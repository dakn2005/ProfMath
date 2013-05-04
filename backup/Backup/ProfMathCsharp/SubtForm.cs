/*
 * Created by SharpDevelop.
 * User: Njuguna
 * Date: 12/28/2010
 * Time: 11:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualBasic;
namespace ProfMathCsharp
{
	/// <summary>
	/// Description of SubtForm.
	/// </summary>
	public partial class SubtForm : UserControl
	{
		ProfMathCl pm = new ProfMathCl();
        List<RadioButton> rad = new List<RadioButton>();
        RadioButton rdname;
        
        byte failtimes=0;
        ushort counter=0;
        
		public SubtForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void SubtFormLoad(object sender, EventArgs e)
		{
			rad.Add(one1); rad.Add(one10); rad.Add(one100); rad.Add(one1000);
            rad.Add(two1); rad.Add(two10); rad.Add(two100); rad.Add(two1000);

            one1.Checked = true; one1.PerformClick();
            two1.Checked = true; two1.PerformClick();
            
            label5.Left=-200;
            txtans.Focus();
		}
		
		private void radionumerator(object sender, EventArgs e)
        {
            rdname = (RadioButton)sender;
            // MessageBox.Show(Microsoft.VisualBasic.Strings.Mid(rdname.Name,4));
            int getlevel = int.Parse(Microsoft.VisualBasic.Strings.Mid(rdname.Name, 4));
            switch (getlevel)
            {
                case 1:
                    pm.showLabel1(Label1, 1); break;
                case 10:
                    pm.showLabel1(Label1, 2); break;
                case 100:
                    pm.showLabel1(Label1, 3); break;
                case 1000:
                    pm.showLabel1(Label1, 4); break;

            }
        }

        private void radiodenominator(object sender, EventArgs e)
        {
            rdname = (RadioButton)sender;
            int getlevel = int.Parse(Microsoft.VisualBasic.Strings.Mid(rdname.Name, 4));
            switch (getlevel)
            {
                case 1:
                    pm.showLabel2(Label2, 1); break;
                case 10:
                    pm.showLabel2(Label2, 2); break;
                case 100:
                    pm.showLabel2(Label2, 3); break;
                case 1000:
                    pm.showLabel2(Label2, 4); break;
            }

        }
        
        
		
		void CmdresetClick(object sender, EventArgs e)
		{
			  //pm.Clear(GroupBox1);
            pm.Reset(label3,counter,lblcounter,failtimes,picface,txtans,rad);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			label5.SetBounds(label5.Left+1,0,0,0,BoundsSpecified.X);
        	if (label5.Left>=650)
        	{
        		label5.Visible=false;
        		label5.Left=-200;
        		label5.Visible=true;
        	}
		}
		
		void TxtansKeyPress(object sender, KeyPressEventArgs e)
		{
			
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Interaction.Beep();
            }
		}
		
		void TxtansKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
				cmdnext.PerformClick();
		}
		
		void CmdnextClick(object sender, EventArgs e)
		{
			pm.moveToNext(2,label3,counter,lblcounter,failtimes,picface,txtans,rad);
        	counter=pm.profSubtcounter;
        	failtimes=pm.profSubtfails;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
