//24
//В массиве хранится информация о баллах,
//полученных спортсменом-десятиборцем в каждом из десяти видов спорта.
//Для выхода в следующий этап соревнований общая сумма баллов должна превысить некоторое известное значение.
//Определить, вышел ли данный спортсмен в следующий этап соревнований.
class Program
{
    static bool HasQualifiedForNextStage(int[] scores, int requiredScore)
    {
        int totalScore = 0;
        foreach (int score in scores)
        {
            totalScore += score;
        }

        return totalScore > requiredScore;
    }

    static void Main()
    {
        Console.Write("Введите количество видов спорта: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfSports) && numberOfSports > 0)
        {
            int[] scores = new int[numberOfSports];

            Console.WriteLine("Введите баллы спортсмена для каждого вида спорта:");

            for (int i = 0; i < numberOfSports; i++)
            {
                Console.Write($"Баллы для видa спорта {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int score))
                {
                    scores[i] = score;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                    i--;
                }
            }

            Console.Write("Введите минимальное количество баллов для выхода в следующий этап: ");
            if (int.TryParse(Console.ReadLine(), out int requiredScore))
            {
                bool hasQualified = HasQualifiedForNextStage(scores, requiredScore);

                if (hasQualified)
                {
                    Console.WriteLine("Спортсмен вышел в следующий этап соревнований.");
                }
                else
                {
                    Console.WriteLine("Спортсмен не вышел в следующий этап соревнований.");
                }
            }
            else
            {
                Console.WriteLine("Некорректное значение баллов для выхода в следующий этап.");
            }
        }
        else
        {
            Console.WriteLine("Некорректное количество видов спорта.");
        }

        Console.ReadLine();
    }
}