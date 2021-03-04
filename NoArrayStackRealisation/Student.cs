using System;

namespace NoArrayStackRealisation
{
    public class Student
    {
        private int _age;
        private string _name;
        private string _surname;

        public Student(int age, string name, string surname)
        {
            _age = age;
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _surname = surname ?? throw new ArgumentNullException(nameof(surname));
        }
    }
}