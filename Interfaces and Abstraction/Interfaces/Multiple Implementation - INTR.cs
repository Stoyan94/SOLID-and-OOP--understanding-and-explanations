English Explanation – Relationship between Classes and Interfaces
1️⃣ Interfaces and Classes

An interface defines a contract — what methods, properties, or events a class should implement.

A class provides the actual implementation of the interface members.


2️⃣ Multiple Implementation

A class can implement multiple interfaces.

Example:

interface IMovable
{
    void Move();
}

interface IRotatable
{
    void Rotate();
}

class Robot : IMovable, IRotatable
{
    public void Move()
    {
        Console.WriteLine("Robot is moving.");
    }

    public void Rotate()
    {
        Console.WriteLine("Robot is rotating.");
    }
}


Here, the Robot class implements two interfaces — IMovable and IRotatable.
This is called multiple implementation.

3️⃣ Inheritance in Interfaces

An interface can inherit from one or more other interfaces.

Example:

interface IA
{
    void A();
}

interface IB
{
    void B();
}

interface IC : IA, IB
{
    void C();
}


IC inherits from IA and IB, so any class implementing IC must implement A(), B(), and C().

This is multiple inheritance, but only for interfaces (not classes).



4️⃣ Key Rules

A class can extend one base class but implement multiple interfaces.

An interface can extend multiple interfaces.

Syntax overview:

Interface extends Interface1, Interface2  // multiple inheritance
Class extends BaseClass implements I1, I2  // multiple implementation


Graphically:

Interface1 < ---Interface3 < ---Interface4
ClassA-- - implements--->Interface4
ClassB-- - extends--->ClassA







🇧🇬 Българско обяснение – Връзка между класове и интерфейси


1️⃣ Интерфейси и класове

Интерфейсът определя договор – какви методи, свойства или събития трябва да има един клас.

Класът дава реалната имплементация на членовете на интерфейса.



2️⃣ Множествена имплементация

Един клас може да имплементира повече от един интерфейс.

Пример:

interface IMovable
{
    void Move();
}

interface IRotatable
{
    void Rotate();
}

class Robot : IMovable, IRotatable
{
    public void Move()
    {
        Console.WriteLine("Роботът се движи.");
    }

    public void Rotate()
    {
        Console.WriteLine("Роботът се върти.");
    }
}


Тук класът Robot имплементира два интерфейса – IMovable и IRotatable.

Това е множествена имплементация.



3️⃣ Наследяване при интерфейсите

Един интерфейс може да наследява един или повече други интерфейси.

Пример:

interface IA
{
    void A();
}

interface IB
{
    void B();
}

interface IC : IA, IB
{
    void C();
}


IC наследява IA и IB, затова клас, който имплементира IC, трябва да има A(), B() и C().

Това е множествено наследяване, но само за интерфейси (не за класове).

4️⃣ Основни правила

Клас може да наследи един базов клас, но да имплементира множество интерфейси.

Интерфейс може да наследява множество интерфейси.

Синтаксис:

Interface extends Interface1, Interface2  // множествено наследяване
Class extends BaseClass implements I1, I2  // множествена имплементация


Графично:

Interface1 < ---Interface3 < ---Interface4
ClassA-- - implements--->Interface4
ClassB-- - extends--->ClassA