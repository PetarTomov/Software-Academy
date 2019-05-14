namespace TeamB2B
{
    using ReflectionDemo.Infrastructure.Interfaces;
    using ReflectionDemo.Infrastructure.Roles.ProfesionalServices;
    using ReflectionDemo.TeamDelta.Interfaces;
    using System;

    public abstract class YordankaAI : IDev, IUser, IAI, IFunctionalities
    {
        public void Print()
        {
            Console.WriteLine("I am Yordanka. Nice to meet you!");
        }
    }
}