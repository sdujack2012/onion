using Main;
using Ninject;
using ServiceInterfaces;
using System;

namespace Domain
{
    class Program
    {
        public static void Main(string[] args)
        {
            var module = new OnionModule();
            var kernel = new StandardKernel(module);
            var userService = kernel.Get<IUserService>();
            userService.DeleteUSer(123);
            Console.WriteLine("Hello World!");
        }
    }
}
