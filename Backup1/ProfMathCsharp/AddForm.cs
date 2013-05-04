using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProfMathCsharp
{
    public partial class AddForm : UserControl
    {
        ProfMathCl pm = new ProfMathCl();
        List<RadioButton> rad = new List<RadioButton>();
        RadioButton rdname;
        
        byte failtimes=0;
        ushort counter=0;

        public AddForm()
        {
            InitializeComponent();
        }

        private void Groupnum_Enter(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
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

        private void cmdnext_Click(object sender, EventArgs e)
        {
        	pm.moveToNext(1,label3,counter,lblcounter,failtimes,picface,txtans,rad);
        	counter=pm.profAddcounter;
        	failtimes=pm.profAddfails;
        }

        private void cmdreset_Click(object sender, EventArgs e)
        {
            //pm.Clear(GroupBox1);
            pm.Reset(label3,counter,lblcounter,failtimes,picface,txtans,rad);
        }

        private void txtans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                Interaction.Beep();
            }
        }

        private void txtans_KeyDown(object sender, KeyEventArgs e)
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
        
        
        
        void Button1Click(object sender, EventArgs e)
        {
        	Dispose();
        }
    }
}
