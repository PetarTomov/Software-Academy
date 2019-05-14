namespace TeamB2B
{
    using ReflectionDemo.Infrastructure.Interfaces;
    using ReflectionDemo.Infrastructure.Roles.ProfesionalServices;
    using System;

    public class Petar : IDev, IUser, IFunctionalities
    {
        public void Print()
        {
            Console.WriteLine("I am Petar. Nice to meet you!");
        }
    }
}
