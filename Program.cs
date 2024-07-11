//CLASS NOTES ----------------------------------------------------------------------------------

// var numberList = new List<int>(){3,4,9,7,6,8,1,2,5,10};

//ORDER BY ASCENDING

//Query expression
// var ascNumber = from number in numberList
//                 orderby number //descending
//                 select number;

// foreach (var num  in ascNumber)
// {
//     Console.WriteLine(num);
// } 

//Extension method
// var ascNumber1 = numberList.OrderBy(item => item).ToList();
// Console.WriteLine(ascNumber1[0]);


//Reverse() Method 
// var reversedList = numberList.AsEnumerable().Reverse().ToList();

// foreach (var number in reversedList)
// {
//     Console.WriteLine(number);
// }


// var numbers = new List<int>(){5,1,2,3,4,6,7,9,8,10};
// var pares = numbers.Where(num => num % 2 == 0);

// foreach (var num in pares)
// {
//     Console.WriteLine($"Numero par --> {num}");
// }

// var fruits = new List<string>() {"manzana","pera","banano"};
// var mayus = fruits.Select(fruit => fruit.ToUpper());

// foreach (var fruit in mayus)
// {
//     Console.WriteLine($"Palabra en mayuscula: {fruit}");
// }

// var numbers = new List<int>(){1,9,7,8,4,5,6,3,2,10};

// var ascNumbers = numbers.OrderBy(num => num);
// var descNumbers = numbers.OrderByDescending(num => num);

// Console.WriteLine("Lista con numeros ascendentes");
// foreach (var num in ascNumbers)
// {
//     Console.WriteLine(num);
// }

// Console.WriteLine("Lista con numeros descendentes");
// foreach (var num in descNumbers)
// {
//     Console.WriteLine(num);
// }


//Metodo Any para verificar si al menos un elemento cumple una condicion
// var numbers = new List<int>(){10,21,15};
// var majorThan = numbers.Any(num => num >= 50);

//Metodo All para verificar si todos elementos cumplen una condicion
// var minorThan = numbers.All(num => num <= 5);

// Console.WriteLine($"¿Hay números mayores de 50?: {majorThan}");
// Console.WriteLine($"¿Todos los números son menores que 5?: {minorThan}");

//-----------------------------------------------------------WORKSHOP-----------------------------------------------------------


//1. Filtra los números mayores a 10 en una lista de enteros.
// var numbers = new List<int>(){5,1,2,15,19,20,3};
// var majorThan10 = numbers.Where(num => num > 10);

// foreach (var num in majorThan10)
// {
//     Console.WriteLine(num);
// }

// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros
// var numbers = new List<int>(){5,1,2,15,19,20,3};
// var squareNumbers = numbers.Select(num => num * num).ToList();

// foreach (var num in squareNumbers)
// {
//     Console.WriteLine(num);
// }

//3. Ordena alfabéticamente una lista de nombres.
// var fruits = new List<string>() {"manzana","pera","banano"};
// var orderFruits = fruits.OrderBy(fruit => fruit);

// foreach (var fruit in orderFruits)
// {
//     Console.WriteLine(fruit);
// }

//4. Ordena una lista de precios de mayor a menor.
// var prices = new List<decimal>() {50000, 10000, 20000};
// var orderPrices = prices.OrderByDescending(price => price);

// foreach (var price in orderPrices)
// {
//     Console.WriteLine(price);
// }

//5. Encuentra el primer número par en una lista de enteros.
// var numbers = new List<int>(){5,1,2,15,19,20,3};
// var parNumber = numbers.First(num => num % 2 == 0);

// Console.WriteLine(parNumber);

//6. Encuentra el último nombre en una lista de nombres.
// var fruits = new List<string>() {"manzana","pera","banano"};
// var lastFruit = fruits.Last();

// Console.WriteLine(lastFruit);

//7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay ninguno.
// var numbers = new List<int>(){5,1,2,15,19,20,-5,3};
// var firstNegativeNum = numbers.FirstOrDefault(num => num < 0);

// Console.WriteLine(firstNegativeNum);

//8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si no hay ninguno
// var numbers = new List<int>(){5,1,2,15,51,70,200,19,20,3};
// var lastMajor50 = numbers.LastOrDefault(num => num > 50);

// Console.WriteLine(lastMajor50);

//9. Verifica si algún elemento en una lista de booleanos es verdadero
// var numbers = new List<bool>(){false,false,false};
// var booleanTrue = numbers.Any(num => num );

// Console.WriteLine(booleanTrue);

//10. Verifica si todos los elementos en una lista de números son mayores a 0
// var numbers = new List<int>(){5,1,2,15,19,20,3};
// var majorThan10 = numbers.All(num => num > 0);

// Console.WriteLine(majorThan10);

//11. Comprueba si una lista de palabras contiene la palabra "LINQ".
// var words = new List<string>() {"manzana","LINQ","banano"};
// var containWord = words.Contains("LINQ");

// Console.WriteLine(containWord);

//12. Cuenta cuántos números pares hay en una lista de enteros.
// var numbers = new List<int>(){5,1,2,15,19,20,30};
// var parNumbers = numbers.Count(num => num % 2 == 0);

// Console.WriteLine(parNumbers);

//13. Calcula la suma de los elementos en una lista de precios.
// var prices = new List<decimal>() {50000, 10000, 20000};
// var sumPrices = prices.Sum();

// Console.WriteLine(sumPrices);

//14. Calcula el promedio de una lista de edades.
// var ages = new List<int>(){15,19,20,33,50,12};
// var ageProm = ages.Average();
// double agePromRound = Math.Round(ageProm, 2);

// Console.WriteLine(agePromRound);

//15. Encuentra el número mínimo en una lista de temperaturas.
// var temperatures = new List<double>(){15.5,19.9,20.7,33.3,5.8,12.3};
// var minTemperature = temperatures.Min();

// Console.WriteLine(minTemperature);

//16. Encuentra el número máximo en una lista de alturas.
// var height = new List<double>(){1.86,1.73,1.98,1.60};
// var maxHeight = height.Max();

// Console.WriteLine(maxHeight);

//17. Obtén los primeros 5 elementos de una lista de puntuaciones
// var qualification = new List<double>(){4.8,3.7,1.9,2.6,4.8,4.3};
// var first5Qualification = qualification.Take(5);

// foreach (var qual in first5Qualification)
// {
//     Console.WriteLine(qual); 
// }

//18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
// var names = new List<string>() {"manzana","LINQ","banano","pera","sandia","guanabana"};
// var skipNames = names.Skip(3);

// foreach (var name in skipNames)
// {
//     Console.WriteLine(name); 
// }

//19. Elimina los elementos duplicados en una lista de números.
// var numbers = new List<int>(){15,33,20,33,50,50};
// var deleteDuplicated = numbers.Distinct();

// Console.WriteLine(string.Join("\n",deleteDuplicated));

// foreach (var num in deleteDuplicated)
// {
//     Console.WriteLine(num);
// }

//20. Convierte una lista de palabras en un Array.
// var names = new List<string>() {"manzana","LINQ","banano","pera","sandia","guanabana"};
// var convertToArray = names.ToArray();

// Console.WriteLine(convertToArray);

//21. Convierte una lista de números en un array.
// var numbers = new List<int>(){15,33,20,33,50,50};
// var convertToList = numbers.ToArray();

// Console.WriteLine(convertToList);

//22. Filtra los números negativos de una lista y ordénalos de menor a mayor.
// var numbers = new List<int>(){-15,-33,-20,-50,};
// var negNumbers = numbers.Where(num => num < 0).OrderBy(num => num);

// Console.WriteLine(string.Join("\n",negNumbers));

//23. Obtén una lista de longitudes de cada palabra en una lista de palabras.
// var names = new List<string>() {"manzana","LINQ","banano","pera","sandia","guanabana"};
// var namesLenght = names.Select(word => word.Length);

// Console.WriteLine(string.Join("\n",namesLenght));

//24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// var salaries = new List<decimal>() {50000, 10000, 20000,120000,35000,12000,5000};
// var lowestSalarys = salaries.OrderBy(salary => salary).Take(3);

// Console.WriteLine(string.Join("\n",lowestSalarys));

//25. Obtén los nombres más largos en una lista de nombres.
// var names = new List<string>() {"manzana","LINQ","banano","pera","sandia","guanabana"};
// var largeNames = names.OrderByDescending(word => word.Length).Take(3);//First() para la palabra mas larga instead of Take

// Console.WriteLine(string.Join("\n",largeNames));

//26. Encuentra el primer número mayor a 100 en una lista de precios.
// var prices = new List<decimal>() {99,10,101,50000, 10000, 20000,120000,35000,12000};
// var firstMajor100 = prices.Where(price => price > 100).First();

// Console.WriteLine(firstMajor100);

//27. Encuentra el último día del mes en una lista de fechas.

// var dates = new List<DateTime>
//         {
//             new DateTime(2024, 1, 1),
//             new DateTime(2024, 1, 15),
//             new DateTime(2024, 1, 31),
//             new DateTime(2024, 2, 1),
//             new DateTime(2024, 2, 28),
//             new DateTime(2024, 2, 29),
//             new DateTime(2024, 3, 1),
//             new DateTime(2024, 3, 31),
//             new DateTime(2024, 3, 30)
//         };

//         var lastDaysOfMonth = dates
//             .GroupBy(date => new { date.Month, date.Day })
//             .Select(group => group.Max(date => date))
//             .ToList();

//         Console.WriteLine(string.Join("\n", lastDaysOfMonth));

//28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por defecto si no hay ninguno.
// var names = new List<string>() {"Manzana","LINQ","Banano","Pera","Sandia","Arracacha","Guanabana"};
// var firstAName = names.FirstOrDefault(name => name.StartsWith("A"))?? "No se encontró nombre con 'A'";// ?? es Para asignar valor por defecto

// Console.WriteLine(firstAName);

//29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay ninguno.
// var numbers = new List<int>(){17,19,20,33,50,15,12};
// var lastInparNum = numbers.LastOrDefault(number => number % 2 != 0) ;

// Console.WriteLine(lastInparNum);

//30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// var words = new List<string>() {"manzana","LINQ","banano","pera","sandia","guanabana","quitate de la via perico"};
// var wordBiggerThan10 = words.Any(word => word.Length > 10);

// Console.WriteLine(wordBiggerThan10);