// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Middig(int number)                   //метод поиска сдерлей цифры из трехзначного числа
{
    int mid = number % 100;              //отделяем последние 2 цифры
    mid = mid / 10;                      //из оставшихся двух убираем последюю
    return mid;                          //возвращаем среднюю цифру
}


int random_number = new Random().Next(100,1000); //получаем трехзначное число 
int middl_digit = Middig(random_number) ;        //вызывем метод
Console.WriteLine($"Среднее цифра из числа {random_number} является {middl_digit}");//вывод на экран
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int Third_dig (int number)                               // метод нахождения третьей цифры
{
    int third = number % 10;                             // находим тупо последнюю цифру
    return third;                                        // возвращаем
}


int random_number = new Random().Next(10,1000);          // получаем число 2-х или 3-х значное 
if (random_number<100)                                   // делаем условие если меньше 3-х разрядов то пишем что треьей цифры не существует
{
    Console.WriteLine("Третьей цифры не существует");    // вывод на экран
}
else                                                     // иначе
{
int third_digit = Third_dig(random_number) ;             //вызывем метод
Console.WriteLine($"Третья цифра из числа {random_number} является {third_digit}"); //вывод на экран
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string[]array = {"nulevoy","Monday - working day","Tuesday - working day","Wednesday - working day",
                  "Thursday - working day","Friday - working day","Saturday - Relax take it easy","Sanday - Relax take it easy"};       // объявление массива (string)
// можно было просто  ввести данные  (readln) и применяя условия определить день выходной или нет, но здесь применен массив так как тема семинара массивы

int Readday()                            // метод с пустым аргументом можно было и без него но тема урока такова что решил его использовать
{
    Console.WriteLine("Введите номер дня недели");
    int num_day_of_week = Convert.ToInt32(Console.ReadLine());
    return num_day_of_week;
}
int num_day_of_week = Readday();         // присваиваем переменной num_day_of_week результат применения метода (содержимое return) если честно долго парился пока догадался потом посмотрел лекции там также присваивается

Console.WriteLine(array[num_day_of_week]); //выдаем день недели                              


