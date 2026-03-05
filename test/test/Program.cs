namespace Test // Определяем пространство имен Test.
{
    internal class Program // Объявляем внутренний класс Program.
    {
        static void Main(string[] args) // Главный метод программы.
        {
            int number = GenerateRandomNumber(); // Генерируем случайное число и сохраняем его в переменной number.
            PlayGame(number); // Запускаем игру, передавая загаданное число.
        }

        static int GenerateRandomNumber() // Метод для генерации случайного числа от 1 до 100.
        {
            Random rnd = new Random(); // Создаем объект Random.
            return rnd.Next(1, 101); // Возвращаем случайное число от 1 до 100.
        }

        static void PlayGame(int number) // Метод для основной логики игры.
        {
            while (true) // Начинаем бесконечный цикл для игры.
            {
                Console.WriteLine("Input number from [1;100]"); // Запрашиваем ввод числа у пользователя.

                int userNumber = GetUserInput(); // Получаем ввод пользователя.

                if (userNumber == -1) // Если пользователь ввел некорректные данные три раза подряд...
                {
                    Console.WriteLine("You are stupid"); // Сообщаем пользователю об ошибке.
                    return; // Завершаем выполнение программы.
                }

                // Сравниваем введенное пользователем число с загаданным числом.
                if (userNumber > number)
                    Console.WriteLine("Your number is greater"); // Если введенное число больше загаданного.
                else if (userNumber < number)
                    Console.WriteLine("Your number is less"); // Если введенное число меньше загаданного.
                else
                {
                    Console.WriteLine("You are win"); // Если числа совпадают, сообщаем о победе.
                    break; // Выходим из игрового цикла.
                }
            }
        }

        static int GetUserInput() // Метод для получения ввода от пользователя с проверкой.
        {
            int userNumber = 0; // Объявляем переменную для хранения введенного числа.

            for (int i = 0; i < 3; i++) // Позволяем пользователю ввести число до 3 раз.
            {
                if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber >= 1 && userNumber <= 100)
                {
                    return userNumber; // Если ввод корректный, возвращаем введенное число.
                }
                else
                {
                    Console.WriteLine("Input number from [1;100]"); // Если ввод некорректный, просим ввести число снова.
                }
            }

            return -1; // Возвращаем -1, если пользователь допустил ошибки три раза подряд.
        }
    }
}
