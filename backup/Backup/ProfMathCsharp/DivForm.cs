/*
 * Created by SharpDevelop.
 * User: Njuguna
 * Date: 12/28/2010
 * Time: 11:51 AM
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
	/// Description of DivForm.
	/// </summary>
	public partial class DivForm : UserControl
	{
		 ProfMathCl pm = new ProfMathCl();
        List<RadioButton> rad = new List<RadioButton>();
        RadioButton rdname;
        
        byte failtimes=0;
        ushort counter=0;
        byte decpoint=0;
        
		public DivForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DivFormLoad(object sender, EventArgs e)
		{
			 rad.Add(one1); rad.Add(one10); rad.Add(one100); rad.Add(one1000);
            rad.Add(two1); rad.Add(two10); rad.Add(two100); //rad.Add(two1000);

            one1.Checked = true; one1.PerformClick();
            two1.Checked = true; two1.PerformClick();
            
            label5.Left=-200;
            txtans.Focus();
            
            Mn1.PerformClick();
		}
		
		void CmdnextClick(object sender, EventArgs e)
		{
			//MessageBox.Show(decpoint.ToString());
			pm.moveToNext(4,label3,counter,lblcounter,failtimes,picface,txtans,rad,
			             txtWholeNo,txtRemainder,decpoint);
        	counter=pm.profDivcounter;
        	failtimes=pm.profDivfails;
		}
		
		void CmdresetClick(object sender, EventArgs e)
		{
			//pm.Clear(GroupBox1);
            pm.Reset(label3,counter,lblcounter,failtimes,picface,txtans,rad);
            pm.Clear(groupBox2);
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
			if (e.KeyCode == Keys.Enter)
                cmdnext.PerformClick();
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
		
		  private void radionumerator(object sender, EventArgs e)
        {
            rdname = (RadioButton)sender;
            // MessageBox.Show(Microsoft.VisualBasic.Strings.Mid(rdname.Name,4));
            ushort getlevel = ushort.Parse(Microsoft.VisualBasic.Strings.Mid(rdname.Name, 4));
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
            ushort getlevel = ushort.Parse(Microsoft.VisualBasic.Strings.Mid(rdname.Name, 4));
            switch (getlevel)
            {
                case 1:
                    pm.showLabel2(Label2, 1); break;
                case 10:
                    pm.showLabel2(Label2, 2); break;
                case 100:
                    pm.showLabel2(Label2, 3); break;
               // case 1000:
               //     pm.showLabel2(Label2, 4); break;
            }

        }
		
        void setDecPoint(object sender, EventArgs e)
        {
        	ToolStripMenuItem item=(ToolStripMenuItem) sender;
        	byte getpoint=byte.Parse(Microsoft.VisualBasic.Strings.Mid(item.Name,3));
        	if (getpoint==1){
        		groupBox2.Visible=true;
        		decpoint=1;
        		Mn2.Checked=false;
        		Mn3.Checked=false;
        		label8.Text="Enter whole number and\n remainder";
        	}
        	else if(getpoint==2){
        		groupBox2.Visible=false;
        		decpoint=2;
        		Mn1.Checked=false;
        		Mn3.Checked=false;
        		label8.Text="To 2 decimal points";
        	}
        	else if (getpoint==3){
        		groupBox2.Visible=false;
        		decpoint=3;
        		Mn1.Checked=false;
        		Mn2.Checked=false;
        		label8.Text="To 3 decimal points";
        	}
        }
		
		
		
		void TxtRemainderKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode==Keys.Enter)
				cmdnext.PerformClick();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
