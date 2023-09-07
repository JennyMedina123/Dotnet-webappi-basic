namespace csharp.basic
{
    /*: Solicita al usuario un número y eleva este número al cuadrado
solo si es positivo.*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingresa un número:");
            string input = Console.ReadLine();
            int num;
            if (int.TryParse(input, out num))
            {
                if (num > 0)
                {
                    /*se crea una variable llamado cuadrado y luego se concatena 
                    para que nos muestre el resultado al elevarlo*/
                    int cuadrado = num * num;
                    Console.WriteLine("Resultado: " + cuadrado);
                }

                else if (num == 0) { Console.WriteLine("Resultado: 0"); }
                else { Console.WriteLine("Resultado: Número negativo"); }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
            }
        }
    }

    /*Solicita al usuario dos números. Si el primero es mayor, devuelva
su doble, de lo contrario devuelva el triple del segundo.*/
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número:");
            double num2 = double.Parse(Console.ReadLine());
            /* En este punto se define la variable res utilizando el double, 
            para luego agregarle los 2 numeros utilizando el >= y el if tenario si el resultado del segundo es mayor entonces
            se triplica o si el res, del primero es mayor se genera el doble*/
            double res = num1 >= num2 ? num1 * 2 : num2 * 3;
            Console.WriteLine($"Ingresos: {num1}, {num2} =>Resultado: {res}");
        }
    }

    /* Pide al usuario un número. Si es positivo, devuelve su raíz
cuadrada, de lo contrario, devuelve su cuadrado*/
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());
            /* utilizando una expresion ternaria, 
            se valida si el numero es > a 0, se le calcula la raiz cuadrada*/
            var res = numero > 0 ? Math.Sqrt(numero): Math.Pow(numero, 2);
            Console.WriteLine($"El resultado de {numero} es: {res}");
        }
    }

    /*Pide al usuario el radio de un círculo y calcula su perímetro*/
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());
            /* En este ejercicio utilizamos 2 variables, luego se multiplica pi con el radio*/
            double perimetro = Math.PI * radio * 2;
            Console.WriteLine($"El área del círculo con radio {radio} es: {perimetro}" );
        }
    }

    /* Solicita al usuario un número entre 1 y 7 y muestra el día de la
             semana correspondiente, pero solo considerando los días laborables*/
    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                /*Este punto me parecio el mas sencillo solo es implementar los demas dias utilizando el case */
                default: Console.WriteLine("Número fuera del rango laboral"); break;
            }
        }
    }

    /*Solicita al usuario su salario anual y, si este excede los 12000,
       muestra el impuesto a pagar que es el 15% del excedente.*/
    public class Challenge6
    {
        public void Run()
        {    /*En este caso el excedente se restaria con el salario*/
            Console.WriteLine("Ingrese su salario mensual:");
            double salario = double.Parse(Console.ReadLine());
            double impuesto = salario > 12000 ? 0.15 * (salario-12000) : 0;
            Console.WriteLine($"El impuesto a pagar es: {impuesto}");
            Console.WriteLine($"{salario}, {impuesto}, {salario -12000}");
            Console.WriteLine($"No debe impuesto: {impuesto}");
        }
    }

    /*Solicita dos números y muestra el residuo de la división del
        primero entre el segundo*/
    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Número a dividir:");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor:");
                double divisor = double.Parse(Console.ReadLine());
                /*En este ejercicio utilizamos el mod(%)*/
                Console.WriteLine($"Resultado: {n % divisor}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar la operación!");
            }
        }
    }

    /*Calcula y muestra la suma de los números pares entre 1 y 50.*/
    public class Challenge8
    {
        public void Run()
        {
            Console.WriteLine("Posibles resultados:(sin entrada)");
            int suma = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"Resultado es: {suma}");
        }
    }


    /*Solicita al usuario los valores para dos fracciones y muestra la
        diferencia entre esas fracciones.*/
    public class Challenge9
    {   /* En esta clase se verifico, que se incorporo 
        un contructor donde recibe unos metodos y se le agrego el metodo de restar
        tambien se le agregar, multiplicar y dividir este ejercicio me parecio el mas complejo */
        public void Run()
        {
            Console.WriteLine("Ingrese numerador de la primera fracción:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la primera fracción:");
            int den1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numerador de la segunda fracción:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese denominador de la segunda fracción:");
            int den2 = int.Parse(Console.ReadLine());

            try
            {
                Fraccion fraccion1 = new Fraccion(num1, den1);
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Restar(fraccion2);

                Console.WriteLine($"La diferencia de {fraccion1} y {fraccion2} es: {resultado}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }


    public class Fraccion
    {
        public int Numerador { get; private set; }
        public int Denominador { get; private set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser cero.");
            }

            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador + otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        // Puedes agregar más métodos para otras operaciones si es necesario
        public Fraccion Restar(Fraccion otra)
        {
            int nuevoNumerador = Numerador * otra.Denominador - otra.Numerador * Denominador;
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }
        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }


    /*Pide una palabra al usuario y muestra la longitud de esa palabra.*/
    public class Challenge10
    {  // en este punto se utiliza el atributo .Length, sirve para retornar el numero de caracteres
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            Console.WriteLine($"La longitud de la palabra es: {palabra?.Length}");
        }
    }

    /*Pide al usuario cuatro números y muestra el promedio.*/
    // se debe crear 4 numeros, luego hacer el promedio y por ultimo vamos a dividirlo
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Introduce el primer número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número:");
            double num4 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
        }
    }

    /* Pide al usuario cinco números y muestra el más pequeño*/
    // este ejercicio fue uno de los 2 mas facil que me a parecido se debe utillizar es el Min en el ciclo for
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce el número {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"El número más pequeño de la lista es: {numeros.Min()}");
        }
    }

    /*Pide una palabra al usuario y devuelve el número de
     vocales en esa palabra.*/
     /* En este punto se agrego 3 objetos y utilizando 
     los metodos ToArray, Contains and counts.*/
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            string vowels = "aeiouy";
            string name = new string(palabra.Where(p => vowels.Contains(p)).ToArray());
            

                Console.WriteLine($"Las vocales de la palabra {palabra} es una {name}.");
                Console.WriteLine($"La cantidad de vocales de la palabra {palabra} es  {name.Count(n => vowels.Contains(n))}.");
        }
    }

    /* Pide un número al usuario y devuelve el factorial de ese número.*/
    /* se crea 2 objetos, en el if se le incorpora la variable resul, y utilizamos el ciclo for*/
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());
            int  resultado = numero;

            if (resultado >1)
            for (int i = 1; i < numero; i++)
            {
            resultado = resultado * i;
            }
                Console.WriteLine($"El factorial del número {numero} es {resultado}.");
        }
    }
    /*Pide un número al usuario y verifica si está en el rango de 10 a 20
        (ambos incluidos).*/
    /*En este punto utilice 2 condicionales junto con el >= && y <= */
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Introduce un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"Resultado: {numero} está en el rango.");
            }
            else
            {
                Console.WriteLine($"Resultado: {numero} está fuera del rango.");
            }
        }
    }

}