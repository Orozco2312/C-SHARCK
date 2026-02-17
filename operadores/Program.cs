using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        int width = 7;
        int height = 5;

        // Cálculo inicial 
        int area = width * height;

        // Cálculo inicial del perímetro
        int perimeter = (2 * width) + (2 * height);

        // Incrementar width en 3 unidades
        width += 3;

        // Decrementar height en 2 unidades
        height -= 2;

        // Recalcular área y perímetro con nuevos valores
        area = width * height;
        perimeter = (2 * width) + (2 * height);

        // resultados finales
        Console.WriteLine("Valores finales:");
        Console.WriteLine("Ancho (width): " + width);
        Console.WriteLine("Alto (height): " + height);
        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimeter);
    }
}
