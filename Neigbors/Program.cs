using static System.Console;
using static System.Convert;
using static System.Math;


double a, b, f ,c=0;


string str1 = ReadLine();
var arr1 = str1.Split(" ");
a = ToDouble(arr1[0]);
b = ToDouble(arr1[1]);
f = ToDouble(arr1[2]);
 
c = Ceiling(Sqrt(Pow(a,2)+Pow(b,2)));

double size = Ceiling(c / f);

WriteLine((long) size*size) ;