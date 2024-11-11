//Task one. Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa
// 1.Kalkulyator

System.Console.WriteLine("Arifmetik amallarni bajaramiz!");
System.Console.Write("Birinchi sonni kiriting:");
double number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Arifmetik amallardan birini tanlang (+,-,*,/)");
string? symbol = Console.ReadLine();
System.Console.Write("Ikkinchi sonni kiriting:");
double number2 = Convert.ToInt32(Console.ReadLine());
if(symbol=="+")
{
    System.Console.WriteLine($"{number1}+{number2} == {number1+number2}");
}
else if(symbol=="-")
{
    System.Console.WriteLine($"{number1}-{number2} == {number1-number2}");
}
else if(symbol=="*")
{
    System.Console.WriteLine($"{number1}*{number2} == {number1*number2}");
}
else if(symbol=="/")
{
    System.Console.WriteLine($"{number1}/{number2} == {number1/number2}");
}
else
{
    System.Console.WriteLine("404 Not found!");
}

// 2.Raqamlar qatorining yig‘indisini hisoblash:
System.Console.Write("Musbat sonni kiriting:");
double n = Convert.ToInt32(Console.ReadLine());
if(n > 0)
{
    double formula = (n*(n+1))/2;
    System.Console.WriteLine($"1 dan {n} gacha bo'lgan sonlarning yig'indisi {formula}");
}
else
{
    System.Console.WriteLine("Not found! (Musbat sonni kiriting!)");
}

// 3.Paritet tekshiruvi:
System.Console.Write("Input:");
int a = Convert.ToInt32(Console.ReadLine());
if(a%2==0)
{
    System.Console.WriteLine("Juft");
}
else 
{
    System.Console.WriteLine("Toq");
}