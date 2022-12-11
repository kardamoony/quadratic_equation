namespace QuadraticEquation.Core
{
    public static class Solution
    {
        private const string NotValidNumberMssg = "One of the arguments is not a valid number";
        private const string FirstArgumentIsZeroMssg = "First argument can't be zero";
        
        public static double[] Solve(double a, double b, double c)
        {
            if (!ValidateArguments(a, b, c, out var msg))
            {
                throw new ArgumentException(msg);
            }
            
            var d = b * b - 4 * a * c;

            if (d < 0)
            {
                return Array.Empty<double>();
            }

            if (d > 0)
            {
                var sqrtD = Math.Sqrt(d);

                return new[]
                {
                    (-b - sqrtD) / (2 * a),
                    (-b + sqrtD) / (2 * a)
                };
            }

            return new []{ -b / (2 * a) };
        }
        
        private static bool ValidateArguments(double a, double b, double c, out string msg)
        {
            if (!a.IsValidNumber() || !b.IsValidNumber() || !c.IsValidNumber())
            {
                msg = NotValidNumberMssg;
                return false;
            }

            if (Math.Abs(a) < double.Epsilon)
            {
                msg = FirstArgumentIsZeroMssg;
                return false;
            }

            msg = string.Empty;
            return true;
        }

        private static bool IsValidNumber(this double x)
        {
            return !double.IsInfinity(x) && !double.IsNaN(x);
        }
    }
}

