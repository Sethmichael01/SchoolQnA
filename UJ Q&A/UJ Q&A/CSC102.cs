/*
 * Created by SharpDevelop.
 * User: user
 * Date: 6/11/2019
 * Time: 8:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UJ_Q_A.Properties
{
	/// <summary>
	/// Description of CSC102.
	/// </summary>
	public partial class CSC102 : Form
	{
		List<Panel> ListPanel= new List<Panel>();
		int index;
		public CSC102()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CSC102_Load(object sender, EventArgs e)
		{
			ListPanel.Add(panel1);
			ListPanel.Add(panel2);
			ListPanel.Add(panel3);
			ListPanel.Add(panel4);
			ListPanel.Add(panel5);
			ListPanel.Add(panel6);
			ListPanel.Add(panel7);
			ListPanel.Add(panel8);
			ListPanel.Add(panel9);
			ListPanel.Add(panel10);
			ListPanel.Add(panel11);
			ListPanel.Add(panel12);
			ListPanel.Add(panel13);
			ListPanel.Add(panel14);
			ListPanel.Add(panel15);
			ListPanel.Add(panel16);
			ListPanel.Add(panel17);
			ListPanel.Add(panel18);
			ListPanel.Add(panel19);
			ListPanel.Add(panel20);
			ListPanel.Add(panel21);
			ListPanel.Add(panel22);
			ListPanel.Add(panel23);
			ListPanel.Add(panel24);
			ListPanel.Add(panel25);
			ListPanel.Add(panel26);
			ListPanel.Add(panel27);
			ListPanel.Add(panel28);
			ListPanel.Add(panel29);
			ListPanel.Add(panel30);
			ListPanel[index].BringToFront();
	
		}
		void btnnext_Click(object sender, EventArgs e)
		{
			if(radioButton2.Checked)
			{
				button31.BackColor= Color.Green;
			}
			if(radioButton1.Checked||radioButton3.Checked||radioButton4.Checked)
				button31.BackColor=Color.Red;
			//
			if(radioButton6.Checked)
			{
				button32.BackColor= Color.Green;
			}
			if(radioButton7.Checked||radioButton8.Checked||radioButton5.Checked)
				button32.BackColor=Color.Red;
			//
			if(radioButton12.Checked)
			{
				button33.BackColor= Color.Green;
			}
			if(radioButton9.Checked||radioButton10.Checked||radioButton11.Checked)
				button33.BackColor=Color.Red;
			//
			
			if(radioButton16.Checked)
			{
				button34.BackColor= Color.Green;
			}
			if(radioButton13.Checked||radioButton14.Checked||radioButton15.Checked)
				button34.BackColor=Color.Red;
			//
			if(radioButton18.Checked)
			{
				button35.BackColor= Color.Green;
			}
			if(radioButton17.Checked||radioButton19.Checked||radioButton20.Checked)
				button35.BackColor=Color.Red;
			//
			
			if(radioButton24.Checked)
			{
				button36.BackColor= Color.Green;
			}
			if(radioButton21.Checked||radioButton22.Checked||radioButton23.Checked)
				button36.BackColor=Color.Red;
			//
			
			if(radioButton25.Checked)
			{
				button37.BackColor=Color.Green;
			}
			if(radioButton26.Checked||radioButton27.Checked||radioButton28.Checked)
				button37.BackColor=Color.Red;
			//
			
			if(radioButton29.Checked)
			{
				button38.BackColor= Color.Green;
			}
			if(radioButton30.Checked||radioButton31.Checked||radioButton32.Checked)
				button38.BackColor=Color.Red;
			//
			
			if(radioButton35.Checked)
			{
				button39.BackColor= Color.Green;
			}
			if(radioButton33.Checked||radioButton34.Checked||radioButton36.Checked)
				button39.BackColor=Color.Red;
			//
			
			if(radioButton39.Checked)
			{
				button40.BackColor= Color.Green;
			}
			if(radioButton37.Checked||radioButton38.Checked||radioButton40.Checked)
				button40.BackColor=Color.Red;
			//
			
			if(radioButton42.Checked)
			{
				button41.BackColor= Color.Green;
			}
			if(radioButton41.Checked||radioButton43.Checked||radioButton44.Checked)
				button41.BackColor=Color.Red;
			//
			
			if(radioButton47.Checked)
			{
				button42.BackColor= Color.Green;
			}
			if(radioButton45.Checked||radioButton46.Checked||radioButton48.Checked)
				button42.BackColor=Color.Red;
			//
			
			if(radioButton51.Checked)
			{
				button43.BackColor= Color.Green;
			}
			if(radioButton49.Checked||radioButton50.Checked||radioButton52.Checked)
				button43.BackColor=Color.Red;
			//
			
			if(radioButton53.Checked)
			{
				button44.BackColor= Color.Green;
			}
			if(radioButton54.Checked||radioButton55.Checked||radioButton56.Checked)
				button44.BackColor=Color.Red;
			//
			if(radioButton60.Checked)
			{
				button45.BackColor= Color.Green;
			}
			if(radioButton57.Checked||radioButton58.Checked||radioButton59.Checked)
				button45.BackColor=Color.Red;
			//
			
			if(radioButton63.Checked)
			{
				button46.BackColor= Color.Green;
			}
			if(radioButton61.Checked||radioButton62.Checked||radioButton64.Checked)
				button46.BackColor=Color.Red;
			//
			
			if(radioButton68.Checked)
			{
				button47.BackColor= Color.Green;
			}
			if(radioButton65.Checked||radioButton66.Checked||radioButton67.Checked)
				button47.BackColor=Color.Red;
			//
			
			if(radioButton70.Checked)
			{
				button48.BackColor= Color.Green;
			}
			if(radioButton69.Checked||radioButton71.Checked||radioButton72.Checked)
				button48.BackColor=Color.Red;
			//
			
			if(radioButton74.Checked)
			{
				button49.BackColor= Color.Green;
			}
			if(radioButton73.Checked||radioButton75.Checked||radioButton76.Checked)
				button49.BackColor=Color.Red;
			//
			
			if(radioButton77.Checked)
			{
				button50.BackColor= Color.Green;
			}
			if(radioButton78.Checked||radioButton79.Checked||radioButton80.Checked)
				button50.BackColor=Color.Red;
			//
			
			if(radioButton82.Checked)
			{
				button51.BackColor= Color.Green;
			}
			if(radioButton81.Checked||radioButton83.Checked||radioButton84.Checked)
				button51.BackColor=Color.Red;
			//
			
			if(radioButton87.Checked)
			{
				button52.BackColor= Color.Green;
			}
			if(radioButton85.Checked||radioButton86.Checked||radioButton88.Checked)
				button52.BackColor=Color.Red;
			//
			
			if(radioButton89.Checked)
			{
				button53.BackColor= Color.Green;
			}
			if(radioButton90.Checked||radioButton91.Checked||radioButton92.Checked)
				button53.BackColor=Color.Red;
			//
			
			if(radioButton94.Checked)
			{
				button54.BackColor= Color.Green;
			}
			if(radioButton93.Checked||radioButton95.Checked||radioButton96.Checked)
				button54.BackColor=Color.Red;
			//
			
			if(radioButton97.Checked)
			{
				button55.BackColor= Color.Green;
			}
			if(radioButton98.Checked||radioButton99.Checked||radioButton100.Checked)
				button55.BackColor=Color.Red;
			//
			
			if(radioButton101.Checked)
			{
				button56.BackColor= Color.Green;
			}
			if(radioButton102.Checked||radioButton103.Checked||radioButton104.Checked)
				button56.BackColor=Color.Red;
			//
			
			if(radioButton108.Checked)
			{
				button57.BackColor= Color.Green;
			}
			if(radioButton105.Checked||radioButton106.Checked||radioButton107.Checked)
				button57.BackColor=Color.Red;
			//
			
			if(radioButton110.Checked)
			{
				button58.BackColor= Color.Green;
			}
			if(radioButton109.Checked||radioButton111.Checked||radioButton112.Checked)
				button58.BackColor=Color.Red;
			//
			
			if(radioButton114.Checked)
			{
				button59.BackColor= Color.Green;
			}
			if(radioButton113.Checked||radioButton115.Checked||radioButton116.Checked)
				button59.BackColor=Color.Red;
			//
			
			if(radioButton118.Checked)
				button60.BackColor=Color.Green;
			if(radioButton117.Checked||radioButton119.Checked||radioButton120.Checked)
				button60.BackColor=Color.Red;
			//
			if(index<ListPanel.Count-1)
			{
				ListPanel[++index].BringToFront();
			}
		}
		void panel1_Paint(object sender, PaintEventArgs e)
		{
			button1.Text="The English is a ________ language in Nigeria";
			radioButton1.Text="(a) First";
			radioButton2.Text="(b) Second";//ans
			radioButton3.Text="(c) Third";
			radioButton4.Text="(d) Fourth";
		}
		void panel2_Paint(object sender, PaintEventArgs e)
		{
			button2.Text="The person listening to or reading a text is known as";
			radioButton5.Text="(a) Writer";
			radioButton7.Text="(b) Listener";
			radioButton6.Text="(c) Audience";//ans
			radioButton8.Text="(d) Instructor";
		}
		void panel3_Paint(object sender, PaintEventArgs e)
		{
			button3.Text="The activity of jotting down important points from a text or lecture is known as";
			radioButton10.Text="(a) Scanning";
			radioButton12.Text="(b) Skimming";//ans
			radioButton11.Text="(c) Jotting";
			radioButton9.Text="(d) None of the above";
		}
		void panel4_Paint(object sender, PaintEventArgs e)
		{
			button4.Text="______ is the reduction in length of a particular piece of writing";
			radioButton13.Text="(a) Reduction";
			radioButton15.Text="(c) Skimming";
			radioButton16.Text="(d) Summary";//ans
			radioButton14.Text="(b) Note-taking";
		}
		void panel5_Paint(object sender, PaintEventArgs e)
		{
			button5.Text="Nigeria is a _____ society";
			radioButton17.Text="(a) Monolingual";
			radioButton19.Text="(b) Bilingual";
			radioButton18.Text="(c) Multilingual";//ans
			radioButton20.Text="(d) None of the above";
		}
		void panel6_Paint(object sender, PaintEventArgs e)
		{
			button6.Text="The English is an _____ language in the world";
			radioButton21.Text="(a) Local";
			radioButton22.Text="(b) Ethnic";
			radioButton23.Text="(c) Regional";
			radioButton24.Text="(d) International";//ans
		}
		void panel7_Paint(object sender, PaintEventArgs e)
		{
			button7.Text="The rise and fall in the voice pitch is known as";
			radioButton25.Text="(a) Intonation";//ans
			radioButton26.Text="(b) Stress";
			radioButton27.Text="(c) Vowels";
			radioButton28.Text="(d) Consonants";
		}
		void panel8_Paint(object sender, PaintEventArgs e)
		{
			button8.Text="We can identify _____ varieties of English in Nigeria";
			radioButton29.Text="(a) Three";//ans
			radioButton30.Text="(b) One";
			radioButton31.Text="(c) Four";
			radioButton32.Text="(d) Two";	
		}
		void panel9_Paint(object sender, PaintEventArgs e)
		{
			button9.Text="The interaction between the reader and the writer is called";
			radioButton33.Text="(a) Writing";
			radioButton34.Text="(b) Speaking";
			radioButton35.Text="(c) Reading";//ans
			radioButton36.Text="(d) Listening";
		}
		void panel10_Paint(object sender, PaintEventArgs e)
		{
			button10.Text="The activity of paying attention to and trying to make meaning from something we hear is known as";
			radioButton37.Text="(a) Speaking";
			radioButton38.Text="(b) Writing";
			radioButton39.Text="(c) Listening";//ans
			radioButton40.Text="(d) Reading";
		}
		void panel11_Paint(object sender, PaintEventArgs e)
		{
			button11.Text="Reading to identify only the main ideas is known as";
			radioButton41.Text="(a) Summarizing";
			radioButton42.Text="(b) Skimming";//ans
			radioButton43.Text="(c) Scanning";
			radioButton44.Text="(d) Comprehension";
		}
		void panel12_Paint(object sender, PaintEventArgs e)
		{
			button12.Text="What is the meaning of the first 'R' in “SQ3R”?";
			radioButton45.Text="(a) refuse";
			radioButton46.Text="(b) report";
			radioButton47.Text="(c) read";//ans
			radioButton48.Text="(d) None of the above";
		}
		void panel13_Paint(object sender, PaintEventArgs e)
		{
			button13.Text="An essay that talks in favour or disfavour of a topic is known as _____";
			radioButton49.Text="(a) Expository";
			radioButton50.Text="(b) Discriptive";
			radioButton51.Text="(c) Argumentative";//ans
			radioButton52.Text="(d) Narrative";
		}
		void panel14_Paint(object sender, PaintEventArgs e)
		{
			button14.Text="Speaking and writing are all directed to the";
			radioButton53.Text="(a) Audience";//ans
			radioButton54.Text="(b) Church";
			radioButton55.Text="(c) University";
			radioButton56.Text="(d) Mosque";
		}
		void panel15_Paint(object sender, PaintEventArgs e)
		{
			button15.Text="What is listening?";
			radioButton57.Text="(a) An act of giving attention to sound";
			radioButton58.Text="(b) Hearing what other people say";
			radioButton59.Text="(c) Hearing and understanding what was said";
			radioButton60.Text="(d) Ability to understand and evaluate what we hear";//ans
		}
		void panel16_Paint(object sender, PaintEventArgs e)
		{
			button16.Text="For listening to be effective we need the following";
			radioButton61.Text="(a) Functional mind";
			radioButton62.Text="(b) Ability to anticipate what the speaker is about to say";
			radioButton63.Text="(c) a & b";//ans
			radioButton64.Text="(d) None of the above";
		}
		void panel17_Paint(object sender, PaintEventArgs e)
		{
			button17.Text="Skimming is a reading exercise that encourages";
			radioButton65.Text="(a) Glancing through rapidly";
			radioButton66.Text="(b) Glancing through slowly";
			radioButton67.Text="(c) Thorough reading";
			radioButton68.Text="(d) Reading quickly";//ans
		}
		void panel18_Paint(object sender, PaintEventArgs e)
		{
			button18.Text="A formal letter has ------- address";
			radioButton69.Text="(a) Three";
			radioButton70.Text="(b) Two";//ans
			radioButton71.Text="(c) Four";
			radioButton72.Text="(d) Five";
		}
		void panel19_Paint(object sender, PaintEventArgs e)
		{
			button19.Text="A formal letter is a letter a ----";
			radioButton73.Text="(a) Friend";
			radioButton74.Text="(b) Person in Authority";//ans
			radioButton75.Text="(c) Brother";
			radioButton76.Text="(d) Parent";
		}
		void panel20_Paint(object sender, PaintEventArgs e)
		{
			button20.Text="A formal letter contains contracted forms of words";
			radioButton77.Text="(a) True";//ans
			radioButton78.Text="(b) False";
			radioButton79.Text="(c) a and b";
			radioButton80.Text="(d) None of the above";
		}
		void panel21_Paint(object sender, PaintEventArgs e)
		{
			button21.Text="What does the 'S' in SQ3R mean";
			radioButton81.Text="(a) Serial";
			radioButton82.Text="(b) Survey";//ans
			radioButton83.Text="(c) Skill";
			radioButton84.Text="(d) Set";
		}
		void panel22_Paint(object sender, PaintEventArgs e)
		{
			button22.Text="A speech made by a speaker but no meant for the audience is known as _____";
			radioButton85.Text="(a) Dialogue";
			radioButton86.Text="(b) Epilogue";
			radioButton87.Text="(c) Monologue";//ans
			radioButton88.Text="(d) Oration";
		}
		void panel23_Paint(object sender, PaintEventArgs e)
		{
			button23.Text="The commonest mode of communication in the university is ______";
			radioButton89.Text="(a) Essay";//ans
			radioButton90.Text="(b) Speech";
			radioButton91.Text="(c) Letter";
			radioButton92.Text="(d) Noise";
		}
		void panel24_Paint(object sender, PaintEventArgs e)
		{
			button24.Text="A group of words that make complete sense is known as ____";
			radioButton93.Text="(a) Phrase";
			radioButton94.Text="(b) Sentence";//ans
			radioButton95.Text="(c) Paragraph";
			radioButton96.Text="(d) Essay";
		}
		void panel25_Paint(object sender, PaintEventArgs e)
		{
			button25.Text="In grammar when two independent clauses are joined together by conjunctions we have _____ sentence";
			radioButton97.Text="(a) Compound";//ans
			radioButton98.Text="(b) Complex";
			radioButton99.Text="(c) Simple";
			radioButton100.Text="(d) Sentence";
		}
		void panel26_Paint(object sender, PaintEventArgs e)
		{
			button26.Text="A communication that goes from one department of an organisation to another is called ____";
			radioButton101.Text="(a) Memo";//ans
			radioButton102.Text="(b) News";
			radioButton103.Text="(c) Letter";
			radioButton104.Text="(d) Speech";
	
		}
		void panel27_Paint(object sender, PaintEventArgs e)
		{
			button27.Text="Below ____ is said to be a poor reading speed";
			radioButton105.Text="(a) 100 Words";
			radioButton106.Text="(b) 150 Words";
			radioButton107.Text="(c) 200 Words";
			radioButton108.Text="(d) 250 Words";//ans
		}
		void panel28_Paint(object sender, PaintEventArgs e)
		{
			button28.Text="_____option from clipboard is used to move data from one place to another in a document";
			radioButton109.Text="(a) Second Langauge";
			radioButton110.Text="(b) First Language";//ans
			radioButton111.Text="(c) Lingua Franca";
			radioButton112.Text="(d) Multiple Language";
		}
		void panel29_Paint(object sender, PaintEventArgs e)
		{
			button29.Text="To get to the ‘Symbol’ dialog box, click on the 	menu and choose ‘Symbol’";
			radioButton113.Text="(a) Insert";
			radioButton114.Text="(b) Format";//ans
			radioButton115.Text="(c) Tools";
			radioButton116.Text="(d) Table";
		}
		void panel30_Paint(object sender, PaintEventArgs e)
		{
			button30.Text="From which menu you can insert Header and Footer?";
			radioButton117.Text="(a) Insert Menu";//ans
			radioButton118.Text="(b) Tools Menu";
			radioButton119.Text="(c) View Menu";
			radioButton120.Text="(d) Format menu";
		}
		void button55_Click(object sender, EventArgs e)
		{
	
		}
		void button60_Click(object sender, EventArgs e)
		{
	
		}
	}
}
