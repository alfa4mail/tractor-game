//Файл CreateNewMap.cs
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication2
{
	public class CreateNewMap : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label labelSizeOfMap;
		private System.Windows.Forms.TrackBar trackBarX;
		private System.Windows.Forms.TrackBar trackBarY;
		private System.Windows.Forms.CheckBox checkBoxDrawBorder;
		private System.Windows.Forms.Label labelChoose;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelSize;

		private System.ComponentModel.Container components = null;
		private Int32 coordinateX;
		private Int32 coordinateY;

		public CreateNewMap()
		{
			InitializeComponent();
			InvalidateSize();
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.trackBarX = new System.Windows.Forms.TrackBar();
			this.trackBarY = new System.Windows.Forms.TrackBar();
			this.labelChoose = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.labelY = new System.Windows.Forms.Label();
			this.labelSize = new System.Windows.Forms.Label();
			this.labelSizeOfMap = new System.Windows.Forms.Label();
			this.checkBoxDrawBorder = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(144, 192);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(56, 192);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			// 
			// trackBarX
			// 
			this.trackBarX.Location = new System.Drawing.Point(24, 72);
			this.trackBarX.Maximum = 39;
			this.trackBarX.Minimum = 5;
			this.trackBarX.Name = "trackBarX";
			this.trackBarX.Size = new System.Drawing.Size(272, 42);
			this.trackBarX.TabIndex = 4;
			this.trackBarX.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarX.Value = 5;
			this.trackBarX.Scroll += new System.EventHandler(this.trackBarX_Scroll);
			// 
			// trackBarY
			// 
			this.trackBarY.Location = new System.Drawing.Point(24, 120);
			this.trackBarY.Maximum = 26;
			this.trackBarY.Minimum = 5;
			this.trackBarY.Name = "trackBarY";
			this.trackBarY.Size = new System.Drawing.Size(272, 42);
			this.trackBarY.TabIndex = 5;
			this.trackBarY.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarY.Value = 5;
			this.trackBarY.Scroll += new System.EventHandler(this.trackBarY_Scroll);
			// 
			// labelChoose
			// 
			this.labelChoose.Location = new System.Drawing.Point(8, 40);
			this.labelChoose.Name = "labelChoose";
			this.labelChoose.Size = new System.Drawing.Size(288, 32);
			this.labelChoose.TabIndex = 6;
			this.labelChoose.Text = "Выберите  размер игрового поля по горизонтали(X) и вертикали(Y):";
			// 
			// labelX
			// 
			this.labelX.Location = new System.Drawing.Point(8, 88);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(16, 16);
			this.labelX.TabIndex = 7;
			this.labelX.Text = "X";
			// 
			// labelY
			// 
			this.labelY.Location = new System.Drawing.Point(8, 136);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(16, 16);
			this.labelY.TabIndex = 8;
			this.labelY.Text = "Y";
			// 
			// labelSize
			// 
			this.labelSize.Location = new System.Drawing.Point(8, 168);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(136, 16);
			this.labelSize.TabIndex = 9;
			this.labelSize.Text = "Размеры игрового поля:";
			// 
			// labelSizeOfMap
			// 
			this.labelSizeOfMap.Location = new System.Drawing.Point(152, 168);
			this.labelSizeOfMap.Name = "labelSizeOfMap";
			this.labelSizeOfMap.Size = new System.Drawing.Size(80, 16);
			this.labelSizeOfMap.TabIndex = 10;
			// 
			// checkBoxDrawBorder
			// 
			this.checkBoxDrawBorder.Checked = true;
			this.checkBoxDrawBorder.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxDrawBorder.Location = new System.Drawing.Point(8, 8);
			this.checkBoxDrawBorder.Name = "checkBoxDrawBorder";
			this.checkBoxDrawBorder.Size = new System.Drawing.Size(296, 24);
			this.checkBoxDrawBorder.TabIndex = 11;
			this.checkBoxDrawBorder.Text = "Автоматически нарисовать границы игрового поля";
			this.checkBoxDrawBorder.CheckedChanged += new System.EventHandler(this.checkBoxDrawBorder_CheckedChanged);
			// 
			// CreateNewMap
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(246)), ((System.Byte)(221)), ((System.Byte)(224)));
			this.ClientSize = new System.Drawing.Size(306, 223);
			this.ControlBox = false;
			this.Controls.Add(this.checkBoxDrawBorder);
			this.Controls.Add(this.labelSizeOfMap);
			this.Controls.Add(this.labelSize);
			this.Controls.Add(this.labelY);
			this.Controls.Add(this.labelX);
			this.Controls.Add(this.labelChoose);
			this.Controls.Add(this.trackBarY);
			this.Controls.Add(this.trackBarX);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CreateNewMap";
			this.Text = "Параметры новой карты";
			((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		public Int32 CoordinateX
		{
			get {return coordinateX;}
			set {coordinateX = value;}
		}
		public Int32 CoordinateY
		{
			get {return coordinateY;}
			set {coordinateY = value;}
		}
		public Boolean DrawBorder
		{
			get {return checkBoxDrawBorder.Checked;}
			set {checkBoxDrawBorder.Checked = value;}
		}
		private void InvalidateSize()
		{
			labelSizeOfMap.Text = "(" + trackBarX.Value + ", " + trackBarY.Value + ")";
		}

		private void trackBarX_Scroll(object sender, System.EventArgs e)
		{
			InvalidateSize();
		}

		private void trackBarY_Scroll(object sender, System.EventArgs e)
		{
			InvalidateSize();
		}

		private void checkBoxDrawBorder_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBoxDrawBorder.Checked == true)
			{
				labelChoose.Visible = true;
				trackBarX.Visible = true;
				trackBarY.Visible = true;
				labelX.Visible = true;
				labelY.Visible = true;
				labelSize.Visible = true;
				labelSizeOfMap.Visible = true;
			}
			else
			{
				labelChoose.Visible = false;
				trackBarX.Visible = false;
				trackBarY.Visible = false;
				labelX.Visible = false;
				labelY.Visible = false;
				labelSize.Visible = false;
				labelSizeOfMap.Visible = false;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			CoordinateX = trackBarX.Value;
			CoordinateY = trackBarY.Value;
		
		}
	}
}
