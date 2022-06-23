    //Squared Method
    static double Squared(int num)
    {
        return Math.Pow(num, 2);
    }
    //Cubed Method
    static double Cubed(int nums)
    {
        return Math.Pow(nums, 3);
    }

    //Intro
    Console.WriteLine("Welcome! Come learn some squares and cubes!");
while (true)
{ 
    Console.WriteLine("Enter an integer between 1-1289");
    int input = int.Parse(Console.ReadLine());

    //Reject 0 Maximum 1290 cube
    while (input <= 0 || input >= 1290)
    {
        Console.WriteLine("Incorrect. Please enter a different value");
        input = int.Parse(Console.ReadLine());
    }

    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Normal", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "=======", "=======", "====="));

    //Valid data
    for (int i = 1; i <= input; i++)
    {
        
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, Squared(i), Cubed(i)));
  
    }
    //Loop
    Console.WriteLine("Continue y/n?");
    string rerun = Console.ReadLine();

    if (rerun == "y")
    {
        continue;
    }
    else
    {
        break;
    }
}








//double squared = input * input;
//double cubed = input * input * input; 
//Console.WriteLine(squared);
//Console.WriteLine(cubed);