
Модификаторът protected в C# означава, че дадено поле или метод може да се достъпва само в рамките на същия клас и във всички негови наследници (подкласове). 

Тоест – не е видимо за външен код, но е достъпно за класове, които наследяват този.

Пример:

public class Person
{
    protected string Name;
}

public class Student : Person
{
    public void PrintName()
    {
        Console.WriteLine(Name); // достъпно, защото Student наследява Person
    }
}

public class Test
{
    public void Run()
    {
        Person p = new Person();
        // p.Name = "Stamo"; ❌ Грешка – Name е protected и не може да се достъпи отвън
    }
}


➡️ Достъпност:

✅ В същия клас

✅ В наследени (derived) класове

❌ Не е достъпно извън класа, ако не е наследен

🇬🇧 Explanation (in English):
The protected access modifier in C# means that a field or method can be accessed only within the same class and its derived (child) classes. It is not visible to external code.

Example:

public class Person
{
    protected string Name;
}

public class Student : Person
{
    public void PrintName()
    {
        Console.WriteLine(Name); // accessible because Student inherits from Person
    }
}

public class Test
{
    public void Run()
    {
        Person p = new Person();
        // p.Name = "Stamo"; ❌ Error – Name is protected and cannot be accessed from outside
    }
}


➡️ Accessibility:

✅ Within the same class

✅ In derived classes

❌ Not accessible from outside the class hierarchy