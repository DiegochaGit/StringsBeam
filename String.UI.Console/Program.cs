using Strings.Logic;
using System;

var myBeams = new MyString[]
{
    new MyString("%"),                               //b=t, c=t, w=0, r=t
    new MyString("%=*"),                             //b=t, c=t, w=3, r=t
    new MyString("%==="),                            //b=t, c=t, w=6, r=t
    new MyString("%===*"),                           //b=t, c=t, w=18, r=f
    new MyString("&===*"),                           //b=t, c=t, w=18, r=t
    new MyString("&===*==*="),                       //b=t, c=t, w=28, r=t
    new MyString("#===========*"),                   //b=t, c=t, w=198, r=f
    new MyString("#====*====================*=="),   //b=t, c=t, w=663, r=f
    new MyString("&====*====================*=========*======*=====*===="), //b=t, c=t, w=913, r=f
    new MyString("#==**=="),                         //b=t, c=f, w=12, r=t
    new MyString("#====**=====*"),                   //b=t, c=f, w=75, r=t
    new MyString("&=====**====**======"),           //b=t, c=f, w=96, r=f
    new MyString("*==*"),                            //b=f, c=t, w=9, r=t
    new MyString("$===*"),                           //b=f, c=t, w=18, r=t
    new MyString("*===*==*="),                       //b=f, c=t, w=28, r=t
    new MyString("$===*==*="),                       //b=f, c=t, w=28, r=t
    new MyString("*===*==*==="),                     //b=f, c=t, w=33, r=t
};

foreach (var myBeam in myBeams)
{
    Console.WriteLine("\n___________________________________");
    Console.Write("\nThe beam is: ");
    Console.WriteLine(myBeam.PrintString(myBeam));

    if (myBeam.ValidateBase())
    {
        Console.Write("\nThe beam has a valid base");
    }
    else
    {
        Console.Write("\nThe beam hasn't a valid base");
    }

    if (myBeam.ValidateConnections())
    {
        Console.Write("\nThe beam has valid connections");
    }
    else
    {
        Console.Write("\nThe beam hasn't valid connections");
    }

    Console.Write("\nThe beam has a weight of ");
    Console.Write(myBeam.CalculateWeightBeam());

    if ((myBeam.ValidateBase() && myBeam.ValidateConnections()))
    {
        if (myBeam.beamResists(myBeam.CalculateWeightBeam()))
        {
            Console.WriteLine("\nThe beam resist the weight");
        }
        else
        {
            Console.Write("\nThe beam hasn't resist the weight");
        }
    } 
    else
    {
        Console.WriteLine("\nWrong beam! It is not calculated if it resists or not");
    }
    
 }


