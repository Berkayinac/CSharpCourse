//Add();
//Add();
//Add();
//Add();
//var result = Add2();

//int number1;
//int number2 = 100;
//var result2 = Add3(out number1, number2);

//Console.WriteLine(result2);
//Console.WriteLine(number1);

Console.WriteLine(MultiplyClass.Multiply(2, 4));
Console.WriteLine(MultiplyClass.Multiply(2, 4, 5));

Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
Console.ReadLine();


void Add()
{
    Console.WriteLine("Added!!!");
}

int Add2(int number1 = 20, int number2 = 30)
{
    var result = number1 + number2;
    return result;
}

int Add3(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;
}

int Add4(int number, params int[] numbers)
{
    return numbers.Sum();
}

// console app içerisinde overloading'e izin verilmediğinden 
// yeni bir class oluşturup static halde metotları erişime açtım.
public class MultiplyClass
{
    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public static int Multiply(int number1, int number2, int number3)
    {
        return number1 * number2 * number3;
    }
}
