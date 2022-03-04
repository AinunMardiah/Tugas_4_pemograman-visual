/*
 * Created by SharpDevelop.
 * User: AINUN HUSIN
 * Date: 04/03/2022
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugas4
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
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		  MessageBox.Show ("Nama : " + this.tBNama.Text  + " NIM : " + this.tBNIM.Text  + " Kelas : " + this.tBKelas.Text  + " Mata Kuliah : " + this.tBMatkul.Text);
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
	}
}
