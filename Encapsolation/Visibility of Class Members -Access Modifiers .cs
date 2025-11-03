Български обяснения с примери


1. Private / Частен

Основен начин за инкапсулация и скриване на данни от външния свят.

Достъпен само в рамките на класа, в който е деклариран.

По подразбиране полетата и методите са private.

Не се препоръчва за класове и интерфейси.

Пример:

public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }
}


2.Public / Публичен

Най - позволителният достъп.

Може да се достъпва от всяка част на кода, включително други проекти чрез namespace.

Използва се за членове и класове, които трябва да са широко достъпни.

Пример:

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


3. Internal / Вътрешен

По подразбиране за класове.

Достъпен от всички класове в същия проект(assembly).

Не се вижда извън проекта.

Пример:

internal class Person
{
    internal string Name { get; set; }
    internal int Age { get; set; }
}


4. Protected / Защитен

Достъпен само в самия клас и в наследниците му.

Позволява наследниците да виждат или модифицират членове, но остава скрит за останалите.

Често се използва за инкапсулация с наследяване.

Пример:

public class Person
{
    protected string Name;

    public Person(string name)
    {
        this.Name = name;
    }
}

public class Employee : Person
{
    public Employee(string name) : base(name)
    {
        Console.WriteLine("Employee Name: " + Name); // достъпно, защото е наследник
    }
}





English explanations with examples
1. Private

Main way to perform encapsulation and hide data from the outside world.

Accessible only within the class itself.

By default, fields and methods are private.

Avoid declaring private classes and interfaces.

Example:

public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name;
    }
}


2. Public

Most permissive access level.

Can be accessed from anywhere in the code, including other projects if the namespace is included.

Used for members and classes that must be widely accessible.

Example:

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


3. Internal

Default access modifier for classes.

Accessible to any class in the same project(assembly).

Not visible outside the project.

Example:

internal class Person
{
    internal string Name { get; set; }
    internal int Age { get; set; }
}


4. Protected

Accessible only from within the class itself and derived classes.

Allows derived classes to see or modify a variable or method, while keeping it hidden from others.

Commonly used for encapsulation with inheritance.

Example:

public class Person
{
    protected string Name;

    public Person(string name)
    {
        this.Name = name;
    }
}

public class Employee : Person
{
    public Employee(string name) : base(name)
    {
        Console.WriteLine("Employee Name: " + Name); // accessible because it's a derived class
    }
}