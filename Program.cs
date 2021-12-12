ulong
    n = 0,
    a_min = 1, b_min = 1, c_min = 1,
    a_max = 1000, b_max = 1000, c_max = 1000;

double d, e, f, g;

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
                        Console.WriteLine(value: $"{n} = {{a: {a}, b: {b}, c: {c}}}");

                        g = Math.Sqrt(d: Math.Pow(x: a, y: 2) + Math.Pow(x: b, y: 2) + Math.Pow(x: c, y: 2));
                        if ((g % 1) == 0)
                        {
                            //n++;
                            Console.WriteLine(value: $"{n} = {{a: {a}, b: {b}, c: {c}; d: {Math.Round(a: (double)g)}}}");
                        }
                    }
                }
            }
        }
    }
}