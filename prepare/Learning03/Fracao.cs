public class Fracao 
{
    private int _top;
    private int _bottom;
    

    public Fracao() 
    {
        _top = 1;
        _bottom = 1;
    }

    public Fracao(int bottom) 
    {
        _bottom = bottom;
        
    }

    public Fracao(int bottom, int top) 
    {
        _bottom = bottom;
        _top = top;

        
    }

    public int GetTop() 
    {
        return _top;        
    }

    public int GetBottom() 
    {
        return _bottom;  

    }

    public void SetBottom(int bottom) 
    {
        _bottom = bottom;  
              
    }

    public void SetTop(int top) 
    {
        _top = top;  
              
    }

    public string GetFractionString() 
    {
        return _top + "/" + _bottom;
    }

    public string GetDecimalValue() 
    {
        double decimalNum = _top/_bottom;
        
        
        return String.Format("{0:0.00}", decimalNum); 
    }


}
