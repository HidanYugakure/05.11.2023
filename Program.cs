#region 1ci task
//1) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
//int num1 = 1;
//int num2 = 50;
//int counter = 0;
//string Numbers(int x, int y, int counter)
//{
//    for (int i = x; i < y; i++)
//    {
//        if (i % 2 == 1)
//        {
//            counter += i;
//        }

//    }
//    return ($"{counter} bunlarin cemidir");
//}

//Console.WriteLine(Numbers(num1, num2, counter));
#endregion
#region 2ci task
//2)Verilmish arrayin icindeki tek ededlerin cemini tapin.
//int[] numbers = { 3,45,85,24,5,8,47,30 };
//int counter2 = 0;

//string NumbersArray(int[] numbers, int counter)
//{
//    foreach (int n in numbers)
//    {
//        if (n % 2 == 1)
//        {
//            counter += n;
//        }
//    }
//    return ($"{counter}bunlarin cemini ifade dir");
//}
//Console.WriteLine(NumbersArray(numbers, counter2));
#endregion
#region 3cu task
//3)Verilmish arrayin icindeki cut ededlerin sayini tapin.
//int[] numbers2 = { 1, 5, 34, 22, 9, 7, 88, 9, 31, 14, 87 };
//int counter3 = 0;
//string NumbersBetweenEvenNumbers(int[] numbers, int counter)
//{
//    foreach (int n in numbers)
//    {
//        if (n % 2 == 0)
//        {
//            counter++;

//        }

//    }
//    return ($"cavab:{counter} ");
//}

//Console.WriteLine(NumbersBetweenEvenNumbers(numbers2, counter3));
#endregion;
#region 4cu task
//4) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
//int num = 85;
//int counter4 = 0;
//void SimpleAndComplex(int num1, int counter)
//{
//    for (int i = 1; i < num1; i++)
//    {
//        if (num1 % i == 0)
//        {
//            counter++;
//        }
//    }
//    if (counter > 2)
//    {
//        Console.WriteLine("bu murekkebdir");

//    }
//    else
//    {
//        Console.WriteLine("sade");
//    }

//}
//SimpleAndComplex(num, counter4);
#endregion
#region 6ci task
//6)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18).
//int[] numbers3 = { 1, 7, 75, 77, 33 };
//int counter5 = 1;
//string SumOf(int[] numbers3, int counter)
//{
//    foreach (int num3 in numbers3)
//    {
//        if (num3 <= 20)
//        {
//            counter *= num3;
//        }
//    }
//    return ($"cavab:{counter}");
//}
//Console.WriteLine(SumOf(numbers3, counter5));
#endregion
#region 7ci task
//7)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
//int[] numbers4 = { 1, 22, 3, 45, 66, 7, 6, 9, 12 };
//int counter6 = 0;
//int EvenNumbers(int[] numbers, int counter)
//{
//    foreach (int num in numbers)
//    {
//        if (num % 2 == 0)
//        {

//            counter += num;
//        }
//    }
//    return counter * counter;
//}

//Console.WriteLine(EvenNumbers(numbers4, counter6));
#endregion
#region 8ci task
//int[] Numbers7 = { -7, 15, -3, -7, -8, 10 };

//void NegativeOneToPostive(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] < 0)
//        {
//            numbers[i] *= -1;
//            Console.WriteLine(numbers[i]);

//        }

//    }

//}
//NegativeOneToPostive(Numbers7);

#endregion