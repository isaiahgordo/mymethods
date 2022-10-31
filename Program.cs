namespace mymethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"hyp calculator 0", "rise cal 1", "run cal 2","dis cal 3","slop cal 4",""};
            List<int> gRl = new List<int>();
            int[] gRa= new int[int.MaxValue];
            Console.WriteLine(MyMethods.GetHyp(3, 4));
            double perimeter=3+4+MyMethods.GetHyp(3, 4);
            Console.WriteLine($"the perimeter is {perimeter}cm");
            Console.WriteLine(MyMethods.GetLeg(5, 3));
            perimeter=5+3+MyMethods.GetLeg(5, 3);
            Console.WriteLine($"the perimeter is {perimeter}cm");
            Console.WriteLine("Ti type the number afer the word to do it");
        }
    }
}