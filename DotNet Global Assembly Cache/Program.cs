using System;
using System.Reflection;

//ref link:https://www.youtube.com/watch?v=3Fr2AgycXeI&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=19
// GAC - GLOBAL Assembly Cache


/*---------------------------CMD---------------------------------------
 * 
C:\Users\sunny\source\repos\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache

28/09/2023  10:52 am    <DIR>          .
28/09/2023  10:52 am    <DIR>          ..
28/09/2023  10:52 am             2,581 .gitattributes
28/09/2023  10:52 am             6,585 .gitignore
28/09/2023  10:56 am    <DIR>          DotNet Global Assembly Cache
27/09/2023  03:38 pm             1,190 DotNet Global Assembly Cache.sln
               3 File(s)         10,356 bytes
               3 Dir(s)  487,886,749,696 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache>cd DotNet Global Assembly Cache

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  10:56 am    <DIR>          .
28/09/2023  10:56 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  10:56 am               535 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               3 File(s)          3,130 bytes
               5 Dir(s)  487,874,166,784 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>sn -k KulpotKey.key

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.key

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:02 am    <DIR>          .
28/09/2023  11:02 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  10:58 am             2,040 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               4 File(s)          5,231 bytes
               5 Dir(s)  487,875,502,080 bytes free




 * 
 */


[assembly: AssemblyVersion("1.0.0.0")]

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moooooooooooooooooo version 1");
    }
}

//class MainClass
//{
//    static void Main()
//    {
//
//    }
//}