//On this challange I am adding two numbers that the user will input.


string playAgain = "Y";

//This displays to the user to prompt an input.
Console.WriteLine("We will add 2 numbers.");

while(playAgain != "N")
{

    Console.WriteLine("Please type a number.");


    //This stores and converts
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please type another number.");

    int number2 = Convert.ToInt32(Console.ReadLine());

    //This adds the two numbers using interpolation.
    Console.WriteLine($"Your answer is {number1 + number2}.");

    Console.WriteLine("Do you want to play again? Y/N");
    playAgain = Console.ReadLine().ToUpper();

}

Console.WriteLine("Bye!");