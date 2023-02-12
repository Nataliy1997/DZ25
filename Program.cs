//  Напишите функцию, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.Нельзя использовать библиотеку Math!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
void main()
{
    Console.Clear();
    Console.WriteLine("Введи число А: ");
    int A=int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введи число B: ");
    int B=int.Parse(Console.ReadLine()!);
    int pow=Stepen(A,B);
    Console.Write(pow);
}
int Stepen(int A, int B)
{
    int result=1;
    for (int count=1;count<=B;count++)
    {
        result=result*A;
    }
    return result;
}
main();