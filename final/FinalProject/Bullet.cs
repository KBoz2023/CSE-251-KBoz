// // class for firing your shot

// using System.Runtime;

// class Bullet
// {   
//     private Orientate direction;
//     private PictureBox bulletImage;
//     private Point bulletPosition;
//     private Point startPosition;
//     private int distance;
//     private int bulletSpeed = 10;
//     private int maxDistance = 800;
//     private bool hit = false;
//     public System.Windows.Forms.Timer bulletTimer;

//     private Point playerPosition;
    
    

// //     Collision collission;
//     public Bullet(Point playerPosition)
//     {
//         direction = new Orientate();
//         direction.currentDirection = Orientate.Direction.Up;

//         bulletPosition = playerPosition;
//         startPosition = playerPosition;

//         bulletImage = new PictureBox
//         {
//             Image = Image.FromFile("C:/Users/kpboz/Coding/Coding with Classes/CSE-251-KBoz/final/FinalProject/resources/Bullet.png"),
//             SizeMode = PictureBoxSizeMode.AutoSize,
//             Location = bulletPosition
//         };
//         bulletImage.Location = playerPosition;

//     }


//     public PictureBox GetBulletImage()
//     {
//         return bulletImage;
//     }

//     public void fire(object sender, EventArgs e)
//     {
        
      
//             switch(direction.currentDirection)
//             {
//                 case Orientate.Direction.Right:
//                     this.bulletPosition.X += bulletSpeed;
//                     break;
//                 case Orientate.Direction.Down:
//                     this.bulletPosition.Y += bulletSpeed;
//                     break;
//                 case Orientate.Direction.Left:
//                     this.bulletPosition.X -= bulletSpeed;
//                     break;
//                 case Orientate.Direction.UpLeft:
//                     this.bulletPosition.X -= bulletSpeed;
//                     this.bulletPosition.Y -= bulletSpeed;
//                     break;
//                 case Orientate.Direction.UpRight:
//                     this.bulletPosition.X += bulletSpeed;
//                     this.bulletPosition.Y -= bulletSpeed;
//                     break;
//                 case Orientate.Direction.DownLeft:
//                     this.bulletPosition.X -= bulletSpeed;
//                     this.bulletPosition.Y += bulletSpeed;
//                     break;
//                 case Orientate.Direction.DownRight:
//                     this.bulletPosition.X += bulletSpeed;
//                     this.bulletPosition.Y += bulletSpeed;
//                     break;
//                 case Orientate.Direction.Up:

//                     break;
//             }
//             this.bulletImage.Location = bulletPosition;
//             double distanceTraveled = Math.Sqrt(Math.Pow(bulletPosition.X - startPosition.X, 2) + Math.Pow(bulletPosition.Y - startPosition.Y, 2));


//             if( distanceTraveled>= maxDistance)
//             {
//                 bulletTimer.Stop();
                
//             }
//         }
        
    
// }
//     public void collide(PictureBox a, PictureBox b)
//     {
        
//     }
