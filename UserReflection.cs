using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace UserRegistrationReflections
{
    class UserReflection
    {
        public static void UserRegistrationReflectionTest()
        {
            Type type = typeof(User);
            Console.WriteLine("Full Name: {0}", type.FullName);
            Console.WriteLine("Class Name: {0}", type.Name);
            Console.WriteLine("\nMethods in User class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine("\nProperties in User class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine("\nConstructors in User class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            Console.WriteLine("\nFields in User class");
            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.ToString());
            }


        }
    }
}
