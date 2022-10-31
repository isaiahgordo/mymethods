﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mymethods
{
    static class MyMethods
    {
        public static double GetHyp(double a,double b)
        {
            return Math.Sqrt(a*a + b*b);
        }
        public static double GetLeg(double c,double ab)
        {
            return Math.Sqrt(c*c-ab*ab);
        }
        public static double GetRise(double y1,double y2)
        {
            return y1 - y2;
        }
        public static double GetRise(Point p1,Point p2)
        {
            return GetRise(p1.Y,p2.Y);
        }
        public static double GetRun(double x1,double x2)
        {
            return x1- x2;
        }
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X,p2.X);
        }
        public static double GetDis(double x1,double x2, double y1, double y2)
        {
             return Math.Sqrt((x2 - x1)* (x2 - x1) + (y2-y1)* (y2 - y1));
        }
        public static double GetDis(Point p1,Point p2)
        {
            return GetDis(p1, p2);
        }
        public static double GetSlope(double x1,double x2,double y1,double y2)
        {
            return (y1-y2)/(x1-x2);
        }
        public static double GetSlope(Point p1, Point p2)
        {
            return GetSlope(p1, p2);
        }
        public static double GetYInterdex(Point p1,Point p2,double x1)
        {
            return ((p1.Y-p2.Y)/(p1.X-p2.X)*x1);
        }
        public static bool IsRight(double s1,double s2,double s3)
        {
            return s1*s1+s2*s2==s3*s3;
        }
        public static List<int> GetRandList(int max,int min, int size)
        {
            int rum;
            Random r = new Random();
            rum = r.Next(min, max + 1);
            List<int>randlist= new List<int>();
            for(int i=0;i<size;i++)
            {
                randlist.Add(rum);
                rum = r.Next(min, max + 1);
            }
            return randlist;
        }
        public static int[] GetRandArray(int max, int min, int size)
        {
            int rum;
            Random r = new Random();
            rum = r.Next(min, max + 1);
            int[] randarray = new int[size];
            for(int i=0;i<randarray.Length;i++)
            {
                randarray[i] = rum;
                rum = r.Next(min, max + 1);
            }
            return randarray;
        }
        public static string Reverse(string forw,string back)
        {
            int fl;
            StringBuilder sb = new StringBuilder(forw);
            fl = forw.Length;
            for(int i=fl-1;i>0;i--)            
                back = back + sb[i];
            return back;
        }
        public static double Averge(double[] doubnt,double sum,double done)
        {
            int dtl=doubnt.Length,i;
            for(i=0;i<dtl;i++)            
                sum =sum+ doubnt[i];
            done = sum / dtl;
            return done;
        }
        public static double Averge(int[]inuble,int il)
        {
            il=inuble.Length;
            double[] ld=new double[il];
            int i;
            for(i=0;i<il;i++)
                ld[i] = inuble[i] +0.00;
            return Averge(ld, 0.00, 0);
        }
        public static double RootChecker(double a,double b, double c)
        {
            double sum = Math.Sqrt(a);
            sum=sum+ Math.Sqrt(b);
            sum=sum+ Math.Sqrt(c);
            return sum;
        }
        public static double RootChecker(int a2,int b2,int c2)
        {
            double a=a2,b=b2,c=c2;
            return RootChecker(a, b, c);
        }
        public static double Circumference(double r)
        {
            double c=r*r*Math.PI;
            return c;
        }
        public static double Circumference(int r2)
        {
            double r=r2;
            return Circumference(r);
        }
        
    }
}
