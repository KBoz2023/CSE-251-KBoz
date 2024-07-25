



class Collision
{
    
    public bool IsColliding(PictureBox a, PictureBox b)
    {
        Rectangle rectA = new Rectangle(a.Location, a.Size);
        Rectangle rectB = new Rectangle(b.Location, b.Size);

        return rectA.IntersectsWith(rectB);
    }
    public bool RemoveTarget(PictureBox a, PictureBox b)
    {   
        return this.IsColliding(a, b);
    }

    // public void CollisionTarget(PictureBox target)
    // {
    //     // for if player collides with wall


    //     // for if bullet collides with target
    //     this.Controls.Remove(target);

    // }

}