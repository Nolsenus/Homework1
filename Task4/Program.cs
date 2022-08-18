Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write(a + ", " + b + ", " + c + " -> ");
if (a >= b) {
    if (a >= c) {
        Console.WriteLine(a);
    }
    else {
        Console.WriteLine(c);
    }
}
else if (b >= c) {
    Console.WriteLine(b);
}
else {
    Console.WriteLine(c);
}