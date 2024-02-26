using System.Text;

namespace CalcOne
{
    public class Util
    {
        public double First;
        public double Second;
        public double M1, M2, M3, M4, M5;
        public int RandLow = 0;
        public int RandHigh = 100;

        private Random rnd = new Random();

        public void Calculate()
        {
            while (true)
            {
                Console.Write("Operator? ");
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }

                string op = input.ToUpper().Trim();
                Process(op);
            }
        }

        /// <summary>
        /// Process Operator
        /// </summary>
        /// <param name="op">operator</param>
        private void Process(string op)
        {
            double result;
            string input;

            switch (op)
            {
                case "+":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = First + Second;
                    Console.WriteLine("{0} + {1} = {2}", First, Second, result);
                    First = result;
                    break;
                case "-":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = First - Second;
                    Console.WriteLine("{0} - {1} = {2}", First, Second, result);
                    First = result;
                    break;
                case "*":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = First * Second;
                    Console.WriteLine("{0} * {1} = {2}", First, Second, result);
                    First = result;
                    break;
                case "/":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    if (Second == 0.0)
                    {
                        Console.WriteLine("Divide By Zero");
                    }
                    result = First / Second;
                    Console.WriteLine("{0} / {1} = {2}", First, Second, result);
                    First = result;
                    break;
                case "%":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = First % Second;
                    Console.WriteLine("{0} % {1} = {2}", First, Second, result);
                    First = result;
                    break;
                case "=":
                    Console.WriteLine(First);
                    break;
                case "!":
                    result = Factorial(First);
                    Console.WriteLine("{0} ! = {1}", First, result);
                    First = result;
                    break;
                case "A":
                    result = Math.Abs(First);
                    Console.WriteLine("ABS({0}) = {1}", First, result);
                    First = result;
                    break;
                case "ACOS":
                    result = Math.Acos(First);
                    Console.WriteLine("ACOS({0}) = {1}", First, result);
                    First = result;
                    break;
                case "ASIN":
                    result = Math.Asin(First);
                    Console.WriteLine("ASIN({0}) = {1}", First, result);
                    First = result;
                    break;
                case "ATAN":
                    result = Math.Atan(First);
                    Console.WriteLine("ATAN({0}) = {1}", First, result);
                    First = result;
                    break;
                case "ALN":
                    result = Math.Exp(First);
                    Console.WriteLine("E ^ {0} = {1}", First, result);
                    First = result;
                    break;
                case "ALG":
                    result = Math.Pow(10, First);
                    Console.WriteLine("10 ^ {0} = {1}", First, result);
                    First = result;
                    break;
                case "B":
                    string str1 = Convert.ToString((int)First, 2);
                    Console.WriteLine("BIN({0}) = {1}", First, str1);
                    break;
                case "BIT":
                    string str2 = BinarySpaces(Convert.ToString((int)First, 2));
                    Console.WriteLine("BIT({0}) = {1}", First, str2);
                    break;
                case "C":
                    First = 0.0;
                    Second = 0.0;
                    Console.Clear();
                    return;
                case "CB":
                    result = First * First * First;
                    Console.WriteLine("{0} ^ 3 = {1}", First, result);
                    First = result;
                    break;
                case "CDF":
                    First = GetCDF();
                    break;
                case "CL":
                    result = Math.Ceiling(First);
                    Console.WriteLine("CL({0}) = {1}", First, result);
                    First = result;
                    break;
                case "CM":
                    Console.WriteLine("CM({0}) = {1}", First, First.ToString("N0"));
                    break;
                case "COS":
                    result = Math.Cos(First);
                    Console.WriteLine("COS({0}) = {1}", First, result);
                    First = result;
                    break;
                case "CR":
                    result = Math.Cbrt(First);
                    Console.WriteLine("CBRT({0}) = {1}", First, result);
                    First = result;
                    break;
                case "CSR":
                    First = GetCosineRule();
                    break;
                case "DEG":
                    result = Degrees(First);
                    Console.WriteLine("DEG({0}) = {1}", First, result);
                    First = result;
                    break;
                case "E":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = Math.Pow(First, Second);
                    Console.WriteLine("{0} ^ {1} = {2}", First, Second, result);
                    First = result;
                    break;
                case "EN":
                    result = Math.E;
                    Console.WriteLine("E = {0}", result);
                    First = result;
                    break;
                case "F":
                    result = First - Math.Truncate(First);
                    Console.WriteLine("F({0}) = {1}", First, result);
                    First = result;
                    break;
                case "FL":
                    result = Math.Floor(First);
                    Console.WriteLine("FL({0}) = {1}", First, result);
                    First = result;
                    break;
                case "G":
                    Console.WriteLine("G({0}) = {1}", First, First.ToString("0"));
                    break;
                case "GAU":
                    Console.Write("Z? ");
                    input = Console.ReadLine();
                    First = GetNumber(input);
                    result = Gauss(First);
                    Console.WriteLine("GAU({0}) = {1}", First, result);
                    First = result;
                    break;
                case "GCF":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    if (Int32.MinValue < First && First < Int32.MaxValue
                        && Int32.MinValue < Second && Second < Int32.MaxValue)
                    {
                        result = GCF(Convert.ToInt32(First), Convert.ToInt32(Second));
                        Console.WriteLine("GCF({0}, {1}) = {2}", First, Second, result);
                        First = result;
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "H":
                    if (Math.Abs(First) < Int64.MaxValue)
                    {
                        string strHex = Convert.ToInt64(First).ToString("X");
                        Console.WriteLine("HEX({0}) = {1}", First, strHex);
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "HT":
                    GetHeightOfTriangle();
                    break;
                case "HYP":
                    First = GetHypotenuse();
                    break;
                case "I":
                    result = Math.Floor(First);
                    Console.WriteLine("I({0}) = {1}", First, result);
                    First = result;
                    break;
                case "LCM":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    if (Int32.MinValue < First && First < Int32.MaxValue
                        && Int32.MinValue < Second && Second < Int32.MaxValue)
                    {
                        result = LCM(Convert.ToInt32(First), Convert.ToInt32(Second));
                        Console.WriteLine("LCM({0}, {1}) = {2}", First, Second, result);
                        First = result;
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "LN":
                    result = Math.Log(First);
                    Console.WriteLine("LN({0}) = {1}", First, result);
                    First = result;
                    break;
                case "LG":
                    result = Math.Log10(First);
                    Console.WriteLine("LG({0}) = {1}", First, result);
                    First = result;
                    break;
                case "M1":
                    First = M1;
                    Console.WriteLine("{0}", First);
                    break;
                case "M2":
                    First = M2;
                    Console.WriteLine("{0}", First);
                    break;
                case "M3":
                    First = M3;
                    Console.WriteLine("{0}", First);
                    break;
                case "M4":
                    First = M4;
                    Console.WriteLine("{0}", First);
                    break;
                case "M5":
                    First = M5;
                    Console.WriteLine("{0}", First);
                    break;
                case "MAX":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = Math.Max(First, Second);
                    Console.WriteLine("MAX({0}, {1}) = {2}", First, Second, result);
                    First = result;
                    break;
                case "MC":
                    ClearMemory();
                    ShowMemory();
                    break;
                case "MEM":
                    ShowMemory();
                    break;
                case "MIN":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Second = GetNumber(input);
                    result = Math.Min(First, Second);
                    Console.WriteLine("MIN({0}, {1}) = {2}", First, Second, result);
                    First = result;
                    break;
                case "N":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Double.TryParse(input, out First);
                    Console.WriteLine(First);
                    Second = 0.0;
                    break;
                case "ND":
                    First = NormDist();
                    break;
                case "P2":
                    result = Math.Pow(2, First);
                    Console.WriteLine("2 ^ {0} = {1}", First, result);
                    First = result;
                    break;
                case "PD":
                    if (Int32.MinValue < First && First < Int32.MaxValue)
                    {
                        result = PrimeDivisor(Convert.ToInt32(First));
                        Console.WriteLine("PD({0}) = {1}", First, result);
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "PI":
                    result = Math.PI;
                    Console.WriteLine("PI = {0}", result);
                    First = result;
                    break;
                case "PM":
                    if (Int32.MinValue < First && First < Int32.MaxValue)
                    {
                        bool prime = IsPrime(Convert.ToInt32(First));
                        Console.WriteLine("PRIME({0}) = {1}", First, prime);
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "QF":
                    Quadratic();
                    break;
                case "R":
                    result = 1.0 / First;
                    if (First == 0.0)
                    {
                        Console.WriteLine("Divide By Zero");
                    }
                    Console.WriteLine("1 / {0} = {1}", First, result);
                    First = result;
                    break;
                case "RAD":
                    result = Radians(First);
                    Console.WriteLine("RAD({0}) = {1}", First, result);
                    First = result;
                    break;
                case "RAN":
                    result = rnd.Next();
                    Console.WriteLine("RAN() = {0}", result);
                    First = result;
                    break;
                case "RC":
                    RandLow = 0;
                    RandHigh = 100;
                    Console.WriteLine("RL = {0}", RandLow);
                    Console.WriteLine("RH = {0}", RandHigh);
                    break;
                case "RD":
                    result = Math.Round(First);
                    Console.WriteLine("RD({0}) = {1}", First, result);
                    First = result;
                    break;
                case "RH":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Double.TryParse(input, out First);
                    if (Math.Abs(First) < Int32.MaxValue)
                    {
                        RandHigh = Convert.ToInt32(First);
                        Console.WriteLine("RH = {0}", RandHigh);
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "RL":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Double.TryParse(input, out First);
                    if (Math.Abs(First) < Int32.MaxValue)
                    {
                        RandLow = Convert.ToInt32(First);
                        Console.WriteLine("RL = {0}", RandLow);
                    }
                    else
                    {
                        Console.WriteLine("Too Big");
                    }
                    break;
                case "RN":
                    result = rnd.Next(RandLow, RandHigh);
                    Console.WriteLine("RN({0}, {1}) = {2}", RandLow, RandHigh, result);
                    First = result;
                    break;
                case "RND":
                    result = rnd.NextDouble();
                    Console.WriteLine("RND() = {0}", result);
                    First = result;
                    break;
                case "RT":
                    Console.Write("Number? ");
                    input = Console.ReadLine();
                    Double.TryParse(input, out Second);
                    result = Math.Pow(First, 1.0 / Second);
                    Console.WriteLine("RT({0}, {1}) = {2}", First, Second, result);
                    First = result;
                    break;
                case "S":
                    result = -First;
                    Console.WriteLine("-({0}) = {1}", First, result);
                    First = result;
                    break;
                case "SIN":
                    result = Math.Sin(First);
                    Console.WriteLine("SIN({0}) = {1}", First, result);
                    First = result;
                    break;
                case "SM1":
                    M1 = First;
                    Console.WriteLine("M1 = {0}", M1);
                    break;
                case "SM2":
                    M2 = First;
                    Console.WriteLine("M2 = {0}", M2);
                    break;
                case "SM3":
                    M3 = First;
                    Console.WriteLine("M3 = {0}", M3);
                    break;
                case "SM4":
                    M4 = First;
                    Console.WriteLine("M4 = {0}", M4);
                    break;
                case "SM5":
                    M5 = First;
                    Console.WriteLine("M5 = {0}", M5);
                    break;
                case "SN":
                    First = GetSimpleNormal();
                    break;
                case "SQ":
                    result = First * First;
                    Console.WriteLine("SQ({0}) = {1}", First, result);
                    First = result;
                    break;
                case "SR":
                    result = Math.Sqrt(First);
                    Console.WriteLine("SQRT({0}) = {1}", First, result);
                    First = result;
                    break;
                case "STU":
                    First = GetStudent();
                    break;
                case "TAN":
                    result = Math.Tan(First);
                    Console.WriteLine("TAN({0}) = {1}", First, result);
                    First = result;
                    break;
                case "TAU":
                    result = Math.Tau;
                    Console.WriteLine("TAU = {0}", result);
                    First = result;
                    break;
                case "X2":
                    result = First * First;
                    Console.WriteLine("{0} ^ 2 = {1}", First, result);
                    First = result;
                    break;
                case "X3":
                    result = First * First * First;
                    Console.WriteLine("{0} ^ 3 = {1}", First, result);
                    First = result;
                    break;
                default:
                    Console.WriteLine("operator not found");
                    break;
            }
        }

        private void ClearMemory()
        {
            M1 = 0.0;
            M2 = 0.0;
            M3 = 0.0;
            M4 = 0.0;
            M5 = 0.0;
        }

        void ShowMemory()
        {
            Console.WriteLine("M1 = {0}", M1);
            Console.WriteLine("M2 = {0}", M2);
            Console.WriteLine("M3 = {0}", M3);
            Console.WriteLine("M4 = {0}", M4);
            Console.WriteLine("M5 = {0}", M5);
        }

        /// <summary>
        /// Get Number
        /// </summary>
        /// <param name="value">string</param>
        /// <returns>number</returns>
        private double GetNumber(string value)
        {
            string str = value.ToUpper().Trim();
            if (IsMemory(str))
            {
                return GetMemory(str);
            }

            double result = 0.0;
            Double.TryParse(str, out result);
            return result;
        }

        private static bool IsMemory(string value)
        {
            if (value.Length == 2 && value.StartsWith("M"))
            {
                if (value == "M1" || value == "M2" || value == "M3" 
                    || value == "M4" || value == "M5")
                {
                    return true;
                }
            }

            return false;
        }

        private double GetMemory(string value)
        { 
            switch (value)
            {
                case "M1":
                    return M1;
                case "M2":
                    return M2;
                case "M3":
                    return M3;
                case "M4":
                    return M4;
                case "M5":
                    return M5;
            }

            return 0.0;
        }

        static double Factorial(double value)
        {
            if (value <= 1.0)
            {
                return 1.0;
            }
            if (value > 170.0)
            {
                return 0.0;
            }

            double result = 1.0;
            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }

            return result;
        }

        private static double Radians(double degrees)
        {
            return Math.PI * degrees / 180.0;
        }

        private static double Degrees(double radians)
        {
            return 180.0 * radians / Math.PI;
        }

        // Binary Spaces.
        // Add a space character at every four characters.
        // Value is a binary string of ones and zeros.
        // Return binary string with spaces.
        private string BinarySpaces(string value)
        {
            StringBuilder sb = new StringBuilder(Reverse(value));
            for (int i = 4; i < sb.Length; i += 4)
            {
                sb.Insert(i, " ");
                i++;
            }

            return Reverse(sb.ToString());
        }

        // Reverse string.
        private string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Is prime number?
        private bool IsPrime(int n)
        {
            // Zero and one are not prime numbers by definition.
            if (n < 2)
            {
                return false;
            }

            int mid = (int)Math.Sqrt(n);
            for (int i = 2; i <= mid; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Prime Divisor.
        // If prime, return 0.
        private int PrimeDivisor(int n)
        {
            // By definition, zero and one are not prime numbers.
            if (n < 2)
            {
                return 0;
            }

            int max = (int)Math.Sqrt(n);
            for (int i = 2; i <= max; i++)
            {
                if (n % i == 0)
                {
                    return i;
                }
            }

            return 0;
        }

        // GCF - Greatest Common Factor.
        private static int GCF(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        // LCM - Least Common Multiple.
        private static int LCM(int a, int b)
        {
            return (a / GCF(a, b)) * b;
        }

        private void Quadratic()
        {
            double a, b, c;

            // Quadratic Formula:  AX2 + BX + C = 0
            Console.Write("A? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out a);
            Console.Write("B? ");
            input = Console.ReadLine();
            Double.TryParse(input, out b);
            Console.Write("C? ");
            input = Console.ReadLine();
            Double.TryParse(input, out c);
            double result = QuadraticOne(a, b, c);
            Console.WriteLine("X1 = {0}", result);
            result = QuadraticTwo(a, b, c);
            Console.WriteLine("X2 = {0}", result);
        }

        // Quadratic Formula. First Root.
        private static double QuadraticOne(double a, double b, double c)
        {
            double d = Math.Sqrt(b * b - 4 * a * c);
            return (d - b) / (a + a);
        }

        // Quadratic Formula. Second Root.
        private static double QuadraticTwo(double a, double b, double c)
        {
            double d = Math.Sqrt(b * b - 4 * a * c);
            return (-b - d) / (a + a);
        }

        private void GetHeightOfTriangle()
        {
            double a, b, c;

            Console.Write("A? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out a);
            Console.Write("B? ");
            input = Console.ReadLine();
            Double.TryParse(input, out b);
            Console.Write("C? ");
            input = Console.ReadLine();
            Double.TryParse(input, out c);
            HeightOfTriangle(a, b, c);
        }

        private void HeightOfTriangle(double a, double b, double c) 
        {
            double p, d, ha, hb, hc;

            p = (a + b + c) / 2;
            d = 2.0 * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            ha = d / a;
            hb = d / b;
            hc = d / c;
            Console.WriteLine("ha = {0}", ha);
            Console.WriteLine("hb = {0}", hb);
            Console.WriteLine("hc = {0}", hc);
        }

        private double GetHypotenuse()
        {
            double a, b;

            // C = SQRT(A2 + B2)
            Console.Write("A? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out a);
            Console.Write("B? ");
            input = Console.ReadLine();
            Double.TryParse(input, out b);
            double result = Hypotenuse(a, b);
            Console.WriteLine("C = {0}", result);
            return result;
        }

        private double Hypotenuse(double a, double b) 
        {
           return Math.Sqrt(a * a + b * b);
        }


        private double GetCosineRule()
        {
            double a, b, gamma;

            Console.Write("A? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out a);
            Console.Write("B? ");
            input = Console.ReadLine();
            Double.TryParse(input, out b);
            Console.Write("Gamma? ");
            input = Console.ReadLine();
            Double.TryParse(input, out gamma);
            double result = CosineRule(a, b, gamma);
            Console.WriteLine("C = {0}", result);
            return result;
        }


        /// <summary>
        /// Cosine Rule.  Get Length of third side of a triangle.
        /// </summary>
        /// <param name="a">double</param>
        /// <param name="b">double</param>
        /// <param name="gamma">degrees</param>
        /// <returns></returns>
        private static double CosineRule(double a, double b, double gamma) 
        {
            // C = SQR(A2 + B2 - 2AB * COS(gamma))
            // Gamma is angle of side C.
            return Math.Sqrt((a * a) + (b * b) - 2 * a * b * Math.Cos(Radians(gamma)));
        }

        private double GetCDF()
        {
            double z;

            Console.Write("Z? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out z);
            double result = CumDensity(z);
            Console.WriteLine("CDF({0}) = {1}", z, result);
            return result;
        }


        /// <summary>
        /// CDF - Cumulative Density Function for the Standard Normal Distribution.
        /// </summary>
        /// <param name="z">z-score</param>
        /// <returns>cumulative probability density</returns>
        // Output is always between zero and one.  Z-Score is generally between -4.0 and 4.0.
        // When z is above 4.0, cdf is one. When z is below -4.0, cdf is zero.  
        private static double CumDensity(double z)
        {
            double p = 0.3275911;
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;

            int sign = 1;
            if (z < 0.0)
            {
                sign = -1;
            }

            double x = Math.Abs(z) / Math.Sqrt(2.0);
            double t = 1.0 / (1.0 + p * x);
            double erf = 1.0 - (((((a5 * t + a4) * t) + a3)
              * t + a2) * t + a1) * t * Math.Exp(-x * x);
            return 0.5 * (1.0 + sign * erf);
        } // CumDensity()

        // Get Student T-Distribution
        private double GetStudent()
        {
            double t, df;

            Console.Write("T? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out t);
            Console.Write("DF? ");
            input = Console.ReadLine();
            Double.TryParse(input, out df);
            double result = Student(t, df);
            Console.WriteLine("STU({0}, {1}) = {2}", t, df, result);
            return result;
        }

        /// <summary>
        /// Student's T-Distribution
        /// </summary>
        /// <param name="t">t-score</param>
        /// <param name="df">degrees of freedom</param>
        /// <returns>2-tail probability</returns>

        private static double Student(double t, double df)
        {
            // for large int df or double df

            // Adapted from ACM algorithm 395
            // Returns 2-tail probability.
            // For 1-tail probability, divide by two.

            double n = df; // to sync with ACM parameter name
            double a, b, y;

            t = t * t;
            y = t / n;
            b = y + 1.0;
            if (y > 1.0E-6)
            {
                y = Math.Log(b);
            }
            a = n - 0.5;
            b = 48.0 * a * a;
            y = a * y;

            y = (((((-0.4 * y - 3.3) * y - 24.0) * y - 85.5) /
              (0.8 * y * y + 100.0 + b) +
                y + 3.0) / b + 1.0) * Math.Sqrt(y);

            return 2.0 * Gauss(-y);
        } // Student

        /// <summary>
        /// Gaussian Probability Density Function
        /// </summary>
        /// <param name="z">z-score</param>
        /// <returns>probability density</returns>
        private static double Gauss(double z)
        {
            // input = z-value (-inf to +inf)
            // output = p under Normal curve from -inf to z
            // e.g., if z = 0.0, function returns 0.5000
            // ACM Algorithm #209
            double y; // 209 scratch variable
            double p; // result. called 'z' in 209
            double w; // 209 scratch variable

            if (z == 0.0)
            {
                p = 0.0;
            }
            else
            {
                y = Math.Abs(z) / 2;
                if (y >= 3.0)
                {
                    p = 1.0;
                }
                else if (y < 1.0)
                {
                    w = y * y;
                    p = ((((((((0.000124818987 * w
                      - 0.001075204047) * w + 0.005198775019) * w
                      - 0.019198292004) * w + 0.059054035642) * w
                      - 0.151968751364) * w + 0.319152932694) * w
                      - 0.531923007300) * w + 0.797884560593) * y * 2.0;
                }
                else
                {
                    y = y - 2.0;
                    p = (((((((((((((-0.000045255659 * y
                      + 0.000152529290) * y - 0.000019538132) * y
                      - 0.000676904986) * y + 0.001390604284) * y
                      - 0.000794620820) * y - 0.002034254874) * y
                      + 0.006549791214) * y - 0.010557625006) * y
                      + 0.011630447319) * y - 0.009279453341) * y
                      + 0.005353579108) * y - 0.002141268741) * y
                      + 0.000535310849) * y + 0.999936657524;
                }
            }

            if (z > 0.0)
            {
                return (p + 1.0) / 2;
            }
            else
            {
                return (1.0 - p) / 2;
            }
        } // Gauss()

        // Normal Distribution
        private double NormDist()
        {
            double x, mean, std;

            Console.Write("X? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out x);
            Console.Write("MEAN? ");
            input = Console.ReadLine();
            Double.TryParse(input, out mean);
            Console.Write("STD? ");
            input = Console.ReadLine();
            Double.TryParse(input, out std);
            double result = Normal(x, mean, std);
            Console.WriteLine("ND({0}, {1}, {2}) = {3}", x, mean, std, result);
            return result;
        }


        /// <summary>
        /// Normal Distribution (pdf)
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="mean">mean</param>
        /// <param name="std">standard deviation</param>
        /// <returns>probability</returns>
        private static double Normal(double x, double mean, double std)
        {
            double tmp = 1 / ((Math.Sqrt(2 * Math.PI) * std));
            return tmp * Math.Exp(-0.5 * Math.Pow((x - mean) / std, 2));
        }

        private double GetSimpleNormal()
        {
            double x;

            Console.Write("X? ");
            string input = Console.ReadLine();
            Double.TryParse(input, out x);
            double result = SimpleNormal(x);
            Console.WriteLine("SN({0}) = {1}", x, result);
            return result;
        }

        /// <summary>
        /// Simple Normal Distribution (pdf). Mean = 0. Std = 1.
        /// </summary>
        /// <param name="x">x</param>
        /// <returns>probability</returns>
        private static double SimpleNormal(double x)
        {
            double tmp = 1 / (Math.Sqrt(2 * Math.PI));
            return tmp * Math.Exp(-0.5 * x * x);
        }

    }
}
