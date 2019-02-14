namespace Methods
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void Move(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public void Move(Point newlocation)
        {
            Move(newlocation.X, newlocation.Y);
            //ou
                /*this.X = newlocation.X;
                 this.Y = newlocation.Y;*/
        }
    }
    
}
