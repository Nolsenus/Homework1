Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a + " -> ");
if (a % 2 == 0) {
    Console.WriteLine("Да");
}
else {
    Console.WriteLine("Нет");
}