using System;

class Program
{
    static void Main(string[] args)
    {
        Square quadrado = new Square("orange", 5);
       

        Circle circulo = new Circle("yellow", 3);
        string color = circulo.GetColor();
        // double area = circulo.GetArea();

        // Console.WriteLine(color);
        // Console.WriteLine(area);

        Rectangle rectangulo = new Rectangle("blue", 7, 2);

        List<Shape> formas = new List<Shape>();
        formas.Add(quadrado);
        formas.Add(rectangulo);
        formas.Add(circulo);

        foreach (Shape forma in formas) 
        {
          Console.WriteLine(forma.GetArea()); 
          Console.WriteLine(forma.GetColor());  
        }   
       
    }
}