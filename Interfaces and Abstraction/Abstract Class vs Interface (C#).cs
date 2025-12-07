nterfaces vs Abstract Classes (C#) — Complete and Clear Explanation

We will go through everything point by point, with examples and syntax.


⭐ 1. Interface

✔ A class can implement multiple interfaces
class Car : IMovable, IRepairable
{
    public void Move() { }
    public void Repair() { }
}

✔ Interfaces do not have access modifiers

Everything inside an interface is public by default.

interface IMovable
{
    void Move(); // implicitly public
}

✔ Interfaces cannot contain method implementations

(Before C# 8 – classical version taught in most courses)

interface IAnimal
{
    void Speak(); // signature only, no body
}

❌ Interfaces cannot contain fields (variables)
interface ITest
{
    int number; // ❌ Error
}


They can contain only:

methods

properties

events

indexers

❗ If we add a new method → all implementing classes must override it
interface IWorker
{
    void Work();
}

// Adding this:
void Report(); // → must be implemented in ALL Worker classes



⭐ 2.Abstract Class
✔ A class can inherit only one abstract class
abstract class Animal
{
    public abstract void Speak();
}

✔ Can contain implementation + abstract methods
abstract class Animal
{
    public void Move() => Console.WriteLine("Animal moving...");
    public abstract void Speak();
}

✔ Supports access modifiers (public, private, protected)
abstract class Animal
{
    protected string name;
    public abstract void Speak();
}

✔ Can contain fields, properties, and constructors
abstract class Animal
{
    protected int age;
    public Animal(int age) => this.age = age;
}

✔ Adding a new method → can provide a default implementation

This does not break old code.

abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Default drawing...");
    }
}


| Feature                    | Interface                      | Abstract Class |
| -------------------------- | ------------------------------ | --------------------------------- |
| Multiple inheritance       | ✔ Yes                          | ❌ No |
| Fields(variables)          | ❌ No                          | ✔ Yes |
| Constructors               | ❌ No                          | ✔ Yes |
| Access modifiers           | ❌ No(everything is public)    | ✔ Yes |
| Method implementation      | ❌ No(in classical interfaces) | ✔ Yes |
| Abstract methods           | ✔ Yes                          | ✔ Yes |
| Default behavior           | ❌ No                          | ✔ Yes |
| Best used for              | Contracts, APIs                | Shared logic + required overrides |
| Can inherit another class? | ❌ No                          | ✔ Yes                             |




⭐ 4. Practical Comparison With Examples
🟦 Interface Example

A contract that describes what must be done, not how.

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Writing to file: " + message);
    }
}

🟩 Abstract Class Example

We have base logic + required overrides.

abstract class Payment
{
    public void Validate() => Console.WriteLine("Validating payment...");
    public abstract void Process();
}

class CreditCardPayment : Payment
{
    public override void Process()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

⭐ 5.When to Use Each? (Most Important Summary)
Use an Interface when:

You want a pure contract

You want multiple inheritance of behavior

Implementations may be completely different

You are designing APIs or plugin-like components

Use an Abstract Class when:

You want to provide partial implementation

You need fields, constructors, or protected members

You want to mix logic + required override methods



Interfaces vs Abstract Classes (C#) — Пълно и ясно обяснение

Ще минем точка по точка, с примери и синтаксис.

⭐ 1. Interface
✔ Може да се имплементират няколко интерфейса
class Car : IMovable, IRepairable
{
    public void Move() { }
    public void Repair() { }
}

✔ Интерфейсът няма access modifiers

Всичко вътре е public по дефиниция.

interface IMovable
{
    void Move(); // public по подразбиране
}

✔ Не може да съдържа имплементация на методи

(преди C# 8 — по-старата версия, която се учи в повечето курсове)

interface IAnimal
{
    void Speak();   // само сигнатура
}

❌ Не може да съдържа полета (fields)
interface ITest
{
    int number; // ❌ Грешка
}


Само properties, methods, events, indexers.

❗ Ако добавим нов метод – всички имплементации трябва да го override-нат
interface IWorker
{
    void Work();
}

// ако добавим това:
void Report(); // → трябва да се добави във ВСЕКИ Worker клас



⭐ 2.Abstract Class
✔ Може да наследиш само един abstract class
abstract class Animal
{
    public abstract void Speak();
}

✔ Може да съдържа имплементация + abstract методи
abstract class Animal
{
    public void Move() => Console.WriteLine("Animal moving...");
    public abstract void Speak();
}

✔ Има access modifiers (public/private/protected)
abstract class Animal
{
    protected string name;
    public abstract void Speak();
}

✔ Може да съдържа полета, свойства, конструктори
abstract class Animal
{
    protected int age;
    public Animal(int age) => this.age = age;
}

✔ Ако добавим нов метод → можем да дадем default имплементация

Това НЕ чупи стария код.

abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Default drawing...");
    }
}


⭐ 3.Пълна сравнителна таблица(синтезирана)

| Функционалност             | Interface                          | Abstract Class |
| -------------------------- | --------------------------------   | --------------------------------------- |
| Multiple inheritance       | ✔ Да                              | ❌ Не |
| Полета(fields)             | ❌ Не                             | ✔ Да |
| Конструктори               | ❌ Не                             | ✔ Да |
| Access modifiers           | ❌ Не(всичко е public)            | ✔ Да |
| Имплементация на методи    | ❌ Не (в класическите интерфейси) | ✔ Да                                    |
| Abstract methods           | ✔ Да                              | ✔ Да                                    |
| Default поведение          | ❌ Не                             | ✔ Да                                    |
| Подходящо за               | Контракти, API                     | Частична логика + задължителни override |
| Може да наследи друг клас? | ❌ Не                             | ✔ Да                                    |



⭐ 4. Практическо сравнение с примери
🟦 Interface пример

Контракт, който описва какво трябва да се направи, не как.

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Writing to file: " + message);
    }
}

🟩 Abstract Class пример

Имаме базова логика, но и задължителни override-и.

abstract class Payment
{
    public void Validate() => Console.WriteLine("Validating payment...");
    public abstract void Process();
}

class CreditCardPayment : Payment
{
    public override void Process()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}

⭐ 5.Кога да използваме кое? (най-важното)
Използвай interface, когато:

Искаш чист контракт

Искаш многократно наследяване на типове

Поведението може да бъде напълно различно при имплементациите

Използвай abstract class, когато:

Искаш да дадеш частична имплементация

Искаш да използваш полета, конструктори, protected members

Искаш да имаш логика + задължителни override методи