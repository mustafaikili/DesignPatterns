using System;

namespace TemplateMethod.Abstract
{
    public abstract class AbstractClass
    {
        private static void  Login()
        {
            Console.WriteLine("logged in...");
        }
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            Login();
            PrimitiveOperation1();
            PrimitiveOperation2();
            Logout();
        }

        private static void Logout()
        {
            Console.WriteLine("Logged out...");
        }
    }
}