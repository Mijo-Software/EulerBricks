//string length;

const ulong max = 1000;

ulong
    n = 0, i = 0,
    a_min = 1, b_min = 1, c_min = 1,
    a_max = max, b_max = max, c_max = max;

double d, e, f, g;

Console.WriteLine(value: "EulerBricks");
Console.Write(value: "Input the length of the run (default=1000, hit ENTER): ");
string length = Console.ReadLine();
if (ulong.TryParse(s: length, result: out a_max))
{
    b_max = c_max = a_max;
}
else
{
    Console.WriteLine(value: "Default value loaded!");
    a_max = b_max = c_max = max;
}

for (ulong a = a_min; a < a_max; a++)
{
    for (ulong b = b_min; b < b_max; b++)
    {
        for (ulong c = c_min; c < c_max; c++)
        {
            d = Math.Sqrt(d: Math.Pow(x: a, y: 2) + Math.Pow(x: b, y: 2));
            if ((d % 1) == 0)
            {
                e = Math.Sqrt(d: Math.Pow(x: a, y: 2) + Math.Pow(x: c, y: 2));
                if ((e % 1) == 0)
                {
                    f = Math.Sqrt(d: Math.Pow(x: b, y: 2) + Math.Pow(x: c, y: 2));
                    if ((f % 1) == 0)
                    {
                        n++;
                        if (a <= b && a <= c && b <= c)
                        {
                            i++;
                            Console.WriteLine(value: $"{n}|{i} = {{a: {a}, b: {b}, c: {c}}}{{d: {Math.Round(a: (double)d)}, e: {Math.Round(a: (double)e)}, f: {Math.Round(a: (double)f)}}}");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(value: $"{n}|{i} = {{a: {a}, b: {b}, c: {c}}}{{d: {Math.Round(a: (double)d)}, e: {Math.Round(a: (double)e)}, f: {Math.Round(a: (double)f)}}}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        g = Math.Sqrt(d: Math.Pow(x: a, y: 2) + Math.Pow(x: b, y: 2) + Math.Pow(x: c, y: 2));
                        if ((g % 1) == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(value: $"{n}|{i} = {{a: {a}, b: {b}, c: {c}}}{{d: {Math.Round(a: (double)d)}, e: {Math.Round(a: (double)e)}, f: {Math.Round(a: (double)f)}}}{{g: {Math.Round(a: (double)g)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
            }
        }
    }
}