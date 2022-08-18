Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a + " -> ");

// Версия с форматированием как в задании
int i;
for(i = 2; i <= a - 2; i += 2) {
    Console.Write(i + ", ");
}
Console.WriteLine(i);

// Упрощённая версия
// for(int i = 2; i <= a; i += 2) {
//     Console.Write(i + " ");
// }