Abstract Classes and Methods in C#


1️⃣ What is an Abstract Class?

An abstract class is a class that cannot be instantiated directly.

It can contain:

Abstract methods(without implementation)

Concrete methods(with implementation)

Properties, fields, events

Abstract classes are used when you want to define common behavior for a group of related classes but also leave some methods to be implemented by derived classes.


2️⃣ Key Features

Cannot be instantiated:

abstract class Shape { }
Shape s = new Shape(); // ❌ Compilation error


Can contain abstract methods and accessors:

abstract class Shape
{
    public abstract double Area(); // abstract method, no body
}


Can contain concrete (implemented) methods:

abstract class Shape
{
    public abstract double Area();

    public void PrintInfo()
    {
        Console.WriteLine("This is a shape.");
    }
}


Must provide implementation for all inherited interface members if the abstract class implements an interface:

interface IPrintable
{
    void Print();
}

abstract class Document : IPrintable
{
    public abstract void Print(); // abstract method maps interface method
}


Here, Document implements IPrintable, but instead of providing a full implementation, it declares Print() as abstract, leaving it to derived classes.


3️⃣ Abstract Methods

Declared with abstract keyword

No body / implementation in the abstract class

Must be overridden in a non-abstract derived class

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}


4️⃣ Syntax Summary
// Abstract class
abstract class BaseClass
{
    public abstract void AbstractMethod(); // must be overridden
    public void ConcreteMethod()           // optional implementation
    {
        Console.WriteLine("Concrete implementation");
    }
}

// Derived class
class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        Console.WriteLine("Implemented abstract method");
    }
}



5️⃣ When to Use Abstract Classes

When you want to share code among related classes.

When some methods must be implemented differently in each derived class.

When implementing an interface but you want to leave some methods abstract.

To enforce a common contract plus shared code (unlike interfaces, abstract classes can have fields, constructors, and concrete methods).



6️⃣ Real-world Example
abstract class Vehicle
{
    public abstract void StartEngine();

    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
}

class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }
}

// Usage
Vehicle myCar = new Car();
myCar.StartEngine(); // "Car engine started"
myCar.Honk();        // "Beep beep!"


Here, Vehicle is abstract, providing shared method Honk() and an abstract method StartEngine() that each derived class must implement.





🇧🇬 Абстрактни класове и методи в C#

1️⃣ Какво е абстрактен клас?

Абстрактният клас не може да бъде инстанциран директно.

Може да съдържа:

Абстрактни методи(без имплементация)

Реализирани методи(с тяло)

Свойства, полета, събития

Използва се, когато искаш да дефинираш общо поведение за група свързани класове, но някои методи да оставиш за имплементация в наследниците.



2️⃣ Основни характеристики

Не може да се създава инстанция:

abstract class Shape { }
Shape s = new Shape(); // ❌ Грешка


Може да съдържа абстрактни методи и аксесори:

abstract class Shape
{
    public abstract double Area(); // абстрактен метод
}


Може да съдържа реализирани методи:

abstract class Shape
{
    public abstract double Area();

    public void PrintInfo()
    {
        Console.WriteLine("Това е форма.");
    }
}


Ако абстрактен клас имплементира интерфейс, трябва да покрие всички членове, или да ги остави абстрактни:

interface IPrintable
{
    void Print();
}

abstract class Document : IPrintable
{
    public abstract void Print(); // абстрактен метод
}



3️⃣ Абстрактни методи

Декларират се с abstract

Нямат тяло

Трябва да се override-нат в конкретен наследник

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}



4️⃣ Синтаксис
// Абстрактен клас
abstract class BaseClass
{
    public abstract void AbstractMethod(); // задължително override
    public void ConcreteMethod()           // по избор
    {
        Console.WriteLine("Реализиран метод");
    }
}

// Наследник
class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        Console.WriteLine("Имплементация на абстрактния метод");
    }
}



5️⃣ Кога се използва абстрактен клас

Когато искаш да споделяш код между свързани класове

Когато някои методи трябва да се имплементират различно във всеки наследник

Когато имплементираш интерфейс, но искаш някои методи да оставят абстрактни

За да наложиш общ договор + споделен код (за разлика от интерфейс, абстрактен клас може да има полета, конструктори и реализирани методи)



6️⃣ Пример от реалния свят
abstract class Vehicle
{
    public abstract void StartEngine();

    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
}

class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }
}

// Използване
Vehicle myCar = new Car();
myCar.StartEngine(); // "Car engine started"
myCar.Honk();        // "Beep beep!"


Абстрактният клас Vehicle предоставя споделен метод Honk() и абстрактен метод StartEngine(), който всеки наследник трябва да имплементира.