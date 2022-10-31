namespace mymethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethods.GetHyp(3, 4));
            double perimeter=3+4+MyMethods.GetHyp(3, 4);
            Console.WriteLine($"the perimeter is {perimeter}cm");
            Console.WriteLine(MyMethods.GetLeg(5, 3));
            perimeter=5+3+MyMethods.GetLeg(5, 3);
            Console.WriteLine($"the perimeter is {perimeter}cm");
        }
    }
}