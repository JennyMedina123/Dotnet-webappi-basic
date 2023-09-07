// See https://aka.ms/new-console-template for more information 
/* Clases */

/*var rect= new Rectangulo();
rect.Base=20;
rect.Altura=40;
Console.WriteLine($"El area es : {rect.Area()}");
Console.WriteLine($"El perimetro es : {rect.Perimetro()}");*/
/* end Clases*/

var cuadr = new Cuadrado();
cuadr.Base = 20;
cuadr.Altura = 40;
Console.WriteLine($"El area es : {cuadr.Area()}");
Console.WriteLine($"El perimetro es : {cuadr.Perimetro()}");
Console.WriteLine($"El lado es : {cuadr.Lado}");

class Rectangulo
{
    public double Base { get; set; }

    public double Altura { get; set; }

    public double Area() => Base * Altura;

    public double Perimetro() => 2 * Base + 2 * Altura;

}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}

// crear que el usuario cree un nummero hasta que no ingrese un numero valido no dejarlo salir o hasta que presione alguna letra.