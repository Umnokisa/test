string[] n;
Console.WriteLine("Введите массив строк через пробел");
string? line = Console.ReadLine();
n = line.Split(' ');
var result = new string[n .Length];
var size = 0;
 foreach (var value in n )
{
     if (value.Length <= 3)
    {
        result[size] = value;
        size++;
    }
}
Console.WriteLine("Только эти с не более чем тремя символами:");
Console.WriteLine(string.Join(Environment.NewLine, result, 0, size));
