/*
 * Created by SharpDevelop.
 * User: AINUN HUSIN
 * Date: 04/03/2022
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tugas4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tBNama = new System.Windows.Forms.TextBox();
			this.tBNIM = new System.Windows.Forms.TextBox();
			this.tBKelas = new System.Windows.Forms.TextBox();
			this.tBMatkul = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama\r\n";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nim";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(49, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kelas";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(49, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mata Kuliah";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// tBNama
			// 
			this.tBNama.Location = new System.Drawing.Point(294, 48);
			this.tBNama.Name = "tBNama";
			this.tBNama.Size = new System.Drawing.Size(215, 26);
			this.tBNama.TabIndex = 4;
			// 
			// tBNIM
			// 
			this.tBNIM.Location = new System.Drawing.Point(294, 100);
			this.tBNIM.Name = "tBNIM";
			this.tBNIM.Size = new System.Drawing.Size(215, 26);
			this.tBNIM.TabIndex = 5;
			// 
			// tBKelas
			// 
			this.tBKelas.Location = new System.Drawing.Point(294, 160);
			this.tBKelas.Name = "tBKelas";
			this.tBKelas.Size = new System.Drawing.Size(215, 26);
			this.tBKelas.TabIndex = 6;
			this.tBKelas.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// tBMatkul
			// 
			this.tBMatkul.Location = new System.Drawing.Point(294, 223);
			this.tBMatkul.Name = "tBMatkul";
			this.tBMatkul.Size = new System.Drawing.Size(215, 26);
			this.tBMatkul.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(442, 383);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(283, 42);
			this.button1.TabIndex = 8;
			this.button1.Text = "Klik ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 437);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tBMatkul);
			this.Controls.Add(this.tBKelas);
			this.Controls.Add(this.tBNIM);
			this.Controls.Add(this.tBNama);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "tugas4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tBMatkul;
		private System.Windows.Forms.TextBox tBKelas;
		private System.Windows.Forms.TextBox tBNIM;
		private System.Windows.Forms.TextBox tBNama;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
