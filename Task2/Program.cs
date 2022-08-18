Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ещё одно число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("a = " + a + "; b = " + b + " -> max = ");
if (a >= b) {
    Console.WriteLine(a);
}
else {
    Console.WriteLine(b);
}