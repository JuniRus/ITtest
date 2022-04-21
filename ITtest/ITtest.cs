// Простейший тест на проверку IQ в сфере IT

using System;
class IQtest
{
    static void Main()
    {
        int curAnswers = 0; // верно
        int wrAnswers = 0;  // неверно
        int answear;        // ответ на вопрос
        bool flag = true;   // флаг для цикла
        string question;    // Вопрос для продолжения программы

        // Запуск программы
        while(flag)
        {
            Console.Clear();
            Console.WriteLine("Вам предстоит ответить на 10 вопросов, " +
                          "что сможет определить ваш уровень IQ в сфере IT!\n");


            Console.WriteLine("Вопрос №1: " +
                              "Дайте расшифровку определению ООП в IT.");
            Console.WriteLine("Варианты ответов:\n" +
                              "1. Основная образовательная программа\n" +
                              "2. Объектно ориентированное проектирование\n" +
                              "3. Основная оперативная память\n" +
                              "4. Объектно ориентированное программирование");
            
            // Предотвращение ошибок с вводом
            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            // Проверка ответа
            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    wrAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    curAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №2: " +
                              "Что выполняет оператор инкремента?");
            Console.WriteLine("Варианты ответов:\n" +
                              "1. Уменьшает операнд на единицу\n" +
                              "2. Увеличивает операнд на единицу\n" +
                              "3. Делит операнд на число\n" +
                              "4. Умножает операнд на число");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    curAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №3: " +
                              "Что такое инкапсуляция?");
            Console.WriteLine("Варианты ответов:\n" +
                              "1. Механизм программирования, связывающий классы" +
                              " и объекты\n" +
                              "2. Вывод данных на консоль\n" +
                              "3. Механизм программирования, объединяющий данные и код\n" +
                              "4. Двоичная операция, дающая ложное значение тогда,\n" +
                              "когда правый операнд имеет ложное значение,\n" +
                              "а левый истинное");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    wrAnswers++;
                    break;
                case 3:
                    curAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №4: " +
                              "Чем занимается фронтенд-разработчик?");
            Console.WriteLine("Варианты ответов:\n" +
                              "1. Занимется разработкой внешнего\n" +
                              "вида проекта\n" +
                              "2. Занимается серверной частью проекта\n" +
                              "3. Тестирует проект на работоспособность\n" +
                              "4. Отвечает за менеджмент проекта");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    curAnswers++;
                    break;
                case 2:
                    wrAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №5: " +
                              "От каких языков образован C#?");
            Console.WriteLine("Варианты ответов:\n " +
                              "1. От HTML и Java\n " +
                              "2. От С и C++\n " +
                              "3. От От CSS и Python\n " +
                              "4. ОТ C++ и Java");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    wrAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    curAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №6: " +
                              "какой язык программирования " +
                              "использует в своём синтаксисе " +
                              "только кириллицу?");
            Console.WriteLine("Варианты ответов:\n " +
                              "1. Python\n " +
                              "2. 1C\n " +
                              "3. C++\n " +
                              "4. JavaScript");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    curAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №7: " +
                              "с каким игровым движком " +
                              "чаще всего используется C#? ");
            Console.WriteLine("Варианты ответов:\n " +
                              "1. Unity\n " +
                              "2. Unreal Engen\n " +
                              "3. CryEngen\n " +
                              "4. GameMaker Studio\n ");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    curAnswers++;
                    break;
                case 2:
                    wrAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №8: " +
                              "Какой язык программирования появился " +
                              "раньше?");
            Console.WriteLine("Варианты ответов:\n " +
                              "1. Java\n " +
                              "2. Бейсик\n " +
                              "3. Паскаль\n " +
                              "4. C\n ");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    curAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №9: " +
                              "Кто изобрёл язык Python?");
            Console.WriteLine("Варианты ответов:\n " +
                              "1. Андерс Хейлсберг\n " +
                              "2. Джеймс Гослинг\n " +
                              "3. Брендан Эйх\n " +
                              "4. Гвидо ван Россум\n ");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры!");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    wrAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    curAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");


            Console.WriteLine("Вопрос №10: " +
                              "Укажите поразрядовый оператор 'или'");
            Console.WriteLine("Варианты ответов:\n " +
                              "1. '&'\n " +
                              "2. '|'\n " +
                              "3. '^'\n " +
                              "4. '~'\n ");

            try
            {
                Console.Write("Введите вариант ответа: ");
                answear = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: вы ввели строку вместо цифры");
                Console.ReadLine();
                continue;
            }

            switch (answear)
            {
                case 1:
                    wrAnswers++;
                    break;
                case 2:
                    curAnswers++;
                    break;
                case 3:
                    wrAnswers++;
                    break;
                case 4:
                    wrAnswers++;
                    break;
                default:
                    wrAnswers++;
                    break;
            }
            Console.WriteLine("\n");

            // Конец программы. Итоги.
            Console.WriteLine("Ваши результаты: ");

            if (curAnswers > 7 & curAnswers <= 10)
            {
                Console.WriteLine($"У вас {curAnswers} правильных " +
                              $"ответов!");
                Console.WriteLine("Вы отлично разбиратесь в IT!");
            }
            else if (curAnswers > 5 & curAnswers <=7)
            {
                Console.WriteLine($"У вас {curAnswers} правильных " +
                              $"ответов!");
                Console.WriteLine("Вы неплохо разбиратесь в IT.");
            }

            else if (curAnswers > 3 & curAnswers <= 5)
            {
                Console.WriteLine($"У вас {curAnswers} правильных " +
                              $"ответов!");
                Console.WriteLine("Вы относительно неплохо разбиратесь в IT.");
            }

            else if (curAnswers >= 0 & curAnswers <=3)
            {
                Console.WriteLine($"У вас {curAnswers} правильных " +
                              $"ответов!");
                Console.WriteLine("Вы плохо разбиратесь в IT.");
            }
            
            // Возможное завершение цикла
            Console.Write("Продолжить? (введите 'no' если нет): ");
            question = Console.ReadLine();

            if(question == "no")
            {
                flag = false;
            }
            // Обнуление ответов для предотвращения логических ошибок.
            curAnswers = 0;
        }
        Console.ReadLine();
    }
}   