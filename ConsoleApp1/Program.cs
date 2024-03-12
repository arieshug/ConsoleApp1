namespace ConsoleApp1
{
    class GiftBox
    {
        public string Letter;
        public int Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GiftBox a = new GiftBox()
            {
                Letter = "잘 지내지?",
                Money = 100000
            };
            Console.WriteLine("A 문자내용");
            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);
            GiftBox Friend = a;

            Console.WriteLine("친구 문자내용");
            Console.WriteLine(Friend.Letter);
            Console.WriteLine(Friend.Money);

            a.Letter = "어떻게 지내고 있어?";
            a.Money = 150000;

            Console.WriteLine("A 변경 이후 문자내용");
            Console.WriteLine(a.Letter);
            Console.WriteLine(a.Money);

            Console.WriteLine("친구 문자 내용");
            Console.WriteLine(Friend.Letter);
            Console.WriteLine(Friend.Money);
        }
    }
}
