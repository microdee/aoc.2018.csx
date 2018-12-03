int result = 0;
bool searching = false;
var indeltas = new LinkedList<int>();
var results = new HashSet<int>();
results.Add(0);

void CheckResult(int res)
{
    if(results.TryGetValue(res, out var hres))
    {
        Console.WriteLine("Found frequency: " + hres);
        Environment.Exit(0);
    }
    else
    {
        results.Add(res);
    }
}

while(true)
{
    var input = "";
    if(!searching)
    {
        input = Console.ReadLine();
        //if(input.Equals("e", StringComparison.InvariantCultureIgnoreCase)) searching = true;
        if(string.IsNullOrWhiteSpace(input)) searching = true;
    }
    if(searching)
    {
        foreach(var delta in indeltas)
        {
            result += delta;
            CheckResult(result);
        }
    }
    else
    {
        var delta = int.Parse(input.Replace("+", ""));
        indeltas.AddLast(delta);
        result += delta;
        Console.WriteLine(result);
        CheckResult(result);
    }
}