﻿using System;
namespace operatorler
{
    class Program
    {
        static void Main(string[]args)
    {
        //Operatörler
int x=3;
int y=3;
y+=2;
Console.WriteLine(y);
y+=2;
Console.WriteLine(y);
y/=1;
Console.WriteLine(y);


x*=2;
Console.WriteLine(x);

Console.WriteLine("****Mantıksal Operatörler****");
//Mantıksal Operatörler
// ||(veya),&&(ve),!(olumsuz)

bool isSuccess=true;
bool isCompleted=false;

if(isSuccess && isCompleted)
Console.WriteLine("Perfect");

if(isSuccess || isCompleted)
Console.WriteLine("Great");

if(isSuccess && !isCompleted)
Console.WriteLine("Fine");

Console.WriteLine("****İlişkisel Operatörler****");
//İlişkisel Operatörler
// <,>,<=,>=,==,!=

int a=3;
int b=4;
bool sonuc=a<b;
Console.WriteLine(sonuc);
 sonuc=a>b;
Console.WriteLine(sonuc);
 sonuc=a>=b;
Console.WriteLine(sonuc);
 sonuc=a<=b;
Console.WriteLine(sonuc);
 sonuc = a==b;
System.Console.WriteLine(sonuc);
 sonuc = a!=b;
System.Console.WriteLine(sonuc);

//Aritmetik Operatörler
// /,*,-,+

int sayi1=10;
int sayi2=5;
int sonuc1=sayi1/sayi2;
System.Console.WriteLine(sonuc1);
sonuc1=sayi1*sayi2;
System.Console.WriteLine(sonuc1);
sonuc1=sayi1+sayi2;
System.Console.WriteLine(sonuc1);
sonuc1=sayi1-sayi2;
System.Console.WriteLine(sonuc1);
sonuc1=++sayi1;
System.Console.WriteLine(sonuc1);

int sonuc2=20%3;
System.Console.WriteLine(sonuc2);
    }
    }
}
