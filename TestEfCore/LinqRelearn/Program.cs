namespace LinqRelearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //像指针一样的用法
            dele1 instanceDele1 = funAdd;
            //指向了某个具体方法后，就可以通过委托来调用这个方法了
            instanceDele1(5);

            instanceDele1 = funMinus;
            instanceDele1(5);

            //通过这种方法，可以往一个方法里传方法，具体需求是什么，可以灵活调整，构成LINQ的基础


            //2.实际工作中没必要用委托，直接Func和Action来代替,Func最后一个参数是返回值类型
            Action<int> anonymousDele = funAdd;
            Action<int> anonymousDele2 = funMinus;
            anonymousDele(5);
            anonymousDele2(5);

            //3.写成lamda表达式

        }

        static void funAdd(int i)
        {
            Console.WriteLine(i+1);
        }
        static void funMinus(int k)
        {
            Console.WriteLine(k-1);
        }

    }
    //Delegate是抽象类，千万注意大小写
    delegate void dele1(int i);
}
