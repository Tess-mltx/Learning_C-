// //Type of variables
// char userOption = 'a'; // un seul charactère unicode
// string userName = "Jane";
// int gameScore = 4;
// decimal particles = 3.14M; //28 chiffres significatifs
// double particlesPerLitre = 3.14D; //15 chiffres significatifs
// float particlesPerMillion = 3.14F; // 6 chiffres significatifs
// bool processedCustomer = false;
// var userName = "Bob"; //le compilateur détermine le type à l'initialisation

// //List
// List<int> numbers = new List<int>();
// numbers.Add(10);
// numbers.Add(20);
// //Array
// int[] numbers = new int[5];
// numbers[0] = 10;
// numbers[1] = 20;
// //Dictionnaire
// Dictionary<string, int> ages = new Dictionary<string, int>();
// ages.Add("John", 25);
// ages.Add("Alice", 30);


// //Output
// Console.WriteLine("Hello wordl !");
// Console.Write("Congratulation !");
// Console.Write(" ");
// Console.Write("You wrote your first line of code.");

// // for loop: Print numbers from 1 to 5
// for (int i = 1; i <= 5; i++)
// {
// 	Console.WriteLine(i);
// }

// // while loop: Keep reading input until the user enters "quit"
// string input;
// while ((input = Console.ReadLine()) != "quit")
// {
//     Console.WriteLine("You entered: " + input);
// }

// // do-while loop: Roll a dice until a 6 is rolled (at least once)
// int roll;
// do
// {
//     roll = new Random().Next(1, 7);
//     Console.WriteLine("Rolled: " + roll);
// } while (roll != 6);


// // elseif condition :
// int score = 85;

// if (score >= 90)
// {
//   Console.WriteLine("Excellent !");
// }
// else if (score >= 80)
// {
//   Console.WriteLine("Très bien !");
// }
// else
// {
//   Console.WriteLine("Vous pouvez faire mieux");
// }

// // switch case :
// string jourSemaine = "mardi";

// switch (jourSemaine)
// {
//   case "lundi":
//   case "mardi":
//   case "mercredi":
//   case "jeudi":
//   case "vendredi":
//     Console.WriteLine("C'est un jour de semaine");
//     break;
//   case "samedi":
//   case "dimanche":
//     Console.WriteLine("C'est le weekend !");
//     break;
//   default:
//     Console.WriteLine("Jour invalide");
//     break;
// }

// Exe 1
// Console.WriteLine("Hello, World!");
// Random dice = new Random(); //equivalent à :
// Random dice2 = new();
// int roll = dice.Next();
// Console.WriteLine(roll);

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

