using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Net.Sockets;
namespace WindowsApplication2
{
	[Serializable]
	public class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItemOpen;
		private System.Windows.Forms.MenuItem menuItemSaveAs;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.MenuItem menuItemCreate;
		private System.Windows.Forms.MenuItem menuItemPlayer;
		private System.Windows.Forms.MenuItem menuItemSkier;
		private System.Windows.Forms.MenuItem menuItemBomb;
		private System.Windows.Forms.MenuItem menuItemStone;
		private System.Windows.Forms.MenuItem menuItemSoil;
		private System.Windows.Forms.MenuItem menuItemBrick;
		private System.Windows.Forms.MenuItem menuItemBlueBrick;
		private System.Windows.Forms.MenuItem menuItemSkierLeft;
		private System.Windows.Forms.MenuItem menuItemSkierRight;
		private System.Windows.Forms.MenuItem menuItemSkierUp;
		private System.Windows.Forms.MenuItem menuItemDown;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItemDesignation;
		private System.Windows.Forms.MenuItem menuItemRules;
		private System.Windows.Forms.MenuItem menuItemPlayer1;
		private System.Windows.Forms.MenuItem menuItemPlayer2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MenuItem menuItemParam;
		private System.Windows.Forms.MenuItem menuItemNet;
		
		private Stones stoneList = new Stones();
		private Skiers skiList = new Skiers();
		private Bricks brickList = new Bricks();
		private Bombs bombList = new Bombs();
		private Soils soilList = new Soils();
		private BlueBricks blueBrickList = new BlueBricks();

		private Player trac;
		private Player trac2;
		private PlaceList List;
		private Boolean IsCreateNewMap;
		private String SelectedItem;
		private Boolean IfCreatureMoving = false;
		private Boolean IfPlayerMoving = true;
		private Boolean PlayerNowMoving = false;
		private String result;
		private TcpListener listener;
		private Socket soc;
		private NetworkStream ns;
		private StreamReader r;
		private System.Windows.Forms.MenuItem menuItemGameType;
		private Thread backgroundConnection;
		private System.Windows.Forms.MenuItem menuItemSpeed;
		private Boolean gameType;
		
		public MainForm()
		{
			InitializeComponent();
			trac = new Player(0,0,"NULL.bmp");
			trac2 = new Player(0,0,"NULL.bmp");

			gameType = false;
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItemOpen = new System.Windows.Forms.MenuItem();
			this.menuItemSaveAs = new System.Windows.Forms.MenuItem();
			this.menuExit = new System.Windows.Forms.MenuItem();
			this.menuItemParam = new System.Windows.Forms.MenuItem();
			this.menuItemSpeed = new System.Windows.Forms.MenuItem();
			this.menuItemGameType = new System.Windows.Forms.MenuItem();
			this.menuItemNet = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItemCreate = new System.Windows.Forms.MenuItem();
			this.menuItemPlayer = new System.Windows.Forms.MenuItem();
			this.menuItemPlayer1 = new System.Windows.Forms.MenuItem();
			this.menuItemPlayer2 = new System.Windows.Forms.MenuItem();
			this.menuItemSkier = new System.Windows.Forms.MenuItem();
			this.menuItemSkierLeft = new System.Windows.Forms.MenuItem();
			this.menuItemSkierRight = new System.Windows.Forms.MenuItem();
			this.menuItemSkierUp = new System.Windows.Forms.MenuItem();
			this.menuItemDown = new System.Windows.Forms.MenuItem();
			this.menuItemBomb = new System.Windows.Forms.MenuItem();
			this.menuItemStone = new System.Windows.Forms.MenuItem();
			this.menuItemSoil = new System.Windows.Forms.MenuItem();
			this.menuItemBrick = new System.Windows.Forms.MenuItem();
			this.menuItemBlueBrick = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItemRules = new System.Windows.Forms.MenuItem();
			this.menuItemDesignation = new System.Windows.Forms.MenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItemParam,
																					  this.menuItem5,
																					  this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemOpen,
																					  this.menuItemSaveAs,
																					  this.menuExit});
			this.menuItem1.Text = "Файл";
			// 
			// menuItemOpen
			// 
			this.menuItemOpen.Index = 0;
			this.menuItemOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItemOpen.Text = "Открыть";
			this.menuItemOpen.Click += new System.EventHandler(this.On_Open);
			// 
			// menuItemSaveAs
			// 
			this.menuItemSaveAs.Index = 1;
			this.menuItemSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItemSaveAs.Text = "Сохранить как";
			this.menuItemSaveAs.Click += new System.EventHandler(this.On_Save_as);
			// 
			// menuExit
			// 
			this.menuExit.Index = 2;
			this.menuExit.Text = "Выход";
			this.menuExit.Click += new System.EventHandler(this.On_Exit);
			// 
			// menuItemParam
			// 
			this.menuItemParam.Index = 1;
			this.menuItemParam.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItemSpeed,
																						  this.menuItemGameType,
																						  this.menuItemNet});
			this.menuItemParam.Text = "Параметры";
			// 
			// menuItemSpeed
			// 
			this.menuItemSpeed.Index = 0;
			this.menuItemSpeed.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItemSpeed.Text = "Скорость";
			this.menuItemSpeed.Click += new System.EventHandler(this.menuItemSpeed_Click);
			// 
			// menuItemGameType
			// 
			this.menuItemGameType.Index = 1;
			this.menuItemGameType.Shortcut = System.Windows.Forms.Shortcut.CtrlT;
			this.menuItemGameType.Text = "Тип игры";
			this.menuItemGameType.Click += new System.EventHandler(this.menuItemGameType_Click);
			// 
			// menuItemNet
			// 
			this.menuItemNet.Enabled = false;
			this.menuItemNet.Index = 2;
			this.menuItemNet.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuItemNet.Text = "Сеть";
			this.menuItemNet.Click += new System.EventHandler(this.menuItemNet_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItemCreate,
																					  this.menuItemPlayer,
																					  this.menuItemSkier,
																					  this.menuItemBomb,
																					  this.menuItemStone,
																					  this.menuItemSoil,
																					  this.menuItemBrick,
																					  this.menuItemBlueBrick});
			this.menuItem5.Text = "Редактор карт";
			// 
			// menuItemCreate
			// 
			this.menuItemCreate.Index = 0;
			this.menuItemCreate.Shortcut = System.Windows.Forms.Shortcut.CtrlM;
			this.menuItemCreate.Text = "Создать новую карту";
			this.menuItemCreate.Click += new System.EventHandler(this.On_CreateNewMap);
			// 
			// menuItemPlayer
			// 
			this.menuItemPlayer.Enabled = false;
			this.menuItemPlayer.Index = 1;
			this.menuItemPlayer.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.menuItemPlayer1,
																						   this.menuItemPlayer2});
			this.menuItemPlayer.Text = "Игрок";
			// 
			// menuItemPlayer1
			// 
			this.menuItemPlayer1.Index = 0;
			this.menuItemPlayer1.Text = "Оранжевый игрок";
			this.menuItemPlayer1.Click += new System.EventHandler(this.menuItemPlayer1_Click);
			// 
			// menuItemPlayer2
			// 
			this.menuItemPlayer2.Index = 1;
			this.menuItemPlayer2.Text = "Белый игрок";
			this.menuItemPlayer2.Click += new System.EventHandler(this.menuItemPlayer2_Click);
			// 
			// menuItemSkier
			// 
			this.menuItemSkier.Enabled = false;
			this.menuItemSkier.Index = 2;
			this.menuItemSkier.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.menuItemSkierLeft,
																						  this.menuItemSkierRight,
																						  this.menuItemSkierUp,
																						  this.menuItemDown});
			this.menuItemSkier.Text = "Лыжник";
			// 
			// menuItemSkierLeft
			// 
			this.menuItemSkierLeft.Index = 0;
			this.menuItemSkierLeft.Shortcut = System.Windows.Forms.Shortcut.Ctrl1;
			this.menuItemSkierLeft.Text = "Лыжник (смотрит влево)";
			this.menuItemSkierLeft.Click += new System.EventHandler(this.menuItemSkierLeft_Click);
			// 
			// menuItemSkierRight
			// 
			this.menuItemSkierRight.Index = 1;
			this.menuItemSkierRight.Shortcut = System.Windows.Forms.Shortcut.Ctrl2;
			this.menuItemSkierRight.Text = "Лыжник (смотрит вправо)";
			this.menuItemSkierRight.Click += new System.EventHandler(this.menuItemSkierRight_Click);
			// 
			// menuItemSkierUp
			// 
			this.menuItemSkierUp.Index = 2;
			this.menuItemSkierUp.Shortcut = System.Windows.Forms.Shortcut.Ctrl3;
			this.menuItemSkierUp.Text = "Лыжник смотрит вверх)";
			this.menuItemSkierUp.Click += new System.EventHandler(this.menuItemSkierUp_Click);
			// 
			// menuItemDown
			// 
			this.menuItemDown.Index = 3;
			this.menuItemDown.Shortcut = System.Windows.Forms.Shortcut.Ctrl4;
			this.menuItemDown.Text = "Лыжник (смотрит вниз)";
			this.menuItemDown.Click += new System.EventHandler(this.menuItemDown_Click);
			// 
			// menuItemBomb
			// 
			this.menuItemBomb.Enabled = false;
			this.menuItemBomb.Index = 3;
			this.menuItemBomb.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftB;
			this.menuItemBomb.Text = "Бомба";
			this.menuItemBomb.Click += new System.EventHandler(this.menuItemBomb_Click);
			// 
			// menuItemStone
			// 
			this.menuItemStone.Enabled = false;
			this.menuItemStone.Index = 4;
			this.menuItemStone.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
			this.menuItemStone.Text = "Камень";
			this.menuItemStone.Click += new System.EventHandler(this.menuItemStone_Click);
			// 
			// menuItemSoil
			// 
			this.menuItemSoil.Enabled = false;
			this.menuItemSoil.Index = 5;
			this.menuItemSoil.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftG;
			this.menuItemSoil.Text = "Трава";
			this.menuItemSoil.Click += new System.EventHandler(this.menuItemSoil_Click);
			// 
			// menuItemBrick
			// 
			this.menuItemBrick.Enabled = false;
			this.menuItemBrick.Index = 6;
			this.menuItemBrick.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR;
			this.menuItemBrick.Text = "Красный кирпич";
			this.menuItemBrick.Click += new System.EventHandler(this.menuItemBrick_Click);
			// 
			// menuItemBlueBrick
			// 
			this.menuItemBlueBrick.Enabled = false;
			this.menuItemBlueBrick.Index = 7;
			this.menuItemBlueBrick.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftL;
			this.menuItemBlueBrick.Text = "Синий кирпич";
			this.menuItemBlueBrick.Click += new System.EventHandler(this.menuItemBlueBrick_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItemRules,
																					  this.menuItemDesignation});
			this.menuItem2.Text = "Справка";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.F1;
			this.menuItem3.Text = "Управление";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItemRules
			// 
			this.menuItemRules.Index = 1;
			this.menuItemRules.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.menuItemRules.Text = "Правила";
			this.menuItemRules.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItemDesignation
			// 
			this.menuItemDesignation.Index = 2;
			this.menuItemDesignation.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.menuItemDesignation.Text = "Обозначения";
			this.menuItemDesignation.Click += new System.EventHandler(this.menuItemDesignation_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 350;
			this.timer1.Tick += new System.EventHandler(this.OnTick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(204)), ((System.Byte)(204)));
			this.ClientSize = new System.Drawing.Size(922, 575);
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "Tractor_Server";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.On_MouseUp);
			this.Closed += new System.EventHandler(this.On_Closed);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());	
		}

		private void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			trac.Drawing(e);
			trac2.Drawing(e);
			foreach (Skier sk in skiList)
				sk.Drawing(e);
			foreach (Stone st in stoneList)
				st.Drawing(e);
			foreach (Bomb bo in bombList)
				bo.Drawing(e);
			foreach (Brick br in brickList)
				br.Drawing(e);
			foreach (BlueBrick bbr in blueBrickList)
				bbr.Drawing(e);
			foreach (Soil so in soilList)
				so.Drawing(e);
		}

		private void OnTick(object sender, System.EventArgs e)
		{
			if (gameType == true)
			{
				if (IfCreatureMoving == true) 
				{
					timer1.Interval = 900;
					СreatureMoving();
					PlayerNowMoving = false;
					IfPlayerMoving = true;
					backgroundConnection = new Thread(new ThreadStart(this.GetConnection));
					backgroundConnection.Start();
				}
				else timer1.Interval = 50;
			}
			else СreatureMoving();//!!!
		}

		private void OnKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((IsCreateNewMap == false) &&(IfPlayerMoving == true))
			{
				if (gameType == true) IfPlayerMoving = false; //!!!

				if (trac.LIFE <= 0) MessageBox.Show("Game over");
				if (trac.Moving(e, soilList, stoneList,bombList) == true)
				{
					PlayerNowMoving = true;//!

					switch (e.KeyChar.ToString())
					{
						case "a": 
						case "ф":
							InvalidateLeft(trac);
							if ((Map.GetItem(trac.TOP/25, trac.LEFT/25 - 1) == ItemName.Stone) || 
								(Map.GetItem(trac.TOP/25, trac.LEFT/25 - 1) == ItemName.Bomb)) 
								Invalidate(new Rectangle(trac.LEFT - 25, trac.TOP, 25, 25));
							break;
						case "d":
						case "в":
							InvalidateRight(trac);
							if ((Map.GetItem(trac.TOP/25, trac.LEFT/25 + 1) == ItemName.Stone) || 
								(Map.GetItem(trac.TOP/25, trac.LEFT/25 + 1) == ItemName.Bomb)) 
								Invalidate(new Rectangle(trac.LEFT + 25, trac.TOP, 25, 25));
							break;
						case "w":
						case "ц":
							InvalidateUp(trac);
							break;
						case "s":
						case "ы":
							InvalidateDown(trac);
							break;
					}	
				}
				else 
					if ((e.KeyChar.ToString() == "p") || (e.KeyChar.ToString() == "з"))
				{
					if (trac.Direc == Direction.Left) 
					{
						Invalidate(new Rectangle(trac.LEFT-25,trac.TOP,25,25));
						Map.SetItem(trac.TOP/25,trac.LEFT/25 - 1,ItemName.Bomb);
					}
					else if (trac.Direc == Direction.Right)
					{
						Invalidate(new Rectangle(trac.LEFT+25,trac.TOP,25,25));
						Map.SetItem(trac.TOP/25,trac.LEFT/25 + 1,ItemName.Bomb);
					}
					else if (trac.Direc == Direction.Up) 
					{
						Invalidate(new Rectangle(trac.LEFT,trac.TOP-25,25,25));
						Map.SetItem(trac.TOP/25 - 1,trac.LEFT/25,ItemName.Bomb);
					}
					else if (trac.Direc == Direction.Down) 
					{
						Invalidate(new Rectangle(trac.LEFT,trac.TOP+25,25,25));
						Map.SetItem(trac.TOP/25 + 1,trac.LEFT/25,ItemName.Bomb);
					}
				}

				if (Skiers.NumberOfSkiers == 0) MessageBox.Show("YOU WIN");
			}
		}
		private void OtherTracMove(String str)//!!!
		{
			if (trac2.LIFE <= 0) MessageBox.Show("Game over");
			if (trac2.Moving(str, soilList, stoneList,bombList) == true)
			{
				switch (str)
				{
					case "Left": 
						InvalidateLeft(trac2);
						break;
					case "Right":
						InvalidateRight(trac2);
						break;
					case "Up":
						InvalidateUp(trac2);
						break;
					case "Down":
						InvalidateDown(trac2);
						break;
				}	
			}
			else if (str == "Bomb")
			{
				if (trac2.Direc == Direction.Left) 
				{
					Invalidate(new Rectangle(trac2.LEFT-25,trac2.TOP,25,25));
					Map.SetItem(trac2.TOP/25,trac2.LEFT/25 - 1,ItemName.Bomb);
				}
				else if (trac2.Direc == Direction.Right)
				{
					Invalidate(new Rectangle(trac2.LEFT+25,trac2.TOP,25,25));
					Map.SetItem(trac2.TOP/25,trac2.LEFT/25 + 1,ItemName.Bomb);
				}
				else if (trac2.Direc == Direction.Up) 
				{
					Invalidate(new Rectangle(trac2.LEFT,trac2.TOP-25,25,25));
					Map.SetItem(trac2.TOP/25 - 1,trac2.LEFT/25,ItemName.Bomb);
				}
				else if (trac2.Direc == Direction.Down) 
				{
					Invalidate(new Rectangle(trac2.LEFT,trac2.TOP+25,25,25));
					Map.SetItem(trac2.TOP/25 + 1,trac2.LEFT/25,ItemName.Bomb);
				}
			}

			if (Skiers.NumberOfSkiers == 0) MessageBox.Show("YOU WIN");
		}
		private void GetConnection()
		{	
			listener = new TcpListener (8080 );
			listener.Start();
			soc = listener.AcceptSocket();
			ns = new NetworkStream(soc);
			r = new StreamReader(ns);

			String command = r.ReadLine();

			// ходим др игроком
			OtherTracMove(command);

			if (trac.BombNowCreate == true)
			{
				trac.BombNowCreate = false;
				result = "Bomb";
			}
			else if (PlayerNowMoving == true)
			{
				if (trac.Direc == Direction.Left)
					result = "Left";
				else if (trac.Direc == Direction.Right)
					result = "Right";
				else if (trac.Direc == Direction.Up)
					result = "Up";
				if (trac.Direc == Direction.Down)
					result = "Down";
			}

			result += "\r\n";
			Byte[] res = System.Text.Encoding.ASCII.GetBytes(result.ToCharArray());
			soc.Send(res,res.Length,0);
			result = "No\r\n";
			IfPlayerMoving = false;
			IfCreatureMoving = true;
				
			soc.Close();
			listener.Stop ();
		}
		private void СreatureMoving()
		{
			foreach (Skier s in skiList)
			{
				Boolean IsMov = s.Moving(stoneList, bombList);
				if ((s.Direc == Direction.Up) && (IsMov == true)) InvalidateUp(s);
				else if ((s.Direc == Direction.Down) && (IsMov == true)) InvalidateDown(s);
				else if ((s.Direc == Direction.Left) && (IsMov == true)) InvalidateLeft(s);
				else if ((s.Direc == Direction.Right) && (IsMov == true)) InvalidateRight(s);
			}
			StoneMove(stoneList, skiList,brickList);
			BombMove(bombList, skiList,brickList);

			IfCreatureMoving = false;
		}
		#region StoneMove...
		private void StoneMove(Stones stoneList,Skiers skiList,Bricks brickList)
		{
			Int32 countSkier = 0;
			Int32 [] IndSkier = new Int32[stoneList.CountPlayer];
			Int32 countStone = 0;
			Int32 [] IndStone = new Int32[stoneList.CountPlayer];
			foreach (Stone st in stoneList)
				if (Map.GetItem(st.TOP/25+1,st.LEFT/25) == ItemName.Skier)
				{
					foreach (Skier sk in skiList)
						if ((st.LEFT == sk.LEFT) && (st.TOP == (sk.TOP-25)))
						{
							IndSkier[countSkier] = skiList.IndexOf(sk);
							IndStone[countStone] = stoneList.IndexOf(st);
							Invalidate(new Rectangle(sk.LEFT, sk.TOP, 25, 25));
							Invalidate(new Rectangle(st.LEFT, st.TOP, 25, 25));

							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Null);
							Map.SetItem(sk.TOP/25,sk.LEFT/25,ItemName.Null);
							countSkier++;
							countStone++;
						}
				}
			Array.Sort(IndSkier);
			Array.Reverse(IndSkier);

			Array.Sort(IndStone);
			Array.Reverse(IndStone);

			for(int i=0; i<countStone;i++)
				stoneList.RemovePlayer(IndStone[i]);
			for(int i=0; i<countSkier;i++)
				skiList.RemovePlayer(IndSkier[i]);

			foreach (Stone st in stoneList)
				if (st.Moving(trac) == true)
				{
					if (st.StoneDirec == Direction.Down) InvalidateDown(st);
					if (st.StoneDirec == Direction.Left) InvalidateLeft(st);
					if (st.StoneDirec == Direction.Right) InvalidateRight(st);
				}
		}
		#endregion
		#region BombMove...
		private void BombMove(Bombs bombList,Skiers skiList,Bricks brickList)
		{
			Int32 countSkier = 0;
			Int32 [] IndSkier = new Int32[bombList.CountPlayer];
			Int32 countBomb = 0;
			Int32 [] IndBomb = new Int32[bombList.CountPlayer];
			foreach (Bomb st in bombList)
				if (Map.GetItem(st.TOP/25+1,st.LEFT/25) == ItemName.Skier)
				{
					foreach (Skier sk in skiList)
						if ((st.LEFT == sk.LEFT) && (st.TOP == (sk.TOP-25)))
						{
							IndSkier[countSkier] = skiList.IndexOf(sk);
							IndBomb[countBomb] = bombList.IndexOf(st);
							Invalidate(new Rectangle(sk.LEFT, sk.TOP, 25, 25));
							Invalidate(new Rectangle(st.LEFT, st.TOP, 25, 25));
							Map.SetItem(st.TOP/25,st.LEFT/25,ItemName.Null);
							Map.SetItem(sk.TOP/25,sk.LEFT/25,ItemName.Null);
							countSkier++;
							countBomb++;
						}
				}
			Array.Sort(IndSkier);
			Array.Reverse(IndSkier);

			Array.Sort(IndBomb);
			Array.Reverse(IndBomb);

			for(int i=0; i<countBomb;i++)
				bombList.RemovePlayer(IndBomb[i]);
			for(int i=0; i<countSkier;i++)
				skiList.RemovePlayer(IndSkier[i]);

			foreach (Bomb st in bombList)
				if (st.Moving(trac) == true)
				{
					if (st.BombDirec == Direction.Down) InvalidateDown(st);
					if (st.BombDirec == Direction.Left) InvalidateLeft(st);
					if (st.BombDirec == Direction.Right) InvalidateRight(st);
				}
		}
		#endregion
		#region Invalidate
		private void InvalidateThis(Int32 x, Int32 y)// x,y - номера клеток
		{
			Invalidate(new Rectangle(x*25, y*25, 25, 25));
		}
		private void InvalidateLeft(MovePlayer pl)
		{
			Invalidate(new Rectangle(pl.LEFT, pl.TOP, 50, 25));
			Map.SetItem(pl.TOP/25,pl.LEFT/25 + 1,ItemName.Null);
			Map.SetItem(pl);
		}
		private void InvalidateRight(MovePlayer pl){
			Invalidate(new Rectangle(pl.LEFT-25, pl.TOP, 50, 25));
			Map.SetItem(pl.TOP/25,pl.LEFT/25 - 1,ItemName.Null);
			Map.SetItem(pl);
		}
		private void InvalidateUp(MovePlayer pl){
			Invalidate(new Rectangle(pl.LEFT, pl.TOP, 25, 50));
			Map.SetItem(pl.TOP/25 + 1,pl.LEFT/25,ItemName.Null);
			Map.SetItem(pl);
		}
		private void InvalidateDown(MovePlayer pl){
			Invalidate(new Rectangle(pl.LEFT, pl.TOP-25, 25, 50));
			Map.SetItem(pl.TOP/25 - 1,pl.LEFT/25,ItemName.Null);
			Map.SetItem(pl);
		}
		#endregion

		#region Menu
		private void On_Save_as(object sender, System.EventArgs e)
		{
			this.timer1.Enabled = false;

			SaveFileDialog mySave = new SaveFileDialog();
			mySave.InitialDirectory = ".";
			mySave.Filter = "tractor files(*.tra)|*.tra|All files(*.*)|*.*";
			mySave.FilterIndex = 1;
			mySave.RestoreDirectory = true;
			mySave.FileName = "trac";

			if (mySave.ShowDialog() == DialogResult.OK)
			{
				List = new PlaceList(brickList,blueBrickList,soilList,
					stoneList,skiList,bombList,trac,trac2);

				Stream myStream = mySave.OpenFile();
				if (myStream != null)
				{
					BinaryFormatter myBin = new BinaryFormatter();
					myBin.Serialize(myStream, List);
					myStream.Close();
					this.IsCreateNewMap = false;
					this.timer1.Enabled = true;
					menuItemCreate.Visible = true;

					menuItemPlayer.Enabled = false;
					menuItemSkier.Enabled = false;
					menuItemBomb.Enabled = false;
					menuItemStone.Enabled = false;
					menuItemSoil.Enabled = false;
					menuItemBrick.Enabled = false;
					menuItemBlueBrick.Enabled = false;

					Map.ClearMap();
					foreach (Skier sk in skiList)
						Map.SetItem(sk);
					foreach (Stone st in stoneList)
						Map.SetItem(st);
					foreach (Bomb bo in bombList)
						Map.SetItem(bo);
					foreach (Brick br in brickList)
						Map.SetItem(br);
					foreach (BlueBrick bbr in blueBrickList)
						Map.SetItem(bbr);
					foreach (Soil so in soilList)
						Map.SetItem(so);
					Map.SetItem(trac);
					Map.SetItem(trac2);
				}
			}
			this.timer1.Enabled = true;
		}

		private void On_Open(object sender, System.EventArgs e)
		{
			CloseConnection();

			trac.LIFE = 1; // !!!
			OpenFileDialog Open = new OpenFileDialog();
			Open.InitialDirectory = ".";
			Open.Filter = "tractor files(*.tra)|*.tra|All files(*.*)|*.*";
			Open.FilterIndex = 1;
			Open.RestoreDirectory = true;

			if (Open.ShowDialog() == DialogResult.OK)
			{
				brickList.ClearAll();
				blueBrickList.ClearAll();
				soilList.ClearAll();
				stoneList.ClearAll();
				skiList.ClearAll();
				bombList.ClearAll();

				Stream myStream = Open.OpenFile();
				if (myStream != null)
				{
					BinaryFormatter myBin = new BinaryFormatter();
					List = (PlaceList)myBin.Deserialize(myStream);
	
					List.SetList(ref brickList,ref blueBrickList,ref soilList,
						ref stoneList, ref skiList,ref bombList,ref trac,ref trac2);

					myStream.Close();	
					this.IsCreateNewMap = false;
					this.timer1.Enabled = true;
					menuItemCreate.Visible = true;

					menuItemPlayer.Enabled = false;
					menuItemSkier.Enabled = false;
					menuItemBomb.Enabled = false;
					menuItemStone.Enabled = false;
					menuItemSoil.Enabled = false;
					menuItemBrick.Enabled = false;
					menuItemBlueBrick.Enabled = false;

					Map.ClearMap();

					foreach (Skier sk in skiList)
						Map.SetItem(sk);
					foreach (Stone st in stoneList)
						Map.SetItem(st);
					foreach (Bomb bo in bombList)
						Map.SetItem(bo);
					foreach (Brick br in brickList)
						Map.SetItem(br);
					foreach (BlueBrick bbr in blueBrickList)
						Map.SetItem(bbr);
					foreach (Soil so in soilList)
						Map.SetItem(so);
					Map.SetItem(trac);
					Map.SetItem(trac2);

					IfCreatureMoving = true;

					this.timer1.Enabled = true;
				}		
			}
			Invalidate(); 
		}

		private void On_Exit(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void On_Closed(object sender, System.EventArgs e)
		{
			CloseConnection();
		}
		private void CloseConnection()
		{
			string host = "127.0.0.1";
			int port = 8080;
			TcpClient client = null;
			NetworkStream outStream = null;

			if (listener != null)
			{
				client = new TcpClient ( host, port );
				outStream = client.GetStream ();
				String command = "Exit";
				command += "\r\n";
				Byte[] cmd = System.Text.Encoding.ASCII.GetBytes(command.ToCharArray());

				outStream.Write(cmd,0,cmd.Length);
			}	
		}
		#region Map
		private void On_CreateNewMap(object sender, System.EventArgs e)
		{
			CreateNewMap myMapDialog = new CreateNewMap();
			myMapDialog.ShowDialog();
			if (myMapDialog.DialogResult == DialogResult.OK)
			{
				this.timer1.Enabled = false;
				this.IsCreateNewMap = true;
				SelectedItem = "NULL";
				trac = new Player(0,0,"NULL.bmp");
				trac2 = new Player(5,0,"NULL.bmp");
				menuItemPlayer1.Enabled = true;
				menuItemPlayer2.Enabled = true;

				brickList.ClearAll();
				blueBrickList.ClearAll();
				soilList.ClearAll();
				stoneList.ClearAll();
				skiList.ClearAll();
				bombList.ClearAll();
				Invalidate();

				menuItemPlayer.Enabled = true;
				menuItemSkier.Enabled = true;
				menuItemBomb.Enabled = true;
				menuItemStone.Enabled = true;
				menuItemSoil.Enabled = true;
				menuItemBrick.Enabled = true;
				menuItemBlueBrick.Enabled = true;

				Map.ClearMap();

				foreach (Skier sk in skiList)
					Map.SetItem(sk);
				foreach (Stone st in stoneList)
					Map.SetItem(st);
				foreach (Bomb bo in bombList)
					Map.SetItem(bo);
				foreach (Brick br in brickList)
					Map.SetItem(br);
				foreach (BlueBrick bbr in blueBrickList)
					Map.SetItem(bbr);
				foreach (Soil so in soilList)
					Map.SetItem(so);
				Map.SetItem(trac);
				Map.SetItem(trac2);

				if (myMapDialog.DrawBorder == true)
				{
					Int32 x = myMapDialog.CoordinateX;
					Int32 y = myMapDialog.CoordinateY;
					for (int xx = 0; xx < x+2; xx++)
						brickList.AddPlayer(new Brick(xx,0));
					for (int yy = 1; yy < y+1; yy++)
						brickList.AddPlayer(new Brick(0,yy));
					for (int xx = 0; xx < x+2; xx++)
						brickList.AddPlayer(new Brick(xx,y+1));
					for (int yy = 1; yy < y+1; yy++)
						brickList.AddPlayer(new Brick(x+1,yy));
				}
			}
		}
		
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Rules myRules = new Rules();
			myRules.ShowDialog();
		}
		private void menuItemDesignation_Click(object sender, System.EventArgs e)
		{
			Designation mydes = new Designation();
			mydes.ShowDialog();
		}

		private void menuItemPlayer1_Click(object sender, System.EventArgs e)
		{
			SelectedItem = "Player1";
		}

		private void menuItemPlayer2_Click(object sender, System.EventArgs e)
		{
			SelectedItem = "Player2";
		}

		private void menuItemSkierLeft_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "SkiLeft";
		}

		private void menuItemSkierRight_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "SkiRight";
		}

		private void menuItemSkierUp_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "SkiUp";
		}

		private void menuItemDown_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "SkiDown";
		}

		private void menuItemBomb_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "Bomb";
		}

		private void menuItemStone_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "Stone";
		}

		private void menuItemSoil_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "Soil";
		}

		private void menuItemBrick_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "Brick";
		}

		private void menuItemBlueBrick_Click(object sender, System.EventArgs e)
		{
		SelectedItem = "BlueBrick";
		}
		#endregion
		#endregion
		private void On_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (IsCreateNewMap == true)
			{
				Int32 x;
				Int32 y;
				x = e.X/25;
				y = e.Y/25;
				switch (SelectedItem)
				{
					case "Player1": 
						trac = new Player(x,y,"PlayerRight.bmp");
						menuItemPlayer1.Enabled = false;
						SelectedItem = "NULL";
						break;
					case "Player2": 
						trac2 = new Player(x,y,"ClientRight.bmp");
						menuItemPlayer2.Enabled = false;
						SelectedItem = "NULL";
						break;
					case "SkiLeft": 
						skiList.AddPlayer(new Skier(x,y,"SkierLeft.bmp",Direction.Left));
						break;
					case "SkiRight":
						skiList.AddPlayer(new Skier(x,y,"SkierRight.bmp",Direction.Right));
						break;
					case "SkiUp":
						skiList.AddPlayer(new Skier(x,y,"SkierUp.bmp",Direction.Up));
						break;
					case "SkiDown":
						skiList.AddPlayer(new Skier(x,y,"SkierDown.bmp",Direction.Down));
						break;
					case "Bomb":
						bombList.AddPlayer(new Bomb(x,y));
						break;
					case "Stone":
						stoneList.AddPlayer(new Stone(x,y));
						break;
					case "Soil":
						soilList.AddPlayer(new Soil(x,y));
						break;
					case "Brick":
						brickList.AddPlayer(new Brick(x,y));
						break;
					case "BlueBrick":
						blueBrickList.AddPlayer(new BlueBrick(x,y));
						break;
				}
				InvalidateThis(x,y);

			}
		}

		private void menuItemNet_Click(object sender, System.EventArgs e)
		{
			NetParameter NetPar = new NetParameter();
			NetPar.ShowDialog();
			if (NetPar.DialogResult == DialogResult.OK)
			{
			}
		}

		private void menuItemGameType_Click(object sender, System.EventArgs e)
		{
			GameType myGame = new GameType();
			myGame.myType = gameType;
			myGame.ShowDialog();

			if (myGame.DialogResult == DialogResult.OK)
				gameType = myGame.myType;
			if (gameType == false) 
			{
				menuItemNet.Enabled = false;
				IfPlayerMoving = true;
			}
			if (gameType == true) 
			{
				menuItemNet.Enabled = true;
				IfPlayerMoving = false;
			}		
		}

		private void menuItemSpeed_Click(object sender, System.EventArgs e)
		{
			Speed speed = new Speed();

			speed.mySpeed = timer1.Interval;

			speed.ShowDialog();

			if (speed.DialogResult == DialogResult.OK)
				timer1.Interval = speed.mySpeed;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			ControlGame myControl = new ControlGame();
			myControl.ShowDialog();
		}
	}
}
