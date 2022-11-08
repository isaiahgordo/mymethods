using System.Drawing;

namespace mymethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] xys = new Point[2],coor=new Point[2];
            bool done = 0 == 1,tp,stp;
            bool[] d0ne = new bool[13];
            int i, ioc, itp, istp, ss0i, ssi,emt,x,y,x1,y1,iop,ioy;
            for(i=0; i < 13; i++)
                d0ne[1] = done;            
            double dtp,dstp,gh,dis;
            string s;
            string[] selp = new string[2];
            List<string> list = new List<string> {"hyp calculator 0", "rise cal 1", "run cal 2","dis cal 3","slop cal 4","yintersept 5","randlist 6","randarray 7","reverse 8","quit 9" };
            List<int> gRl = new List<int>();
            int[] gRa= new int[39], point = new int[2];
            Console.WriteLine(MyMethods.GetHyp(3, 4));
            double perimeter=3+4+MyMethods.GetHyp(3, 4);
            Console.WriteLine($"the perimeter is {perimeter}cm");
            Console.WriteLine(MyMethods.GetLeg(5, 3));
            perimeter=5+3+MyMethods.GetLeg(5, 3);
            Console.WriteLine($"the perimeter is {perimeter}cm");
            Console.WriteLine("Hi type the number afer the word to do it");
            for(i=0;i<list.Count;i++)
            {
                if (i < list.Count - 1)
                    Console.Write(list[i] + ", ");
                else
                    Console.WriteLine(list[i]);
            }
            while (done != true)
            {
                s = Console.ReadLine().Trim();
                if (s == "0")
                {
                    Console.WriteLine("Type two numbers or numbs with { . } with a , in between");
                    s = Console.ReadLine().Trim();
                    ioc = s.IndexOf(",");
                    tp = int.TryParse(s.Substring(0, ioc), out itp);
                    stp = int.TryParse(s.Substring(ioc + 1), out istp);
                    if (s.Contains("."))
                    {
                        double.TryParse(s.Substring(0, ioc), out dtp);
                        double.TryParse(s.Substring(++ioc), out dstp);
                        gh = MyMethods.GetHyp(dtp, dstp);
                        Console.WriteLine(gh);
                    }
                    else if (tp == true && stp == true)
                    {
                        dtp = itp;
                        dstp = istp;
                        gh = MyMethods.GetHyp(dtp, dstp);
                        Console.WriteLine(gh);
                    }
                    else
                        Console.WriteLine("You need numbers");
                }
                else if (s == "1")
                {
                    Console.WriteLine("Type two numbers or numbs with { . } with a , in between the first must be more");
                    s = Console.ReadLine().Trim();
                    ioc = s.IndexOf(",");
                    tp = int.TryParse(s.Substring(0, ioc), out itp);
                    stp = int.TryParse(s.Substring(ioc + 1), out istp);
                    int.TryParse(s.Substring(0, ioc), out ss0i);
                    int.TryParse(s.Substring(ioc + 1), out ssi);
                    if (ss0i > ssi)
                    {
                        if (s.Contains("."))
                        {
                            double.TryParse(s.Substring(0, ioc - 1), out dtp);
                            double.TryParse(s.Substring(++ioc), out dstp);
                            gh = MyMethods.GetLeg(dtp, dstp);
                            Console.WriteLine(gh);
                        }
                        else if (tp == true && stp == true)
                        {
                            dtp = itp;
                            dstp = istp;
                            gh = MyMethods.GetLeg(dtp, dstp);
                            Console.WriteLine(gh);
                        }
                        else
                            Console.WriteLine("You need numbers");
                    }
                    else
                        Console.WriteLine("the first needs to be more");
                }
                else if (s == "2")
                {
                    Console.WriteLine("type 2 nums.8 with , inbetween");
                    s = Console.ReadLine().Trim();
                    ioc = s.IndexOf(",");
                    selp[0] = s.Substring(0, ioc);
                    selp[1] = s.Substring(ioc + 1);
                    tp = int.TryParse(selp[0], out emt) || int.TryParse(selp[1], out emt);
                    if (s.Contains("."))
                    {
                        selp[0] = selp[0].Replace(".", ",");
                        selp[1] = selp[1].Replace(".", ",");
                        ioc = selp[0].IndexOf(",");
                        xys[0].Y = int.Parse(selp[0].Substring(0, ioc)); xys[0].X = int.Parse(selp[0].Substring(ioc + 1));
                        xys[1].Y = int.Parse(selp[1].Substring(0, ioc)); xys[1].X = int.Parse(selp[1].Substring(ioc + 1));
                        double huble = MyMethods.GetRise(xys[0], xys[1]);
                        Console.WriteLine(huble);
                    }
                    else if (tp == true)
                    {
                        int.TryParse(selp[0], out point[0]);
                        int.TryParse(selp[1], out point[1]);
                        double huble = MyMethods.GetRise(xys[0], xys[1]);
                        Console.WriteLine(huble);
                    }
                    else Console.WriteLine("need numbers");
                }
                else if (s == "3")
                {
                    Console.WriteLine("enter 4 nums with , in between or two nums like 0.0 and , inbetween");
                    s = Console.ReadLine().Trim();
                    ioc = s.IndexOf(",");
                    tp = int.TryParse(s.Substring(0, ioc), out x);
                    if (s.Contains("."))
                    {
                        iop = s.IndexOf(".");
                        int.TryParse(s.Substring(0, iop), out x);
                        int.TryParse(s.Substring(iop + 1), out y);
                        ioy = s.IndexOf(y.ToString());
                        s = s.Replace(x.ToString() + "," + y.ToString(), "");
                        iop = s.IndexOf(".");
                        int.TryParse(s.Substring(0, iop), out x1);
                        int.TryParse(s.Substring(iop + 1), out y1);
                        coor[0].X = x;
                        coor[0].Y = y;
                        coor[1].X = x1;
                        coor[1].Y = y1;
                        dis = MyMethods.GetDis(coor[0], coor[1]);
                        Console.WriteLine(dis);
                    }
                    else if (tp == true)
                    {
                        int.TryParse(s.Substring(0, ioc), out x);
                        int.TryParse(s.Substring(ioc + 1, 1), out y);
                        ioy = s.IndexOf(y.ToString());
                        s = s.Replace(x.ToString() + "," + y.ToString() + ",", "");
                        ioc = s.IndexOf(",");
                        int.TryParse(s.Substring(0, ioc), out x1);
                        int.TryParse(s.Substring(ioc + 1, 1), out y1);
                        dis = MyMethods.GetDis(x, y, x1, y1);
                        Console.WriteLine(dis);
                    }
                    else Console.WriteLine("You need numbers");
                }
                else if (s == "4")
                {
                    Console.WriteLine("4 nums , or 2 num.7 ,");
                    s = Console.ReadLine().Trim();
                    ioc = s.IndexOf(",");
                    tp = int.TryParse(s.Substring(0, ioc), out x);
                    if (s.Contains("."))
                    {
                        iop = s.IndexOf(".");
                        int.TryParse(s.Substring(0, iop), out x);
                        int.TryParse(s.Substring(iop + 1, ioc), out y);
                        s = s.Replace(x.ToString() + "." + y.ToString(), "");
                        iop = s.IndexOf(".");
                        int.TryParse(s.Substring(0, iop), out x1);
                        int.TryParse(s.Substring(iop + 1), out y1);
                        coor[0].X = x;
                        coor[0].Y = y;
                        coor[1].X = x1;
                        coor[1].Y = y1;
                        dis = MyMethods.GetSlope(coor[0], coor[1]);
                    }
                    else if (tp == true)
                    {
                        int.TryParse(s.Substring(0, ioc), out x);
                        int.TryParse(s.Substring(ioc + 1), out y);
                        s = s.Replace(x.ToString() + "," + y.ToString() + ",", "");
                        ioc = s.IndexOf(",");
                        int.TryParse(s.Substring(0, ioc), out x1);
                        int.TryParse(s.Substring(ioc + 1), out y1);
                        dis = MyMethods.GetSlope(x, y, x1, y1);
                    }
                    else
                        Console.WriteLine("You need numbers");
                }
                else if (s == "5")
                {
                    stp = done;
                    while (stp == done)
                    {
                        Console.WriteLine("5 nums , 2 nums.7,num ,");
                        s = Console.ReadLine().Trim();
                        ioc = s.IndexOf(",");
                        tp= int.TryParse(s.Substring(0, ioc), out x);
                        if (s.Contains("."))
                        {
                            iop = s.IndexOf(".");
                            int.TryParse(s.Substring(0, iop), out x);
                            int.TryParse(s.Substring(iop + 1, ioc), out y);
                            s = s.Replace(x.ToString() + "." + y.ToString(), "");
                            iop = s.IndexOf(".");
                            int.TryParse(s.Substring(0, iop), out x1);
                            int.TryParse(s.Substring(iop + 1), out y1);
                            coor[0].X = x;
                            coor[0].Y = y;
                            coor[1].X = x1;
                            coor[1].Y = y1;
                            
                        }
                        else if(tp== true)
                        {
                            int.TryParse(s.Substring(0, ioc), out x);
                            int.TryParse(s.Substring(ioc + 1, 1), out y);

                        }
                    }
                }
                else if (s == "6") ;
                else if (s == "7") ;
                else if (s == "8") ;
                else if (s == "9")
                    done = true;
                else
                    Console.WriteLine("type a number between 0 and 10 nothing above 10 or bleow 0");
            }
        }
    }
}