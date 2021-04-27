using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication2
{
	public class NetParameter : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBoxIp;
		private System.Windows.Forms.RadioButton radioButtonClient;
		private System.Windows.Forms.RadioButton radioButtonServer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelIp;

		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button buttonOK;
		private String myHost;

		public NetParameter()
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
			this.labelIp = new System.Windows.Forms.Label();
			this.textBoxIp = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.radioButtonClient = new System.Windows.Forms.RadioButton();
			this.radioButtonServer = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelIp
			// 
			this.labelIp.Enabled = false;
			this.labelIp.Location = new System.Drawing.Point(8, 64);
			this.labelIp.Name = "labelIp";
			this.labelIp.Size = new System.Drawing.Size(96, 16);
			this.labelIp.TabIndex = 0;
			this.labelIp.Text = "IP-адрес сервера";
			// 
			// textBoxIp
			// 
			this.textBoxIp.Enabled = false;
			this.textBoxIp.Location = new System.Drawing.Point(104, 64);
			this.textBoxIp.Name = "textBoxIp";
			this.textBoxIp.Size = new System.Drawing.Size(80, 20);
			this.textBoxIp.TabIndex = 2;
			this.textBoxIp.Text = "";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(104, 96);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(16, 96);
			this.button2.Name = "button2";
			this.button2.TabIndex = 4;
			this.button2.Text = "Cancel";
			// 
			// radioButtonClient
			// 
			this.radioButtonClient.Location = new System.Drawing.Point(96, 16);
			this.radioButtonClient.Name = "radioButtonClient";
			this.radioButtonClient.Size = new System.Drawing.Size(64, 24);
			this.radioButtonClient.TabIndex = 1;
			this.radioButtonClient.Text = "Клиент";
			this.radioButtonClient.CheckedChanged += new System.EventHandler(this.radioButtonClient_CheckedChanged);
			// 
			// radioButtonServer
			// 
			this.radioButtonServer.Checked = true;
			this.radioButtonServer.Location = new System.Drawing.Point(16, 16);
			this.radioButtonServer.Name = "radioButtonServer";
			this.radioButtonServer.Size = new System.Drawing.Size(64, 24);
			this.radioButtonServer.TabIndex = 0;
			this.radioButtonServer.TabStop = true;
			this.radioButtonServer.Text = "Сервер";
			this.radioButtonServer.CheckedChanged += new System.EventHandler(this.radioButtonServer_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonClient);
			this.groupBox1.Controls.Add(this.radioButtonServer);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 48);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Компьютер";
			// 
			// NetParameter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(194, 125);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.textBoxIp);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.labelIp);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NetParameter";
			this.Text = "Сетевые настройки";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public String Host
		{
			get { return myHost;}
			set{ myHost = value;}
		}
		private void radioButtonServer_CheckedChanged(object sender, System.EventArgs e)
		{
			labelIp.Enabled = false;
			textBoxIp.Enabled = false;
		}

		private void radioButtonClient_CheckedChanged(object sender, System.EventArgs e)
		{
			labelIp.Enabled = true;
			textBoxIp.Enabled = true;
		}

		private void buttonOK_Click(object sender, System.EventArgs e)
		{
			myHost = textBoxIp.Text;
		}
	}
}
