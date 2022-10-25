//On this challange I am adding two numbers that the user will input.


int myNum;
int myNum2;
string playAgain = "Y";
bool ValidNum;
bool ValidNum2;

//This displays to the user to prompt an input.
Console.WriteLine("We will add 2 numbers.");

while(playAgain != "N")
{
    Console.WriteLine("Please type a number.");

    ValidNum = int.TryParse(Console.ReadLine(), out myNum);
    
    if(!ValidNum)
    {
        Console.WriteLine("Please enter a valid number.");
    }


    else
    {
        //This stores and converts
        // int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please type another number.");
        ValidNum2 = int.TryParse(Console.ReadLine(), out myNum2);

        if(!ValidNum2)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        

        // int number2 = Convert.ToInt32(Console.ReadLine());
        else
        {
             //This adds the two numbers using interpolation.
            Console.WriteLine($"Your answer is {myNum + myNum2}.");

            Console.WriteLine("Do you want to play again? Y/N");
            playAgain = Console.ReadLine().ToUpper();
        }
       

    }
    
}

Console.WriteLine("Bye!");