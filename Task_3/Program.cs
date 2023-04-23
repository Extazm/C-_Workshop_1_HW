Console.WriteLine ("Введите число, чтобы узнать чётность");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) {
    Console.Write(number);
    Console.Write(" - является чётным числом");
}
else {
    Console.Write(number);
    Console.Write(" - является нечётным числом");
}
