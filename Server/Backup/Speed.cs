//Файл Speed.cs
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication2
{
	public class Speed : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelSr;
		private System.Windows.Forms.Label labelM;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar trackBarSpeed;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.ComponentModel.Container components = null;

		private Int32 gameSpeed;

		public Speed()
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
		public Int32 mySpeed
		{
			get {return trackBarSpeed.Maximum + 50 - gameSpeed;}
			set 
			{
				trackBarSpeed.Value = trackBarSpeed.Maximum + 50 - value;
				gameSpeed = trackBarSpeed.Maximum + 50 - value;
			}
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelSr = new System.Windows.Forms.Label();
			this.labelM = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.trackBarSpeed = new System.Windows.Forms.TrackBar();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
			this.SuspendLayout();
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(328, 72);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(24, 16);
			this.label19.TabIndex = 45;
			this.label19.Text = "15";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(312, 72);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(24, 16);
			this.label18.TabIndex = 44;
			this.label18.Text = "14";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(288, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(24, 16);
			this.label17.TabIndex = 43;
			this.label17.Text = "13";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(264, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(24, 16);
			this.label16.TabIndex = 42;
			this.label16.Text = "12";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(240, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(24, 16);
			this.label15.TabIndex = 41;
			this.label15.Text = "11";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(216, 72);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(24, 16);
			this.label14.TabIndex = 40;
			this.label14.Text = "10";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(200, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(8, 16);
			this.label13.TabIndex = 39;
			this.label13.Text = "9";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(176, 72);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(8, 16);
			this.label12.TabIndex = 38;
			this.label12.Text = "8";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(152, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(8, 16);
			this.label11.TabIndex = 37;
			this.label11.Text = "7";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(128, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(8, 16);
			this.label10.TabIndex = 36;
			this.label10.Text = "6";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(104, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(8, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "5";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(80, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(8, 16);
			this.label8.TabIndex = 34;
			this.label8.Text = "4";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(56, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(8, 16);
			this.label7.TabIndex = 33;
			this.label7.Text = "3";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(8, 16);
			this.label6.TabIndex = 32;
			this.label6.Text = "2";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(8, 16);
			this.label5.TabIndex = 31;
			this.label5.Text = "1";
			// 
			// labelB
			// 
			this.labelB.Location = new System.Drawing.Point(296, 96);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(48, 23);
			this.labelB.TabIndex = 30;
			this.labelB.Text = "Быстро";
			// 
			// labelSr
			// 
			this.labelSr.Location = new System.Drawing.Point(160, 96);
			this.labelSr.Name = "labelSr";
			this.labelSr.Size = new System.Drawing.Size(48, 23);
			this.labelSr.TabIndex = 29;
			this.labelSr.Text = "Средне";
			// 
			// labelM
			// 
			this.labelM.Location = new System.Drawing.Point(16, 96);
			this.labelM.Name = "labelM";
			this.labelM.Size = new System.Drawing.Size(64, 23);
			this.labelM.TabIndex = 28;
			this.labelM.Text = "Медленно";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 27;
			this.label1.Text = "Выберите скорость игры:";
			// 
			// trackBarSpeed
			// 
			this.trackBarSpeed.Location = new System.Drawing.Point(8, 32);
			this.trackBarSpeed.Maximum = 1050;
			this.trackBarSpeed.Name = "trackBarSpeed";
			this.trackBarSpeed.Size = new System.Drawing.Size(344, 42);
			this.trackBarSpeed.SmallChange = 75;
			this.trackBarSpeed.TabIndex = 26;
			this.trackBarSpeed.TickFrequency = 75;
			this.trackBarSpeed.Value = 500;
			this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(80, 120);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(80, 24);
			this.buttonCancel.TabIndex = 50;
			this.buttonCancel.Text = "Cancel";
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(200, 120);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(80, 24);
			this.buttonOk.TabIndex = 49;
			this.buttonOk.Text = "OK";
			// 
			// Speed
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(221)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(352, 151);
			this.ControlBox = false;
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelB);
			this.Controls.Add(this.labelSr);
			this.Controls.Add(this.labelM);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trackBarSpeed);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Speed";
			this.Text = "Скорость";
			((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void trackBarSpeed_Scroll(object sender, System.EventArgs e)
		{
			gameSpeed = trackBarSpeed.Value;
		}
	}
}
