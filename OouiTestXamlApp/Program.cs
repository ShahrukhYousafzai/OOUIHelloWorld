using Ooui;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace OouiTestXamlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();
            var page = new Page1();
            UI.Publish("/", page.GetOouiElement());
        }
    }
}
