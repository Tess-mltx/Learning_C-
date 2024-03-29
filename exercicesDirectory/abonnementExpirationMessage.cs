// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discoutPercentage = 0;

// // Discount
// if (daysUntilExpiration <= 5)
// {
//     if (daysUntilExpiration == 1)
//     {
//         discoutPercentage = 20;
//     } else
//     {
//         discoutPercentage = 10;
//     }
// }

// // Display message
// if (daysUntilExpiration <= 10)
// {
//     if (daysUntilExpiration <= 5)
//     {
//         if (daysUntilExpiration == 1)
//         {
//             if (daysUntilExpiration == 0)
//             {
//                 Console.WriteLine("Your subscription has expired.");
//             } else
//             {
//                Console.WriteLine($"Your subscription expires within a day! Renew now and save {discoutPercentage}%!");
//             }
//         } else
//         {
//             Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discoutPercentage}%!");
//         }
//     } else
//     {
//         Console.WriteLine("Your subscription will expire soon. Renew now!");
//     }
// }