
namespace ReflectionDemo
{
    using ReflectionDemo.Infrastructure.Interfaces;
    using ReflectionDemo.TeamDelta.Interfaces;
    using ReflectionDemo.TeamDelta.SubDelta;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using TeamB2B;

    class Program
    {
        static void Main(string[] args)
        {
            typeof(IGeneral).Assembly.GetTypes()
                .Where(x => typeof(IFunctionalities).IsAssignableFrom(x)
                    && x.Name.Contains("AI")
                    && x.GetInterfaces().Any(i => i.Name.Contains("AI"))
                    && !x.IsAbstract)
                .ToList()
                .ForEach(t => ((IFunctionalities)Activator.CreateInstance(t)).Print());

            Console.ReadKey();
        }
    }
}
