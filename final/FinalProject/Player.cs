// class for governing the player


using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


class Player
{
   public Orientate orient;
   private Controls control;
   public PictureBox playerTank;
//    private Bullet bullet;
   private float angle;
   private Orientate.Direction prevDirection;
   

   public Player()
   {

    control = new Controls();
    orient = control.orientate;
    this.playerTank = new PictureBox
    {
        Image = Image.FromFile("resources/Tank3.png"),
        SizeMode = PictureBoxSizeMode.AutoSize,
        Location = new Point(500, 500),
        BorderStyle = BorderStyle.None,
        BackColor = Color.Red
    };

    

    orient.currentDirection = Orientate.Direction.Down;
    // prevDirection = orient.currentDirection;
   }

   public PictureBox GetPlayerTank()
   {
      return playerTank;
   }

   public void Input(Keys key)
   {
        
        RotatePlayer();
        control.HandleInput(key);
        // if (key == Keys.S)
        // {
        //     fireBullet();
        // }
        this.playerTank.Location = new Point(this.control.movement.playerPosition.X, this.control.movement.playerPosition.Y);
        this.playerTank.Invalidate();
   }
   public void RotatePlayer()
   {
 
        // if(orient.currentDirection != prevDirection)
        // {
            switch (orient.currentDirection)
            {
                
                case Orientate.Direction.Right:
                    this.playerTank.Image =Image.FromFile("resources/TankRight.png");
                    break;
                case Orientate.Direction.Down:
                    this.playerTank.Image =Image.FromFile("resources/TankDown.png");
                    break;
                case Orientate.Direction.Left:
                    this.playerTank.Image =Image.FromFile("resources/TankLeft.png");
                    break;
                case Orientate.Direction.UpLeft:
                   this.playerTank.Image =Image.FromFile("resources/TankUpLeft.png");
                    break;
                case Orientate.Direction.UpRight:
                   this.playerTank.Image =Image.FromFile("resources/TankUpRight.png");
                    break;
                case Orientate.Direction.DownLeft:
                    this.playerTank.Image =Image.FromFile("resources/TankDownLeft.png");
                    break;
                case Orientate.Direction.DownRight:
                    this.playerTank.Image =Image.FromFile("resources/TankDownRight.png");
                    break;
                case Orientate.Direction.Up:
                    this.playerTank.Image = Image.FromFile("resources/TankUp.png");
                    break;
            // }
        }
   }

//    private void fireBullet()
//     {
//         Bullet bullet = new Bullet(playerTank.Location);
//         Form mainForm = Application.OpenForms[0]; // Get the main form
//         mainForm.Controls.Add(bullet.GetBulletImage()); // Add bullet to the form
//         this.bullet.bulletTimer = new System.Windows.Forms.Timer()
//         {
//             Interval = 50
//         };    
//         this.bullet.bulletTimer.Tick += new EventHandler(bullet.fire);
//         this.bullet.bulletTimer.Start();
//         this.bullet.GetBulletImage().Invalidate();
//     }
}   


    
    