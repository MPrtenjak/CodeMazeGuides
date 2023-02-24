using DifferentTypesOfCommentsInCSharp;

// TODO: Ask a user for the number of repetitions
for (int number = 0; number <= 15; number++)
{
    var result = SingleLineComments.Factorial(number);

    // TODO: Use colors for more excellent output
    Console.WriteLine($"Factorial of {number,3} is {result,14}");
}