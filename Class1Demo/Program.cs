using System;//using关键字，使用其他的命名空间
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Demo
//namespace声明，表示一系列的类
{
    class Program
    //class声明，表示一个类
    {
        static void Main(string[] args)
        //class的一个方法，Main是程序的入口点
        {
            System.Console.WriteLine("Hello C#!");
            //我是注释
            /*我也是注释*/
            System.Console.WriteLine();

            #region 类型转换，值类型
            System.Console.WriteLine("类型转换，值类型：");
            int a = 1;
            float b = 1.1f;
            float c = 1.2f;
            double d = 1.11;
            double e = 1.111d;
            long f = 12345;
            long g = 12345L;
            a = (int)b;
            b = a;
            d = b;
            b = (float)d;
            Console.WriteLine("{0}--{1}--{2}--{3}--{4}--{5}--{6}", a, b, c, d, e, f, g);
            System.Console.WriteLine();
            #endregion

            #region 选择结构
            System.Console.WriteLine("选择结构：");
            int i = 0;
            #region if语句
            System.Console.WriteLine("if语句：");
            if (i == 1)
            {
                System.Console.WriteLine("i的值是1");
            }
            else if (i == 2)
                System.Console.WriteLine("i的值是2");
            else
                System.Console.WriteLine("i的值不是1也不是2");
            #endregion

            #region switch语句
            System.Console.WriteLine("switch语句：");
            switch (i)
            {
                case 1:
                    System.Console.WriteLine("i的值是1");
                    break;
                case 2:
                    System.Console.WriteLine("i的值是2");
                    break;
                default:
                    System.Console.WriteLine("i的值不是1也不是2");
                    break;
            }
            #endregion
            System.Console.WriteLine();
            #endregion

            #region 循环结构
            System.Console.WriteLine("循环结构：");
            #region for循环
            System.Console.WriteLine("for循环：");
            for (i = 0; i < 100; i++)
            {
                System.Console.Write(i);
            }
            System.Console.WriteLine();
            #endregion
            i = 0;
            #region while循环
            System.Console.WriteLine("while循环：");
            while (i < 100)
            {
                System.Console.Write(i);
                i++;
            }
            System.Console.WriteLine();
            #endregion
            i = 0;
            #region do...while循环
            System.Console.WriteLine("do...while循环：");
            do
            {
                Console.Write(i);
                i++;
            } while (i < 100);
            System.Console.WriteLine();
            #endregion
            System.Console.WriteLine();
            #endregion

            #region 数组
            double[] arrayname;
            //数组的声明，声明并不会初始化，初始化数组变量后，可以赋值给数组

            int[] inter = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            inter[0] = 10086;
            Console.WriteLine("the first element of inter " + inter[0]);
            int[] myarray = new int[4];
            int[] myarray2 = new int[4] { 1, 2, 3, 4 };
            int[] myarray3 = new int[] { 1, 2, 3, 4 };

            //foreach循环
            foreach (var x in inter)
            {
                Console.WriteLine("我的值是"+x);
            }

            //二维
            int[,] twodim =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            twodim[0, 0] = 1;
            twodim[0, 1] = 1;
            twodim[0, 2] = 1;

            //锯齿
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 3, 4 };
            jagged[1] = new int[5] { 3, 4, 5, 67, 7 };
            jagged[2] = new int[3] { 3, 5, 4 };
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int column = 0; column < jagged[row].Length; column++)
                {
                    Console.WriteLine("row {0},column {1} ,value {2}", row, column, jagged[row][column]);
                }
            }
            System.Console.WriteLine();
            #endregion

            #region 方法的调用
            System.Console.WriteLine("方法的调用：");
            int num1 = 1, num2 = 2, Max;
            Max = FindMax(num1, num2);
            System.Console.WriteLine(Max);
            System.Console.WriteLine();
            #endregion

            #region 类型推断
            var num = 0;
            #endregion

            #region string初步
            System.Console.WriteLine("string初步：");
            char ch = '你';
            string message1 = "hello";
            message1 += ", world";
            string message2 = message1 + "!";
            Console.WriteLine("message's length is {0}", message1.Length);
            //索引器
            ch = message1[2];
            //转义字符
            string filepath1 = "C:\\WIndows\\System32\\drivers\\etc\\hosts";
            Console.WriteLine(filepath1);
            //@原意
            string filepath2 = @"C:\Windows\System32\drivers\etc\hosts";
            Console.WriteLine(filepath2);
            System.Console.WriteLine();

            char[] chars = { 'w', 'o', 'r', 'd' };
            string string1 = new string(chars);
            Console.WriteLine(string1);

            string string2 = new string('c', 20);
            Console.WriteLine(string2);

            #endregion

            #region string的方法
            System.Console.WriteLine("string的方法");
            //Split
            string spstr = "Microsoft Surface Book";
            char spchar = ' ';
            string[] splitted = spstr.Split(spchar);
            foreach (var item in splitted)
            {
                Console.WriteLine(item);
            }
            //Replace
            string repstr = "Apple is a good computer company.";
            string repstr1 = repstr.Replace("Apple", "Microsoft");
            string repstr2 = repstr1.Replace("good", "Great");
            repstr2.Replace('p', '3');
            repstr2 += "in the world";
            Console.WriteLine(repstr);
            Console.WriteLine(repstr1);
            Console.WriteLine(repstr2);

            string repstrch = "Book Good Food Mood Fool";
            char rr = 'o';
            string repstrch2 = repstrch.Replace(rr, '?');
            Console.WriteLine(repstrch);
            Console.WriteLine(repstrch2);

            //SubString
            string substr = "Hello From Redrock Mobile Windows";
            string substr2 = substr.Substring(11);
            Console.WriteLine("the origin string is {0}, \n after substring {1}", substr, substr2);
            string substr3 = substr2.Substring(0, 7);
            Console.WriteLine("the origin string is {0}, after substring {1}", substr2, substr3);
            #endregion
        }
        #region 方法的定义
        public static int FindMax(int a, int b)
        {
            int result;
            if (a > b)
                result = a;
            else
                result = b;
            return result;
        }
        #endregion
    }
}
