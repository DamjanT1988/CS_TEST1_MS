using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare some unused variables using types
            // in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            


            //-----TEST 1
            
            // loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly()
            .GetReferencedAssemblies())
            {
                // load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));
                // declare a variable to count the number of methods
                int methodCount = 0;
                // loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    // add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }
                // output the count of types and their methods
                Console.WriteLine(
                "{0:N0} types with {1:N0} methods in {2} assembly.",
                arg0: a.DefinedTypes.Count(),
                arg1: methodCount,
                arg2: r.Name);
            }



            //------TEST 2

            // let the heightInMetres variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

            string friend1 = "Damjan";
            string friend2 = "Marko";

            Console.WriteLine($"Friends {friend1} & {friend2.Length}");
            // outputs a formatted number and date and a carriage-return
            Console.WriteLine(
            "Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

            

            //-----TEST 3 
            
            //få 63 - räkna ihop alla siffror som kan delas med 3 från 1 till 20
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"Sum is {sum}");



            //-----TEST 4

            //testa foreach och for
            var names = new List<string> { "New friend", "Damjan", "Marko" };
            
            //sortera i bokstavsordning
            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToLower()}!");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToLower()}!");
            }

            //names.Add("Mica");
            //names.Add("Aca");
            //names.Remove("Damjan");
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //ta ut ett namn vid specifik index
            Console.WriteLine(names[1]);

            //testa index

            var index = names.IndexOf("Marko");
            Console.WriteLine($"Found Marko at index {index}");

            if (index == -1)
            {
                Console.WriteLine($"Item not found, IndexOf return {index}");
            } else
            {
                Console.WriteLine($"Iten found, of {names[index]} is at index {index}");
            }


            //-----TEST 5

            //lists
            //deklerera och skapa ny lista
            //fib tar två sista värde och slår ihop
            var fibNumbers = new List<int> { 1, 1 };

            //1 kolla de två sist värde (tänk på index börjar på 0
            var previous1 = fibNumbers[fibNumbers.Count - 1];
            var previous2 = fibNumbers[fibNumbers.Count - 2];


            //2 slå samman värden
            fibNumbers.Add(previous1 + previous2);


            //3 få igenom varje fibNumber i konsol
            foreach (var item in fibNumbers)
            {
                Console.WriteLine(item);
            }

            
            //4 testa att loopa fibNumber 20 gånger till 6765
            while(fibNumbers.Count < 20)
            {

                //kolla de två sist värde (tänk på index börjar på 0
                var previous11 = fibNumbers[fibNumbers.Count - 1];
                var previous22 = fibNumbers[fibNumbers.Count - 2];

                //slå samman värden
                fibNumbers.Add(previous11 + previous22);

            }
            
            //5 få igenom varje fibNumber i konsol
            foreach (var item in fibNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
