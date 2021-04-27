//Файл GameType.cs
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication2
{
	public class GameType : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton rButtonOne;
		private System.Windows.Forms.RadioButton rButtonMany;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.GroupBox groupBoxType;
		private System.ComponentModel.Container components = null;
		private Boolean gameType;

		public GameType()
		{
			InitializeComponent();
			gameType = false;
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
		public Boolean myType
		{
			get {return gameType;}
			set {
				rButtonOne.Checked = !value;
				rButtonMany.Checked = value;
				gameType = value;
			}
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.groupBoxType = new System.Windows.Forms.GroupBox();
			this.rButtonMany = new System.Windows.Forms.RadioButton();
			this.rButtonOne = new System.Windows.Forms.RadioButton();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxType.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxType
			// 
			this.groupBoxType.Controls.Add(this.rButtonMany);
			this.groupBoxType.Controls.Add(this.rButtonOne);
			this.groupBoxType.Location = new System.Drawing.Point(8, 8);
			this.groupBoxType.Name = "groupBoxType";
			this.groupBoxType.Size = new System.Drawing.Size(192, 72);
			this.groupBoxType.TabIndex = 0;
			this.groupBoxType.TabStop = false;
			this.groupBoxType.Text = "Выберите тип игры";
			// 
			// rButtonMany
			// 
			this.rButtonMany.Location = new System.Drawing.Point(16, 48);
			this.rButtonMany.Name = "rButtonMany";
			this.rButtonMany.Size = new System.Drawing.Size(96, 16);
			this.rButtonMany.TabIndex = 1;
			this.rButtonMany.Text = "Сетевая игра";
			this.rButtonMany.CheckedChanged += new System.EventHandler(this.rButtonMany_CheckedChanged);
			// 
			// rButtonOne
			// 
			this.rButtonOne.Checked = true;
			this.rButtonOne.Location = new System.Drawing.Point(16, 24);
			this.rButtonOne.Name = "rButtonOne";
			this.rButtonOne.Size = new System.Drawing.Size(112, 16);
			this.rButtonOne.TabIndex = 0;
			this.rButtonOne.TabStop = true;
			this.rButtonOne.Text = "Одиночная игра";
			this.rButtonOne.CheckedChanged += new System.EventHandler(this.rButtonOne_CheckedChanged);
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(112, 96);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(80, 24);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "OK";
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(16, 96);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 24);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			// 
			// GameType
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(221)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(210, 135);
			this.ControlBox = false;
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.groupBoxType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GameType";
			this.Text = "Тип игры";
			this.groupBoxType.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void rButtonOne_CheckedChanged(object sender, System.EventArgs e)
		{
			gameType = false;
		
		}

		private void rButtonMany_CheckedChanged(object sender, System.EventArgs e)
		{
			gameType = true;
		}
	}
}
