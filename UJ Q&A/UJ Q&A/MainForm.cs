/*
 * Created by SharpDevelop.
 * User: user
 * Date: 5/31/2019
 * Time: 7:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace UJ_Q_A
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void button2_Click(object sender, EventArgs e)
		{
			if(checkBox1.Checked && (textBox1.Text=="pass"||textBox1.Text=="p"))
			{
				Properties.Settings1.Default.Password = textBox1.Text;
				Properties.Settings1.Default.UserName = textBox2.Text;
				Properties.Settings1.Default.Save();
	    		Properties.Settings1.Default.Save();
	    		HomePage f1 = new HomePage();
	    		f1.Show();
	    		this.Hide();
			}
			else if(textBox1.Text=="pass"||textBox1.Text=="p")
			{
				HomePage f1 = new HomePage();
				f1.Show();
				this.Hide();
			}
	
		}
		void MainForm_Load(object sender, EventArgs e)
		{
			textBox1.Text = Properties.Settings1.Default.Password;
			textBox2.Text = Properties.Settings1.Default.UserName;
		}
		void textBox1_TextChanged(object sender, EventArgs e)
		{
	
		}
		void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
	
		}
	}
}
