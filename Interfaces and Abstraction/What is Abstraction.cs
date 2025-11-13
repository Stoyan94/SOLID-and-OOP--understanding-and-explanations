1️⃣ Какво е абстракция?

Абстракцията идва от латинските думи:

Abs – „далеч от“

Trahere – „да се извлече, да се черпи“

В програмирането това означава:

Абстракцията е процесът на извличане на съществените характеристики на нещо и игнориране на ненужните детайли.

С други думи: фокусираш се само върху важното за контекста, а „шумът“ или детайлите, които не са нужни, се скриват.



2️⃣ Абстракция в C#

В C#, абстракцията се реализира главно чрез:

a) Абстрактни класове (abstract class)

Дефинират общи свойства и методи за група обекти, без да дават конкретна реализация за всичко.

Могат да съдържат абстрактни методи, които нямат тяло, и нормални методи с тяло.

Пример:

abstract class Vehicle
{
    public string Brand { get; set; }

    // Абстрактен метод – конкретните класове ще го имплементират
    public abstract void Start();

    // Метод с тяло – вече има реализация
    public void Honk()
    {
        Console.WriteLine("Beep!");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine($"{Brand} car started!");
    }
}


✅ Обяснение:

Vehicle е абстрактен – не можеш да създадеш new Vehicle().

Car наследява Vehicle и дава конкретна реализация на метода Start().

Потребителят на класа Car няма нужда да знае как работи Start() вътрешно, само че може да стартира колата.



b) Интерфейси (interface)

Описват какви методи/свойства един клас трябва да има, без да дефинират конкретна реализация.

Позволяват различни класове да имат общо поведение, без да споделят наследство.

Пример:

interface IFlyable
{
    void Fly();
}

class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying!");
    }
}

class Airplane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Airplane is flying!");
    }
}


✅ Обяснение:

IFlyable е абстрактна концепция – „нещо, което може да лети“.

Bird и Airplane имплементират интерфейса по различен начин.

Кодът, който използва IFlyable, не се интересува от детайлите, просто знае: може да се извика Fly().



3️⃣ Защо е полезна абстракцията?

Скрива сложността (Encapsulation + Abstraction)

Позволява писане на по-общ, универсален код

Лесно разширяване и поддръжка

Позволява полиморфизъм: различни обекти могат да се третират по един и същ начин, без да се знаят детайлите им











1️⃣ What is Abstraction?

Abstraction comes from Latin:

Abs – “away from”

Trahere – “to draw, extract”

In programming:

Abstraction is the process of extracting the essential characteristics of something while ignoring irrelevant details.

In other words: you focus only on what is important in a given context and hide the unnecessary details.



2️⃣ Abstraction in C#

In C#, abstraction is mainly implemented through:

a) Abstract Classes

Define common properties and methods for a group of objects, but do not provide full implementation for everything.

Can contain abstract methods(no body) and regular methods (with body).

Example:

abstract class Vehicle
{
    public string Brand { get; set; }

    // Abstract method – derived classes must implement
    public abstract void Start();

    // Method with body – already implemented
    public void Honk()
    {
        Console.WriteLine("Beep!");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine($"{Brand} car started!");
    }
}


✅ Explanation:

Vehicle is abstract – you cannot create new Vehicle().

Car inherits Vehicle and provides the specific implementation of Start().

The user of Car does not need to know the inner workings of Start(), just that it starts the car.



b) Interfaces

Define what methods/properties a class must have without providing implementation.

Allow different classes to share common behavior without inheritance.

Example:

interface IFlyable
{
    void Fly();
}

class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Bird is flying!");
    }
}

class Airplane : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Airplane is flying!");
    }
}


✅ Explanation:

IFlyable is an abstract concept – “something that can fly.”

Bird and Airplane implement the interface differently.

Code using IFlyable does not care about the details; it just calls Fly().




3️⃣ Why is Abstraction Useful?

Hides complexity (Encapsulation + Abstraction)

Allows writing more general and reusable code

Makes code easy to extend and maintain

Enables polymorphism: different objects can be treated the same way without knowing their details