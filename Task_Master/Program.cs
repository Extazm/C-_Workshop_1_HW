Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.Write("Наибольшее число - ");
    Console.Write(a);

}    
else if (a < b) {
    Console.Write("Наибольшее число - ");
    Console.Write(b);
}
else {
    Console.WriteLine("числа равны");
}
//Вот и всё

