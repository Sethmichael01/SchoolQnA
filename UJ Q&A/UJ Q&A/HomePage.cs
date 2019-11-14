/*
 * Created by SharpDevelop.
 * User: user
 * Date: 6/4/2019
 * Time: 8:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UJ_Q_A
{
	/// <summary>
	/// Description of HomePage.
	/// </summary>
	public partial class HomePage : Form
	{
		public HomePage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void button3_Click(object sender, EventArgs e)
		{
			GST101 gst101 = new GST101();
			gst101.Show();
			this.Hide();
		}
	}
}
