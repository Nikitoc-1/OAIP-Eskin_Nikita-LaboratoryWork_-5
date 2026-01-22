
using Laba5OAIP;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
namespace Hello
{
    class Program 
    {
        static void Main() {
            Scope range = new Scope();
            int a, b, c;
            range.Read(out a, out b, out c);
            string total = range.rangecheck(a, b, c);
            range.Display(total);
        }
    }
}