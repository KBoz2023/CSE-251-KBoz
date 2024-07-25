using System;
using System.Drawing.Text;
using System.Media;
using System.Windows.Forms;

namespace YourGameProject
{
    public class MainForm : Form
    {
        private Map terrain;
        
        private Player player;
        // private Bullet bullet;
        private Button Start;
        private Label Welcome_To_TankWars;
        private System.Windows.Forms.Timer gameTimer;
        private Label gamer;
        private Label currentOrientation;
        private Panel gamePanel;
        private Collision collision;
        private bool isRunning = true;
        private int elapsedSeconds = 0;
        private bool colide;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Start = new Button();
            this.Welcome_To_TankWars = new Label();
            this.gamer = new Label();
            this.currentOrientation = new Label();
            
            // 
            // button1
            // 
            this.Start.Location = new System.Drawing.Point(700, 500);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new EventHandler(this.button1_Click);
            
            // 
            // label1
            // 
            this.Welcome_To_TankWars.AutoSize = true;
            this.Welcome_To_TankWars.Location = new System.Drawing.Point(700, 750);
            this.Welcome_To_TankWars.Name = "Welcome";
            this.Welcome_To_TankWars.Size = new System.Drawing.Size(46, 17);
            this.Welcome_To_TankWars.Text = "Welcome to Tank Wars";

            // game time counter
            this.gamer.AutoSize = true;
            this.gamer.Location = new System.Drawing.Point(0, 0);
            this.gamer.Name = "gameTime";
            this.gamer.Size = new System.Drawing.Size(46, 17);
            this.gamer.Text = "elapsed Time: 0";


                        // game time counter
            this.currentOrientation.AutoSize = true;
            this.currentOrientation.Location = new System.Drawing.Point(40, 0);
            this.currentOrientation.Name = "gameTime";
            this.currentOrientation.Size = new System.Drawing.Size(46, 17);
            this.currentOrientation.Text = "Current Direction: Up";

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Welcome_To_TankWars);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.gamer);
            this.Controls.Add(this.currentOrientation);
            this.Name = "Tank Wars";
            this.Text = "Tank Wars";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this.Welcome_To_TankWars.Text = "Button Clicked!";
            this.KeyDown += new KeyEventHandler(keyPress);
            this.Controls.Remove(this.Start);
            this.Controls.Remove(this.Welcome_To_TankWars);
            InitializeGame();

        }

        private void InitializeGame()
        {
            gamePanel = new Panel
            {
                Size = this.ClientSize,
                Location = new Point(300,300),
                BackColor = Color.Transparent
            };
            
            player = new Player();
            // bullet = new Bullet(player.playerTank.Location);
            terrain = new Map(20,20, 50, gamePanel);
            terrain.InitializeTerrain();
            this.Controls.Add(player.GetPlayerTank());
            this.Controls.Add(gamePanel);

            this.gameTimer = new System.Windows.Forms.Timer();
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += GameLoop;
            this.gameTimer.Start();
            this.gameTimer.Tick -= GameLoop;
            this.terrain.InitializeTerrain();

            


        }
        private void keyPress(object sender, KeyEventArgs e)
        {
                
            player.Input(e.KeyCode);
            

        }
        public void GameLoop(object sender, EventArgs e)
        {
            
                collision = new Collision();
                
                // player.Input(Keys.None);

                elapsedSeconds++;
                gamer.Text = $"Elapsed Time: {elapsedSeconds}";
                currentOrientation.Text = $"Current Facing {player.orient.currentDirection}";
                this.Invalidate();
                gamePanel.Invalidate();
                this.KeyDown += new KeyEventHandler(keyPress);

                colide = collision.RemoveTarget(player.GetPlayerTank(), terrain.GetTarget());
                if (colide == true)
                {
                    gamePanel.Controls.Remove(terrain.target);
                }
                return;
                
            
        }
        

    }
}