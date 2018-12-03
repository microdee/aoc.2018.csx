int result = 0;
while(true)
{
    var input = Console.ReadLine();
    result += int.Parse(input.Replace("+", ""));
    Console.WriteLine(result);
}