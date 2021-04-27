using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication2
{
	public class Rules : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOkRules;
		private System.Windows.Forms.TextBox textBox1;
		private System.ComponentModel.Container components = null;

		public Rules()
		{
			InitializeComponent();
		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOkRules = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOkRules
			// 
			this.btnOkRules.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOkRules.Location = new System.Drawing.Point(192, 64);
			this.btnOkRules.Name = "btnOkRules";
			this.btnOkRules.Size = new System.Drawing.Size(88, 24);
			this.btnOkRules.TabIndex = 0;
			this.btnOkRules.Text = "OK";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Khaki;
			this.textBox1.Location = new System.Drawing.Point(8, 8);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(272, 48);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Для победы нужно уничтожить всех лыжников.";
			// 
			// Rules
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(290, 95);
			this.ControlBox = false;
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnOkRules);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Rules";
			this.Text = "Правила";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
