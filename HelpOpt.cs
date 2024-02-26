using System;
using System.Numerics;

namespace CalcOne
{
    public class HelpOpt
    {
        public void ProcessArgs()
        {
            var myArgs = GetCommandLine().Split("-").ToList();
            if (myArgs.Count > 0)
            {
                myArgs.RemoveAt(0);
            }

            for (int i = 0; i < myArgs.Count; i++)
            {
                string option = myArgs[i];
                ProcessArg(option);
            }
        }

        private string GetCommandLine()
        {
            return Environment.CommandLine;
        }

        private void ProcessArg(string value)
        {
            var list = value.ToUpper().Split().ToList();

            string first = list[0];
            string second = "";
            if (list.Count > 1)
            {
                second = list[1];
            }

            switch (first)
            {
                case "H":
                    BasicHelp();
                    break;
                case "HA":
                    LongOperatorList();
                    break;
                case "HO":
                    DeepOperatorHelp(second);
                    break;
                case "HQ":
                    QuickHelp();
                    break;
                case "HS":
                    ShortOperatorList();
                    break;
                case "HX":
                    ExampleHelp();
                    break;
            }
        }

        private void BasicHelp()
        {
            Console.WriteLine("Description:\n\tCommand-Line Calculator. Supports one register and five memory cells.\n");
            Console.WriteLine("Usage:\n\tCalcOne [options]\n");
            Console.WriteLine("Options:");
            Console.WriteLine("\t-h  Show help and usage information.");
            Console.WriteLine("\t-ha  Show operator list.");
            Console.WriteLine("\t-ho [operator]  Show operator help.");
            Console.WriteLine("\t-hq  Show quick help.");
            Console.WriteLine("\t-hx  Show help examples.\n");
        }

        private void QuickHelp()
        {
            Console.WriteLine("Quick Help:\n");
            Console.WriteLine("Exit Application:\n");
            Console.WriteLine("Enter an empty line in the operator field.\n");
            Console.WriteLine("Basics:\n");
            Console.WriteLine("There are two types of fields: Operator and Number.");
            Console.WriteLine("To see a list of all operators use -ha.\n");
            Console.WriteLine("Operators:\n");
            Console.WriteLine("Type n to save a new number into the base register.");
            Console.WriteLine("Type c to clear the screen and register.\n");
            Console.WriteLine("Type mem to view all memory cells.");
            Console.WriteLine("Type ms1 to save the base register into the first memory cell.");
            Console.WriteLine("Type ms2 to save the base register into the second memory cell.\n");
            Console.WriteLine("Type m1 to copy the first memory cell into the base register.");
            Console.WriteLine("Type m2 to copy the second memory cell into the base register.\n");
            Console.WriteLine("Memory cells can be used in the number fields and the operator fields. Type m1.\n");
        }

        private void LongOperatorList()
        {
            Console.WriteLine("Operators:\n");
            Console.WriteLine("+ add");
            Console.WriteLine("- subtract");
            Console.WriteLine("* multiply");
            Console.WriteLine("/ divide");
            Console.WriteLine("% modulus");
            Console.WriteLine("! factorial");
            Console.WriteLine("= show register");
            Console.WriteLine("\n");
            Console.WriteLine("A absolute value");
            Console.WriteLine("ACOS anti-cosine");
            Console.WriteLine("ASIN anti-sine");
            Console.WriteLine("ATAN anti-tangent");
            Console.WriteLine("B Binary");
            Console.WriteLine("BIT Show Bits");
            Console.WriteLine("C clear");
            Console.WriteLine("CB cube, a ^ 3");
            Console.WriteLine("CL Ceiling");
            Console.WriteLine("COS Cosine in radians");
            Console.WriteLine("CDF Cumulative Density Function, z-score");
            Console.WriteLine("CM Commas");
            Console.WriteLine("CR Cube root, EXP(a, 1 / 3)");
            Console.WriteLine("CSR Cosine rule");
            Console.WriteLine("DEG radians to degrees");
            Console.WriteLine("E exponent, power, a ^b");
            Console.WriteLine("EN Euler's Number 2.71");
            Console.WriteLine("F fraction");
            Console.WriteLine("FL Floor");
            Console.WriteLine("G General, No exponent");
            Console.WriteLine("GAU Gaussian, z - score");
            Console.WriteLine("GCF Greatest Common Factor");
            Console.WriteLine("H Hex");
            Console.WriteLine("HT Height of Triangle");
            Console.WriteLine("HYP Hypotenuse");
            Console.WriteLine("I Integer");
            Console.WriteLine("LCM - Least Common Multiple");
            Console.WriteLine("LG Base 10 Logarithm, 10 ^ a");
            Console.WriteLine("LN Natural Logarithm, E ^ a");
            Console.WriteLine("M1 get from memory");
            Console.WriteLine("MC Memory Clear");
            Console.WriteLine("N Number");
            Console.WriteLine("ND Normal Distribution, x, mean, std");
            Console.WriteLine("P2 power of two, 2 ^ a");
            Console.WriteLine("PD Prime Divisor");
            Console.WriteLine("PI half rotation in radians 3.14");
            Console.WriteLine("PM Prime?");
            Console.WriteLine("QF Quadratic Formula");
            Console.WriteLine("R reciprocal, 1 / x");
            Console.WriteLine("RAD degrees to radians");
            Console.WriteLine("RAN Random Integer");
            Console.WriteLine("RC Range Clear, Set Range to 0 to 100");
            Console.WriteLine("RD Round");
            Console.WriteLine("RH Random High");
            Console.WriteLine("RL Random Low");
            Console.WriteLine("RN Random Number Between High and Low");
            Console.WriteLine("RND Random Double Between One and Zero");
            Console.WriteLine("RT Nth Root, EXP(a, 1 / b)");
            Console.WriteLine("S Change Sign");
            Console.WriteLine("SIN sine in radians");
            Console.WriteLine("SM1 save to memory");
            Console.WriteLine("SN Simple Normal Distribution, mean = 0, std = 1");
            Console.WriteLine("SR square root, SQRT(a)");
            Console.WriteLine("STU Student's T-Distribution, t-score and degrees of freedom");
            Console.WriteLine("TAN tangent in radians");
            Console.WriteLine("TAU full rotation in radians 6.28");
            Console.WriteLine("X2 square, a * a");
            Console.WriteLine("X3 cube, a ^ 3");
        }

        private void ExampleHelp()
        {
            Console.WriteLine("EXAMPLES:\n");
            Console.WriteLine("Change the Sign of a Number:  12.62\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 12.62");
            Console.WriteLine("12.62");
            Console.WriteLine("Operator? S");
            Console.WriteLine("-(12.62) = -12.62\n");
            Console.WriteLine("Get 123 Squared\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number? 123");
            Console.WriteLine("123");
            Console.WriteLine("Operator? x2");
            Console.WriteLine("123 ^ 2 = 15129\n");
            Console.WriteLine("Add Three Numbers: 121, 336 and 712\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 121");
            Console.WriteLine("121");
            Console.WriteLine("Operator ? +");
            Console.WriteLine("Number ? 336");
            Console.WriteLine("121 + 336 = 457");
            Console.WriteLine("Operator ? +");
            Console.WriteLine("Number ? 712");
            Console.WriteLine("457 + 712 = 1169\n");
            Console.WriteLine("Get Square Root of 658\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 658");
            Console.WriteLine("658");
            Console.WriteLine("Operator? sr");
            Console.WriteLine("SQRT(658) = 25.65151067676132\n");
            Console.WriteLine("Raise 127 to the 4th Power\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 127");
            Console.WriteLine("127");
            Console.WriteLine("Operator? e");
            Console.WriteLine("Number ? 4");
            Console.WriteLine("127 ^ 4 = 260144641\n");
            Console.WriteLine("Convert 33 degrees to Radians\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number? 33");
            Console.WriteLine("33");
            Console.WriteLine("Operator? rad");
            Console.WriteLine("RAD(33) = 0.5759586531581288\n");
            Console.WriteLine("Get the Cosine of 42 degrees\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number? 42");
            Console.WriteLine("42");
            Console.WriteLine("Operator? rad");
            Console.WriteLine("RAD(42) = 0.7330382858376184");
            Console.WriteLine("Operator? cos");
            Console.WriteLine("COS(0.7330382858376184) = 0.7431448254773942\n");
            Console.WriteLine("Get the Factorial of 9\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 9");
            Console.WriteLine("9");
            Console.WriteLine("Operator ? !");
            Console.WriteLine("9! = 362880\n");
            Console.WriteLine("Get the Greatest Common Factor of 121 and 335\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 121");
            Console.WriteLine("121");
            Console.WriteLine("Operator? gcf");
            Console.WriteLine("Number ? 335");
            Console.WriteLine("GCF(121, 335) = 1\n");
            Console.WriteLine("Get Log Base 10 of 55\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 55");
            Console.WriteLine("55");
            Console.WriteLine("Operator? lg");
            Console.WriteLine("LG(55) = 1.7403626894942439\n");
            Console.WriteLine("Get the 5th Root of 321\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 321");
            Console.WriteLine("321");
            Console.WriteLine("Operator? rt");
            Console.WriteLine("Number ? 5");
            Console.WriteLine("RT(321, 5) = 3.1717650296502993\n");
            Console.WriteLine("Get the Length of the Hypotenuse of a Right Triangle");
            Console.WriteLine("with Sides 7.2 and 11.5\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 7.2");
            Console.WriteLine("7.2");
            Console.WriteLine("Operator? x2");
            Console.WriteLine("7.2 ^ 2 = 51.84");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 11.5");
            Console.WriteLine("11.5");
            Console.WriteLine("Operator? x2");
            Console.WriteLine("11.5 ^ 2 = 132.25");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 51.84");
            Console.WriteLine("51.84");
            Console.WriteLine("Operator ? +");
            Console.WriteLine("Number ? 132.25");
            Console.WriteLine("51.84 + 132.25 = 184.09");
            Console.WriteLine("Operator ? sr");
            Console.WriteLine("SQRT(184.09) = 13.567977004697495\n");
            Console.WriteLine("Save 3.5 to Memory Cell Three\n");
            Console.WriteLine("Operator? n");
            Console.WriteLine("Number ? 3.5");
            Console.WriteLine("3.5");
            Console.WriteLine("Operator? sm3");
            Console.WriteLine("M3 = 3.5");
            Console.WriteLine("Operator? mem");
            Console.WriteLine("M1 = 0");
            Console.WriteLine("M2 = 0");
            Console.WriteLine("M3 = 3.5");
            Console.WriteLine("M4 = 0");
            Console.WriteLine("M5 = 0\n");
        }

        private void DeepOperatorHelp(string op)
        {
            string str = op.ToUpper().Trim();
            switch (str)
            {
                case "+":
                    Console.WriteLine("+ add");
                    break;
                case "*":
                    Console.WriteLine("* multiply");
                    break;
                case "/":
                    Console.WriteLine("/ divide");
                    break;
                case "%":
                    Console.WriteLine("% modulus");
                    break;
                case "!":
                    Console.WriteLine("! factorial");
                    break;
                case "=":
                    Console.WriteLine("= show register");
                    break;
                case "A":
                    Console.WriteLine("A absolute value");
                    break;
                case "ACOS":
                    Console.WriteLine("ACOS anti-cosine");
                    break;
                case "ASIN":
                    Console.WriteLine("ASIN anti-sine");
                    break;
                case "ATAN":
                    Console.WriteLine("ATAN anti-tangent");
                    break;
                case "B":
                    Console.WriteLine("B Binary");
                    break;
                case "BIT":
                    Console.WriteLine("BIT Show Bits");
                    break;
                case "C":
                    Console.WriteLine("C clear");
                    break;
                case "CB":
                    Console.WriteLine("CB cube, a ^ 3");
                    break;
                case "CDF":
                    Console.WriteLine("CDF Cumulative Density Function, z-score");
                    break;
                case "CL":
                    Console.WriteLine("CL Ceiling");
                    break;
                case "COS":
                    Console.WriteLine("COS Cosine in radians");
                    break;
                case "CM":
                    Console.WriteLine("CM Commas");
                    break;
                case "CR":
                    Console.WriteLine("CR Cube root, EXP(a, 1 / 3)");
                    break;
                case "CSR":
                    Console.WriteLine("CSR Cosine rule");
                    break;
                case "DEG":
                    Console.WriteLine("DEG radians to degrees");
                    break;
                case "E":
                    Console.WriteLine("E exponent, power, a ^ b");
                    break;
                case "EN":
                    Console.WriteLine("EN Euler's Number 2.71");
                    break;
                case "F":
                    Console.WriteLine("F fraction");
                    break;
                case "FL":
                    Console.WriteLine("FL Floor");
                    break;
                case "G":
                    Console.WriteLine("G General, No exponent");
                    break;
                case "GAU":
                    Console.WriteLine("GAU Gaussian, z - score");
                    break;
                case "GCF":
                    Console.WriteLine("GCF Greatest Common Factor");
                    break;
                case "H":
                    Console.WriteLine("H Hex");
                    break;
                case "HT":
                    Console.WriteLine("HT Height of Triangle");
                    break;
                case "HYP":
                    Console.WriteLine("HYP Hypotenuse");
                    break;
                case "I":
                    Console.WriteLine("I Integer");
                    break;
                case "LCM":
                    Console.WriteLine("LCM - Least Common Multiple");
                    break;
                case "LN":
                    Console.WriteLine("LN Natural Logarithm, E ^ a");
                    break;
                case "LG":
                    Console.WriteLine("LG Base 10 Logarithm, 10 ^ a");
                    break;
                case "M1":
                    Console.WriteLine("M1 get from memory cell one");
                    break;
                case "MC":
                    Console.WriteLine("MC Memory Clear");
                    break;
                case "N":
                    Console.WriteLine("N Number");
                    break;
                case "ND":
                    Console.WriteLine("ND Normal Distribution, x, mean, std");
                    break;
                case "P2":
                    Console.WriteLine("P2 power of two, 2 ^ a");
                    break;
                case "PD":
                    Console.WriteLine("PD Prime Divisor");
                    break;
                case "PI":
                    Console.WriteLine("PI half rotation in radians 3.14");
                    break;
                case "PM":
                    Console.WriteLine("PM Prime?");
                    break;
                case "QF":
                    Console.WriteLine("QF Quadratic Formula");
                    break;
                case "R":
                    Console.WriteLine("R reciprocal, 1 / x");
                    break;
                case "RAD":
                    Console.WriteLine("RAD degrees to radians");
                    break;
                case "RAN":
                    Console.WriteLine("RAN Random Integer");
                    break;
                case "RC":
                    Console.WriteLine("RC Range Clear, Set Range to 0 to 100");
                    break;
                case "RD":
                    Console.WriteLine("RD Round");
                    break;
                case "RH":
                    Console.WriteLine("RH Random High");
                    break;
                case "RL":
                    Console.WriteLine("RL Random Low");
                    break;
                case "RN":
                    Console.WriteLine("RN Random Number Between High and Low");
                    break;
                case "RND":
                    Console.WriteLine("RND Random Double Between One and Zero");
                    break;
                case "RT":
                    Console.WriteLine("RT Nth Root, EXP(a, 1 / b)");
                    break;
                case "S":
                    Console.WriteLine("S Change Sign");
                    break;
                case "SIN":
                    Console.WriteLine("SIN sine in radians");
                    break;
                case "SM1":
                    Console.WriteLine("SM1 save to memory");
                    break;
                case "SN":
                    Console.WriteLine("SN Simple Normal Distribution, mean = 0, std = 1");
                    break;
                case "SR":
                    Console.WriteLine("SR square root, SQRT(a)");
                    break;
                case "STU":
                    Console.WriteLine("STU Student's T-Distribution, t-score and degrees of freedom");
                    break;
                case "TAN":
                    Console.WriteLine("TAN tangent in radians");
                    break;
                case "TAU":
                    Console.WriteLine("TAU full rotation in radians 6.28");
                    break;
                case "X2":
                    Console.WriteLine("X2 square, a *a");
                    break;
                case "X3":
                    Console.WriteLine("X3 cube, a ^3");
                    break;
            }
        }

        private void ShortOperatorList()
        {
            Console.WriteLine("Operators:");
            Console.WriteLine("+ * / % ! = A ACOS ASIN ATAN B BIT C CB CDF CL CM COS CR CSR DEG E EN F FL G GAU");
            Console.WriteLine("GCF H HT HYP I LCM LN LG M1 MC N ND P2 PD PI PM QF R RAD RAN RC RD RH RL RN RND RT S");
            Console.WriteLine("SIN SM1 SN SR STU TAN TAU X2 X3\n");
        }
    }
}

