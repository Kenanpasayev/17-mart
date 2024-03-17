namespace task_4_d
{
    internal class Program
    {
        //Ucbucaqlinin daxiline cekilmis cevrenin sahesi-S=p*r:p=(a+b+c)/2
        public static int area ( int a, int b, int c, int r) 
        {
            int p =(a+b+c)/2;
            return p * r;
        }
        static void Main(string[] args)
        {
            int a =3;
            int b =4;
            int c =5;
            int r = 6;
            Console.WriteLine(area(a,b,c,r));
        }
    }
}
