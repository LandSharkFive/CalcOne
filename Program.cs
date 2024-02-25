namespace CalcOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                HelpOpt help = new HelpOpt();
                help.ProcessArgs();
                return;
            }

            Util util = new Util();
            util.Calculate();
        }
    }

}
