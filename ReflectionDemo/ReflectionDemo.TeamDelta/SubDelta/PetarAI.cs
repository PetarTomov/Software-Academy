namespace ReflectionDemo.TeamDelta.SubDelta
{
    using ReflectionDemo.Infrastructure.Interfaces;
    using ReflectionDemo.Infrastructure.Roles.ProfesionalServices;
    using ReflectionDemo.TeamDelta.Interfaces;
    using System;
    public class PetarAI : IDev, IUser, IAI, IFunctionalities
    {
        public void Print()
        {
            Console.WriteLine("I am Petar from Subteam Delta. Nice to meet you!");
        }
    }
}
