// See https://aka.ms/new-console-template for more information

//class Lesson1
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, Wolrd !");
//        string? input = Console.ReadLine();
//        Console.WriteLine("Hello, " + input + "!");

//        Console.WriteLine("My name is:");
//        string? firstInput = Console.ReadLine();

//        Console.WriteLine("");
//        string? secondInput = Console.ReadLine();

//        // Print the inputs on separate lines
//        Console.WriteLine($"{firstInput}\n{secondInput}");
//    }
//}

//using Microsoft.VisualBasic;

class Lesson2
{
    private static void Main()
    {
        string player_name = "John Doe";
        Console.WriteLine("My name is:" + player_name);

        int enemy_health = 100; //số nguyên 32bit
        Console.WriteLine("Enemy health:" + enemy_health);

        float speed = 105.5f; //số thực 32bit
        Console.WriteLine("Speed:" + speed);

        char patrol_state = 'S';
        Console.WriteLine("Standby:" + patrol_state);

        bool isalive = true;  //bool có 2 giá trị là true or false
        if (isalive)
        {
            Console.WriteLine("Alive");
        }

        double game_currency = 2500.50; //kiểu double là float nhưng có thể biểu diễn số rất lớn hoặc rất nhỏ (64bit), độ chính xác cao
        Console.WriteLine(game_currency);

        byte player_age = 25; //số nguyên 8bit giới hạn giá trị từ 0 đến 255
        Console.WriteLine("player_age:" + player_age);

        long score = 100000000000; //long giống int nhưng phạm vi rộng hơn(64bit) từ -2^63 đến 2^63
        Console.WriteLine("score =" + score);

        decimal price = 100.50M; //tương tự float, double nhưng 128bit
        Console.WriteLine("price =" + price);

        string? null_variable = null;
        Console.WriteLine(null_variable);

        piValue();
        CompanyNmae();
        MaxRetries();
        AccelerationOfGravity();
    }

    private static void piValue()
    {
        const double pi = 3.14159;
        Console.WriteLine("pi = " + pi);
    }

    static void CompanyNmae()
    {
        const string CompanyName = "ABC Corporation";
        Console.WriteLine("CompanyName = " + CompanyName);
    }

    static void MaxRetries()
    {
        const int MaxRetries = 3;
        Console.WriteLine("MaxRetries: " + MaxRetries);
    }

    static void AccelerationOfGravity()
    {
        const double Gravity = 9.8;
        Console.WriteLine("g =: " + Gravity + "m/s");
    }
}