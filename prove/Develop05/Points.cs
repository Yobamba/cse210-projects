public class Points 
{
    protected int _points;

   


    

    public Points() 
    {
        _points = 0;
    }

    public int GetPoints() 
    {
        int pts = _points;

        return pts;
    }

    public void AddPoints(int points) 
    {
        _points = points + _points;
    }
}