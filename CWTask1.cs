//вариант 14 номер 1
using System;

struct GuessGame
{
    public int hiddenNumber;
    public bool isGuessed;
    public int attempts;
    public int record;

    public void GuessNumber(int number)
    {
        attempts++;

        if (number == hiddenNumber)
        {
            isGuessed = true;
            if (attempts < record)
            {
                record = attempts;
            }
            
            Console.WriteLine($"Поздравляем! Вы угадали число {hiddenNumber} за {attempts} попыток!");
            Console.WriteLine($"Ваш новый рекорд: {record}");
        }
        else if (number < hiddenNumber)
        {
            Console.WriteLine("Загаданное число больше.");
        }
        else
        {
            Console.WriteLine("Загаданное число меньше.");
        }
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();
        GuessGame game = new GuessGame();
        game.hiddenNumber = random.Next(0, 11);
        game.isGuessed = false;
        game.attempts = 0;
        game.record = Int32.MaxValue;

        while (!game.isGuessed)
        {
            Console.Write("Введите число от 0 до 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            game.GuessNumber(number);
        }
    }
}