using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ProfMathCsharp.Properties;

namespace ProfMathCsharp
{
    class ProfMathCl
    {
    	#region fields
    	ushort numerator, denominator;
        Random rnd=new Random();
		protected int ans;
		//public fields
		public ushort profAddcounter=0; public byte profAddfails=0;
		public ushort profSubtcounter=0;public byte profSubtfails=0;
		public ushort profMultcounter=0;public byte profMultfails=0;
		public ushort profDivcounter=0;public byte profDivfails=0;
		
		#endregion
		
        #region generator functions
        protected ushort ones() 
        {
            return (ushort)(rnd.NextDouble() * 10);
        }
        protected ushort tens() 
        {
            return (ushort)(rnd.NextDouble() * 100);
        }
        protected ushort hundreds() 
        {
            return (ushort)(rnd.NextDouble() * 1000);
        }
        protected ushort thousands() 
        {
            return (ushort)(rnd.NextDouble() * 10000);
        }
        #endregion

        public void Reset(Label proflabel, ushort counter, Label lblcounter,
                              byte failtimes, PictureBox picface,
                              TextBox ansText,List<RadioButton> radiobuttons)
        {
        	int t=(int)MessageBox.Show("Do you really want to reset this module?","Reset",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        	if (t==(int)DialogResult.Yes)
        	{
	        	proflabel.Text="Welcome, Karibu";
	        	counter=0;
	        	lblcounter.Text=counter.ToString();
	        	failtimes=0;
	        	picface.Image=Resources.smiley;
	        	ansText.Text="";
                radiobuttons[0].Checked = true; radiobuttons[0].PerformClick();
                radiobuttons[4].Checked = true; radiobuttons[4].PerformClick();
        	}
        }

        public void showLabel1(Label lbl1, byte level)
        {
            switch (level)
            { 
                case 1:
                    numerator = ones(); break;
                case 2:
                    numerator = tens(); break;
                case 3:
                    numerator = hundreds(); break;
                case 4:
                    numerator = thousands(); break;
            }
            if (numerator==0)
            	showLabel1(lbl1,level);
            lbl1.Text = numerator.ToString(); //assign label1 the numerator variable
        }
        
        public void showLabel2(Label lbl2, byte level)
        {
            switch (level)
            {
                case 1:
                    denominator = ones(); break;
                case 2:
                    denominator = tens(); break;
                case 3:
                    denominator = hundreds(); break;
                case 4:
                    denominator = thousands(); break;
            }
            if (denominator==0)
            	showLabel2(lbl2,level);
            
            lbl2.Text = denominator.ToString(); //assign label2 the denominator variable
        }
        
        #region moveToNext

        private bool Answer(byte formnumber,TextBox ansText)
        {
        	
        	//1 for add, 2 for subtract, 3 for mult, 4 for div
        	try
        	{
	        	switch (formnumber)
	        	{
	        		case 1:
	        			ans=numerator+denominator;break;
	        		case 2:
	        			ans=numerator-denominator;break;
	        		case 3:
	        			ans=numerator*denominator;break;
	        		//case 4:
	        			//ans=numerator/denominator;break;		
	        	}
	        	if (ans==int.Parse(ansText.Text))
	        		return true;
	        	else
	        		return false;
        	}
        	catch(Exception AnswersErr){
        		throw AnswersErr;
        	}
        	
        }
        
        public void moveToNext(byte formnumber, Label proflabel, ushort counter, Label lblcounter,
                              byte failtimes, PictureBox picface,
                             TextBox ansText,List<RadioButton> radiobuttons)
        {
        	try
        	{
                if (ansText.Text == "" || ansText.Text == null)
                    return;

	        	bool isCorrect=false;
	        	switch(formnumber)
	        	{
	        		case 1:
	        			isCorrect=Answer(1,ansText);break;
	        		case 2:
	        			isCorrect=Answer(2,ansText);break;
	        		case 3:
	        			isCorrect=Answer(3,ansText);break;
	        	}
	        	if (isCorrect)
	        	{
	        		if (counter==20)
	        		{
	        			proflabel.Text="Congratulations you have moved to the next level, tens";
	        			radiobuttons[1].Checked=true;
	        			radiobuttons[5].Checked=true;
	        		}
	        		else if (counter==40)
	        		{
	        			proflabel.Text="Congratulations you have moved to the next level, hundreds";
	        			radiobuttons[2].Checked=true;
	        			radiobuttons[6].Checked=true;
	        		}
	        		else if (counter==60)
	        		{
	        			proflabel.Text="Congratulations you have moved to the next level, thousands";
	        			radiobuttons[3].Checked=true;
	        			radiobuttons[7].Checked=true;
	        		}
	        		proflabel.Text="Congratulations move on to the next problem";
	        		picface.Image= Resources.passed;
	        		counter++;
	        		{ //if blocks to determine 'counter' variable in individual forms
	        			if (formnumber==1) profAddcounter=counter;
	        			if (formnumber==2) profSubtcounter=counter;
	        			if (formnumber==3) profMultcounter=counter;
	        			//if (formnumber==1) profDivcounter=counter;
	        		}
	        		lblcounter.Text=counter.ToString();
	        		ansText.Text="";
	        		//generate next numerator and denominator
	        		foreach (RadioButton rd in radiobuttons)
		            {
		                if (rd.Checked == true)
		                    rd.PerformClick();
		            }
	        		
	        	}
	        	else
	        	{
	        		failtimes++;
	        		{//if blocks to determine 'fail' variable in individual forms
	        			if (formnumber==1) profAddfails=failtimes;
	        			if (formnumber==2) profSubtfails=failtimes;
	        			if (formnumber==3) profMultfails=failtimes;
	        		}
	        		proflabel.Text="Please retry the problem no giving up!";
	        		picface.Image=Resources.fail;
	        	}
        	}
        	catch (Exception p)
        	{
        		MessageBox.Show(p.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        	}
	        	
        }
        
        //for division
        public void moveToNext(byte formnumber, Label proflabel, ushort counter, Label lblcounter,
                              byte failtimes, PictureBox picface,
                             TextBox ansText,List<RadioButton> radiobuttons,TextBox wholeno,
                             TextBox remainder,byte decimalpoint)
        {
        	try
        	{
        		bool isCorrect=QuotientAnswer(formnumber,ansText,wholeno,remainder,decimalpoint);
        		if (isCorrect)
        		{
        			if (counter==20)
	        		{
	        			proflabel.Text="Congratulations you have moved to the next level, tens";
	        			radiobuttons[1].Checked=true;
	        			radiobuttons[5].Checked=true;
	        		}
	        		else if (counter==40)
	        		{
	        			proflabel.Text="Congratulations you have moved to the next level, hundreds";
	        			radiobuttons[2].Checked=true;
	        			radiobuttons[6].Checked=true;
	        		}
	        		else if (counter==60)
	        		{
	        			proflabel.Text="Congratulations you have moved to the next level, thousands";
	        			radiobuttons[3].Checked=true;
	        			//radiobuttons[7].Checked=true;
	        		}
	        		proflabel.Text="Congratulations move on to the next problem";
	        		picface.Image= Resources.passed;
	        		counter++;
	        		//
	        		profDivcounter=counter;
	        		//
	        		lblcounter.Text=counter.ToString();
	        		ansText.Text="";
	        		//generate next numerator and denominator
	        		foreach (RadioButton rd in radiobuttons)
		            {
		                if (rd.Checked == true)
		                    rd.PerformClick();
		            }
	        		
        		}
        		else
	        	{
	        		failtimes++;
	        		profDivfails=failtimes;
	        		proflabel.Text="Please retry the problem...no giving up, Remember to place the decimal point correctly";
	        		picface.Image=Resources.fail;
	        	}
        	}
        	catch(Exception p){
        		MessageBox.Show(p.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        	}
        }
        
        private bool QuotientAnswer(byte formnumber,TextBox ansText,TextBox wholeno, TextBox remainder, byte decimalpoint)
        {
        	float ansfloat;
        	string ansConverter;
        	int ansToInt;
        	int rem;
        	try
        	{
        		ansfloat=(float)numerator/(float)denominator;
        		
        		if (decimalpoint==1)//wholeno and remainder
        		{ 
        				rem=numerator%denominator;
        				ansToInt=(int)ansfloat;
        				if (ansToInt==int.Parse(wholeno.Text) && rem==int.Parse(remainder.Text))
        					return true;
        				else
        					return false;
        		}
        		else if(decimalpoint==2)//2 decimal point
				{
					//MessageBox.Show(ansfloat.ToString());
					//ansConverter=String.Format("{0:n2}",ansfloat.ToString()); doesnt work!!
                    ansConverter = Math.Round(ansfloat, 2).ToString();
					//MessageBox.Show(ansConverter);
					if (ansConverter.Equals(ansText.Text))
						return true;
				}
        		else if(decimalpoint==3)//3 decimal point
    			{ 
    				//ansConverter=Microsoft.VisualBasic.Strings.Format(ansfloat.ToString(),"#.###");
    				//ansConverter=string.Format("{0:n3}",ansfloat.ToString()); doesnt work
                    //ansConverter=string.Format("{0:#,#0.0}", Math.Round(ansfloat, 3));
                    ansConverter = Math.Round(ansfloat, 3).ToString();
    				//MessageBox.Show(ansConverter);
    				if (ansConverter.Equals(ansText.Text)) 
    					return true;
    			}
    		
        		return false;
        	}
        	catch(Exception QuotientErr){
        		throw QuotientErr;
        	}
        }
        
        #endregion
        
        #region clear controls
        
		public void Clear(Form frm)
		{
			foreach(Control k in frm.Controls)
			{
				if (k is TextBox)
					k.Text="";
			}
		}
		
        public void Clear(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }
        
        /*public void clearControls(Object obj)
        {
            if (obj.GetType() is Form)
            {
                Form frm = (Form)obj;
                foreach (Control c in frm.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
            }
            else if (obj.GetType() is GroupBox)
            {
                GroupBox grp = (GroupBox)obj;
                foreach (Control c in grp.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
            }

            
        }
        */
       
        #endregion
    }
}
