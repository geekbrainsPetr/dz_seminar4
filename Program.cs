// Массив по заданным : длинне, миниальноиму и максимальному значениям

/*
int [] CreateRandomArray(int size, int MinValve , int maxValve )
{
    int [] MArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        MArray[i] = new Random().Next(MinValve, maxValve + 1);
    }
    return MArray;

}

void ShowArray(int[] array)
{
    Console.WriteLine("массив");
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}

Console.WriteLine("введите размер массива");
int a  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение массива");
int min  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите макси мальное число массива");
int max  = Convert.ToInt32(Console.ReadLine());
int [] MArray = CreateRandomArray(a, min, max);




ShowArray(MArray);
*/


//Введенное число А в введенной степени Б

/*

Console.WriteLine("введите основание ");
int a  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите показатель степени");
int b = Convert.ToInt32(Console.ReadLine());

int step = a;

for ( int i =1; i< b; i++)
{
step = step * a;

//return vozvodimoe;
}
Console.WriteLine($" число  {a}  в степени {b}  -> {step}");


*/


//Программа принимающая на вход число и выдающаяя сумму цифр
 

 Console.WriteLine("введите число ");
int dig  = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = dig;
while ( i > 0)
{
    int num =  i % 10;
    i =  i / 10;
    sum = sum + num;
}

Console.WriteLine($" сумма цифр в числе {dig} равна  {sum}");