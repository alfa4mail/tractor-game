using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsApplication2
{
	public class Designation : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOKDesignation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox picturePlayer;
		private System.Windows.Forms.PictureBox pictureSkier;
		private System.Windows.Forms.PictureBox pictureBomb;
		private System.Windows.Forms.PictureBox pictureStone;
		private System.Windows.Forms.PictureBox pictureSoil;
		private System.Windows.Forms.PictureBox pictureBrick;
		private System.Windows.Forms.PictureBox pictureBlueBrick;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.Container components = null;

		public Designation()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Designation));
			this.btnOKDesignation = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.picturePlayer = new System.Windows.Forms.PictureBox();
			this.pictureSkier = new System.Windows.Forms.PictureBox();
			this.pictureBomb = new System.Windows.Forms.PictureBox();
			this.pictureStone = new System.Windows.Forms.PictureBox();
			this.pictureSoil = new System.Windows.Forms.PictureBox();
			this.pictureBrick = new System.Windows.Forms.PictureBox();
			this.pictureBlueBrick = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOKDesignation
			// 
			this.btnOKDesignation.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOKDesignation.Location = new System.Drawing.Point(24, 304);
			this.btnOKDesignation.Name = "btnOKDesignation";
			this.btnOKDesignation.Size = new System.Drawing.Size(88, 32);
			this.btnOKDesignation.TabIndex = 0;
			this.btnOKDesignation.Text = "OK";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(48, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "Трава";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(48, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Красный кирпич";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 16);
			this.label7.TabIndex = 14;
			this.label7.Text = "Синий кирпич";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(48, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 16);
			this.label8.TabIndex = 15;
			this.label8.Text = "Пустое место";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 264);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 40);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(48, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Белый игрок";
			// 
			// picturePlayer
			// 
			this.picturePlayer.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayer.Image")));
			this.picturePlayer.Location = new System.Drawing.Point(8, 8);
			this.picturePlayer.Name = "picturePlayer";
			this.picturePlayer.Size = new System.Drawing.Size(32, 32);
			this.picturePlayer.TabIndex = 1;
			this.picturePlayer.TabStop = false;
			// 
			// pictureSkier
			// 
			this.pictureSkier.Image = ((System.Drawing.Image)(resources.GetObject("pictureSkier.Image")));
			this.pictureSkier.Location = new System.Drawing.Point(8, 72);
			this.pictureSkier.Name = "pictureSkier";
			this.pictureSkier.Size = new System.Drawing.Size(32, 32);
			this.pictureSkier.TabIndex = 2;
			this.pictureSkier.TabStop = false;
			// 
			// pictureBomb
			// 
			this.pictureBomb.Image = ((System.Drawing.Image)(resources.GetObject("pictureBomb.Image")));
			this.pictureBomb.Location = new System.Drawing.Point(8, 104);
			this.pictureBomb.Name = "pictureBomb";
			this.pictureBomb.Size = new System.Drawing.Size(32, 32);
			this.pictureBomb.TabIndex = 3;
			this.pictureBomb.TabStop = false;
			// 
			// pictureStone
			// 
			this.pictureStone.Image = ((System.Drawing.Image)(resources.GetObject("pictureStone.Image")));
			this.pictureStone.Location = new System.Drawing.Point(8, 136);
			this.pictureStone.Name = "pictureStone";
			this.pictureStone.Size = new System.Drawing.Size(32, 32);
			this.pictureStone.TabIndex = 4;
			this.pictureStone.TabStop = false;
			// 
			// pictureSoil
			// 
			this.pictureSoil.Image = ((System.Drawing.Image)(resources.GetObject("pictureSoil.Image")));
			this.pictureSoil.Location = new System.Drawing.Point(8, 168);
			this.pictureSoil.Name = "pictureSoil";
			this.pictureSoil.Size = new System.Drawing.Size(32, 32);
			this.pictureSoil.TabIndex = 5;
			this.pictureSoil.TabStop = false;
			// 
			// pictureBrick
			// 
			this.pictureBrick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBrick.Image")));
			this.pictureBrick.Location = new System.Drawing.Point(8, 200);
			this.pictureBrick.Name = "pictureBrick";
			this.pictureBrick.Size = new System.Drawing.Size(32, 32);
			this.pictureBrick.TabIndex = 6;
			this.pictureBrick.TabStop = false;
			// 
			// pictureBlueBrick
			// 
			this.pictureBlueBrick.Image = ((System.Drawing.Image)(resources.GetObject("pictureBlueBrick.Image")));
			this.pictureBlueBrick.Location = new System.Drawing.Point(8, 232);
			this.pictureBlueBrick.Name = "pictureBlueBrick";
			this.pictureBlueBrick.Size = new System.Drawing.Size(32, 32);
			this.pictureBlueBrick.TabIndex = 7;
			this.pictureBlueBrick.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Оранжевый игрок";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Лыжник";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Бомба";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(48, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Камень";
			// 
			// Designation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(154, 351);
			this.ControlBox = false;
			this.Controls.Add(this.label9);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBlueBrick);
			this.Controls.Add(this.pictureBrick);
			this.Controls.Add(this.pictureSoil);
			this.Controls.Add(this.pictureStone);
			this.Controls.Add(this.pictureBomb);
			this.Controls.Add(this.pictureSkier);
			this.Controls.Add(this.picturePlayer);
			this.Controls.Add(this.btnOKDesignation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Designation";
			this.Text = "Обозначения";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
