namespace HelloWord
{
    class Program
    {

        static void Main()
        {
            DateOnly dateConverted= new DateOnly();
            String nameInput;
            String BirthdayInput;
            Console.WriteLine("¡Hola Bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu Nombre");
            nameInput=Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte{nameInput}");
            Console.WriteLine("Escribe tu Fecha de Nacimiento en formato dd/mm/yy: ");
            BirthdayInput=Console.ReadLine();
            bool isDateValid=DateOnly.TryParse(BirthdayInput,out dateConverted);
            if(isDateValid==false)  Console.WriteLine($"la fecha de nacimineto es invalida usted nos envio este dato erroneo {BirthdayInput}");
            var Person= new Person{
                Name=nameInput,
                Birthday=dateConverted,
                Age=DateTime.Now.Year-dateConverted.Year

            };
            Console.WriteLine($"Tu nombre: {Person.Name}");
            Console.WriteLine($"Fecha de Nacimiento: {Person.Birthday}");
            Console.WriteLine($"Tu edad es: {Person.Age} Años!");
            Console.WriteLine();
        }
    }

    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public DateOnly Birthday { get; set; }

    }



}
