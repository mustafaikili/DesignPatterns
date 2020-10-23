using System;
using TemplateMethod.Abstract;
using TemplateMethod.Concrete;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClassA = new ConcreteClassA();
            abstractClassA.TemplateMethod();
            
            AbstractClass abstractClassB = new ConcreteClassB();
            abstractClassB.TemplateMethod();
        }
    }
}