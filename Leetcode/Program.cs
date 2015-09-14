using Leetcode.树;
using Leetcode.数组;
using Leetcode.栈和队列;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Leetcode
{

    /*静态构造函数举例*/
    class Person
    {
        /*静态构造函数不允许出现访问修饰符*/
        static Person()
        {
            Console.WriteLine("我是静态构造函数！！！");
        }


        /*
         　在使用静态构造函数的时候应该注意几点： 类构造函数

　　          1、静态构造函数既没有访问修饰符，也没有参数。因为是.NET调用的，所以像public和private等修饰符就没有意义了。
　　
　　          2、是在创建第一个类实例或任何静态成员被引用时，.NET将自动调用静态构造函数来初始化类，也就是说我们无法直接调用静态构造函数，也就无法控制什么时候执行静态构造函数了。

　　          3、一个类只能有一个静态构造函数。

　　          4、无参数的构造函数可以与静态构造函数共存。尽管参数列表相同，但一个属于类，一个属于实例，所以不会冲突。

　　          5、最多只运行一次。

　　          6、静态构造函数不可以被继承。

　　          7、如果没有写静态构造函数，而类中包含带有初始值设定的静态成员，那么编译器会自动生成默认的静态构造函数。
         */
    }



    /*readonly初始化举例*/
    class Sample
    {
        //readonly修饰的在初始化的时候可以多次赋值
        public readonly int readonlyValue = 100;/*第一次赋值*/
        public Sample(int value)
        {
            this.readonlyValue = value;/*第二次赋值*/
        }
    }


    /*static readonly和const*/
    class Fruit
    {
        public const int color = 9;//通过类名直接进行访问
        public static readonly string type = "西瓜";
        /*s
        public Fruit()
        {
            type = "香蕉";//不能在普通的构造函数中赋值
        }*/

        static Fruit()//可以在静态构造函数中赋值
        {
            type = "苹果";
        }
    }
    /*
        const和static readonly的确非常像：通过类名而不是对象名进行访问，在程式中只读等等。在多数情况下能混用。
        二者本质的差别在于，const的值是在编译期间确定的，因此只能在声明时通过常量表达式指定其值。
     */



    class Program
    {
        static void Main11(string[] args)     
        {
            while (true)
            {
                Console.WriteLine(new Random().Next(7));
                Thread.Sleep(100);
                
            }
            int j = 1;
            Console.WriteLine(j++);
            /*int最大数*/
            Console.WriteLine(int.MaxValue);
            /*java里面不能这么写 int[] arry = new int[5] { 1, 3, 5, 7, 45 };*/
            int[] arry = new int[5] { 1, 3, 5, 7, 45 };//数组初始化问题


            //C# 闭包
            List<Action> lists = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                Action a = () => Console.WriteLine(i.ToString());
                lists.Add(a);

            }
            foreach (Action a in lists)
            {
                a();//输出是55555  
            }
            //Dictionary<string,string> dic = new Dictionary<string ,string>();
            //dic.Add("1","dd");
            //dic.Add("2", "gg");
            //dic.Add("3", "hh");
            //dic.Add("4", "jj");
            //string aa= dic["1"];
        }

        public static bool IsValid(string s)
        {
            MyStack<char> stack = new MyStack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s.Substring(i, 1).FirstOrDefault();
                switch (ch)
                {
                    case '(':
                        stack.Push(ch);
                        break;
                    case '[':
                        stack.Push(ch);
                        break;
                    case '{':
                        stack.Push(ch);
                        break;
                    case ')':
                        {
                            if (stack.IsEempty())
                            {
                                return false;
                            }
                            else
                            {
                                if ('(' != stack.Pop())
                                    return false;
                            }
                            break;
                        }
                    case ']':
                        {
                            if (stack.IsEempty())
                            {
                                return false;
                            }
                            else
                            {
                                if ('[' != stack.Pop())
                                    return false;
                            }
                            break;
                        }
                    case '}':
                        {
                            if (stack.IsEempty())
                            {
                                return false;
                            }
                            else
                            {
                                if ('{' != stack.Pop())
                                    return false;
                            }
                            break;
                        }
                }
            }
            if (stack.IsEempty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
