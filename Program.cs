//// see https://aka.ms/new-console-template for more information
//console.writeline("hello, world!");

//////string name = "vans";
//////int age = 18;
//////bool study = true;
//////double massa = 85.15;

//////console.writeline($"имя: {name}");
//////console.writeline($"имя: {age}");
//////console.writeline($"имя: {study}");
//////console.writeline($"имя: {massa}");

//////console.writeline("введите два числа:");
//////int x = convert.toint32(console.readline());
//////int y = convert.toint32(console.readline());
//////x = x + y;
//////console.writeline(x);

////using System;

////console.writeline("привет мир!");
////console.writeline("добро пожаловать в c#!");
////console.writeline("пока мир");
////double massa = 85.15;
////console.writeline("введите два числа:");
////int x = convert.toint32(console.readline());
////int y = convert.toint32(console.readline());
////int s = convert.toint32(console.readline());
////int f = convert.toint32(console.readline());

////int number1 = 6;
////int number2 = 7;

////if (number1 > number2)
////{
////    Console.WriteLine($"число {number1} > {number2}");

////}
////else
////{
////    Console.WriteLine($"Число {number1} < {number2}");
////}
//using System
//console.writeline("введите два числа:");




//Console.WriteLine("Введите номер операции:");
//Console.WriteLine("1. Сложение");
//Console.WriteLine("2. Вычитание");
//Console.WriteLine("3. Умножение");
//Console.WriteLine("4. Деление");

//string input = Console.ReadLine();

//if (int.TryParse(input, out int choice))
//{
//    Console.Write("Введите первое число: ");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.Write("Введите второе число: ");
//    int num2 = int.Parse(Console.ReadLine());

//    double result;
//    switch (choice)
//    {
//        case 1:
//            result = num1 + num2;
//            Console.WriteLine($"Результат: {num1} + {num2} = {result}");
//            break;
//        case 2:
//            result = num1 - num2;
//            Console.WriteLine($"Результат: {num1} - {num2} = {result}");
//            break;
//        case 3:
//            result = num1 * num2;
//            Console.WriteLine($"Результат: {num1} * {num2} = {result}");
//            break;
//        case 4:
//            if (num2 == 0)
//            {
//                Console.WriteLine("Ошибка: Деление на 0");
//            }
//            else
//            {
//                result = (double)num1 / num2;
//                Console.WriteLine($"Результат: {num1} / {num2} = {result}");
//            }
//            break;
//    }
//}



//Console.WriteLine("Введите номер операции:");
//Console.WriteLine("1. Сложение");
//Console.WriteLine("2. Вычитание");
//Console.WriteLine("3. Умножение");
//Console.WriteLine("4. Деление");

//string input = Console.ReadLine();

//if (int.TryParse(input, out int choice))
//{
//    Console.Write("Введите первое число: ");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.Write("Введите второе число: ");
//    int num2 = int.Parse(Console.ReadLine());

//    double result = 0; // Инициализация результата

//    switch (choice)
//    {
//        case 1:
//            result = num1 + num2;
//            break;
//        case 2:
//            result = num1 - num2;
//            break;
//        case 3:
//            result = num1 * num2;
//            break;
//        case 4:

//                result = (double)num1 / num2;
//            break;
//        default:
//            validOperation = false; // Неверный номер операции
//            break;
//    }

//    if (validOperation)
//    {
//        Console.WriteLine($"Результат: {result}");
//    }
//}
//else
//{
//    // Ничего не делаем, если ввод был некорректным
//}


start:
Console.WriteLine("Введите номер операции:");
Console.WriteLine("1. Сложение");
Console.WriteLine("2. Вычитание");
Console.WriteLine("3. Умножение");
Console.WriteLine("4. Деление");

string input = Console.ReadLine();
int choice;
bool coc = int.TryParse(input, out choice);
char sos;

if (coc)
{
    Console.Write("Введите первое число: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = int.Parse(Console.ReadLine());

    double result = 0;
    bool penist = true;

    switch (choice)
    {
        case 1:
            result = num1 + num2;
            Console.WriteLine($"результат: {result}");
            Console.WriteLine(" ");
            goto start;
        case 2:
            result = num1 - num2;
            Console.WriteLine($"результат: {result}");
            goto start;
        case 3:
            result = num1 * num2;
            Console.WriteLine($"результат: {result}");
            goto start;
        case 4:
            if (num2 == 0)
            {
                if(num2 == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    penist = false;
                    Console.WriteLine($"результат: {result}");
                }
            }
            else
            {
                result = (double)num1 / num2;
                Console.WriteLine($"результат: {result}");
            }
            goto start; ;

    }
}








