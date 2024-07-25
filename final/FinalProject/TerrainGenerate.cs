// class to print lines to the console for terrain
using System.CodeDom;


public class Map
{
    private int rows;
    private int cols;
    private int tileSize;
    private Panel gamePanel;
    public PictureBox target;

    public Map(int rows, int cols, int tileSize, Panel gamePanel)
    {
        this.rows = rows;
        this.cols = cols;
        this.tileSize = tileSize;
        this.gamePanel = gamePanel;
    }



    public void InitializeTerrain()
    {
        Random rand = new Random();
            int randX = rand.Next(0,(rows * tileSize));
            int randY = rand.Next(0, cols*tileSize);
            target = new PictureBox
           {
                Image = Image.FromFile("resources/Target.png"),
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(randX, randY),
                BorderStyle = BorderStyle.None,
                BackColor = Color.Black
           };
           gamePanel.Controls.Add(target);


        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                PictureBox tile = new PictureBox
                {
                    Size = new Size(tileSize, tileSize),
                    Location = new Point(col * tileSize, row * tileSize),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = (rand.Next(0, 10) < 2) ? Color.Green : Color.Brown
                };
                gamePanel.Controls.Add(tile);
            }
        }
        gamePanel.Size = new Size(cols * tileSize, rows * tileSize);
    }

    public PictureBox GetTarget()
    {
        return target;
    }
}