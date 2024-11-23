(double a, double b)[] parameters = new (double, double)[]
        {
            (6, 3.2),
            (3, 6),
            (2.7, 1.8)
        };

        foreach (var (a, b) in parameters)
        {
            
            double[] xValues = { -2, -0.5, 3 }; 
            foreach (double x in xValues)
            {
                double z = Math.Exp(1.5 * a * x); 

                double y = CalculateY(a, b, x, z);
                Console.WriteLine($"Для a = {a}, b = {b}, x = {x}, y = {y}");
            }
        }
    

  double CalculateY(double a, double b, double x, double z)
{
    double lnA = Math.Log(Math.Abs(a));

    if (x < -lnA)
    {

        return Math.Pow((3.5 * a - 7.3 * b * x + Math.Sin(z * x)), 3);
    }
    else if (x >= -lnA && x < b)
    {

        return Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
    }
    else
    {

        return Math.Sqrt(Math.Abs(Math.Cos(a + b * x)) + (z * Math.Pow(x, 2)));
    }
}
