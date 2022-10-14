// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Решение задачи 2:
/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2){
    Console.WriteLine($"{num1} больше, чем {num2}");
    }
else{
    Console.WriteLine($"{num2} больше, чем {num1}");
    }
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Решение задачи 4:
/*
Console.Write("Input first int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input three int number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max < num2){
    max = num2;
    }
if (max < num3){
    max = num3;
    }
Console.WriteLine($"{max} наибольшее из введенных чисел");   
*/
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Решение задачи 6:
/*
Console.Write("Input int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int result = (num1 % 2);
if(result == 0){
    Console.WriteLine($"Число {num1} является четным");
    }
else{
    Console.WriteLine($"Число {num1} не является четным"); 
}   
*/    
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Решение задачи 8:
/*
Console.Write("Input int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int current = (0) * num1 + (1);

for(int i = current; i<num1 + (1); i++){
    int result = (i % 2);
    if(result == 0){
    Console.WriteLine(i);   
    }
    }
*/