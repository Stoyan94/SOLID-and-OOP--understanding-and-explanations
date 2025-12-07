Abstract Methods in C#: Full Explanation


1️⃣ What is an Abstract Method?

An abstract method is a method that:

Has no implementation(no body)

Must be overridden in a non-abstract derived class

Can exist only inside an abstract class

Example :

public abstract class Builder
{
    public abstract void Build();
}


This defines a method contract:

"Every class that derives from Builder MUST implement Build()".



2️⃣ Abstract Methods Are Implicitly Virtual

This means:

They are automatically treated as virtual

So they support polymorphism

But you cannot write virtual and abstract together(it’s redundant)

So the following is invalid:

public abstract virtual void Build(); // ❌ Not allowed


Just:

public abstract void Build(); // ✔



3️⃣ Syntax of Overriding an Abstract Method

A non-abstract child class must override the abstract method using override:

public abstract class Builder
{
    public abstract void Build();
}

public class HouseBuilder : Builder
{
    public override void Build()
    {
        Console.WriteLine("Building a house...");
    }
}



4️⃣ Why Do We Override Abstract Methods?

Because:

An abstract method cannot run by itself

The base class defines WHAT must be done

The derived class defines HOW it’s done

This creates polymorphic behavior.

Example:

Builder b = new HouseBuilder();
b.Build(); // Calls HouseBuilder.Build()



5️⃣ When Do We NEED to Override?

You MUST override if:

The parent class is abstract

AND contains an abstract method

Otherwise, the child class must also be declared abstract:

public abstract class WoodenBuilder : Builder
{
    // Allowed because this class is abstract
    // No override needed yet
}



6️⃣ When You Do NOT Need to Override

If:

The method is not abstract (has implementation)

The derived class doesn’t need different behavior

Example:

public abstract class Builder
{
    public void Print() => Console.WriteLine("I am a builder");
}


Print() does not need override.



7️⃣ Full Realistic Example
Abstract Base Class
public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Honk()
    {
        Console.WriteLine("Beep!");
    }
}

Derived Classes
public class Car : Vehicle
{
    public override void StartEngine() =>
        Console.WriteLine("Car engine started.");

    public override void StopEngine() =>
        Console.WriteLine("Car engine stopped.");
}

public class Motorcycle : Vehicle
{
    public override void StartEngine() =>
        Console.WriteLine("Motorcycle engine started.");

    public override void StopEngine() =>
        Console.WriteLine("Motorcycle engine stopped.");
}

Usage
Vehicle v = new Car();
v.StartEngine(); // Car engine started.
v.Honk();        // Beep!




🇧🇬 Абстрактни методи в C#: Пълно обяснение


1️⃣ Какво е абстрактен метод?

Абстрактният метод:

Няма тяло(няма реализация)

Трябва задължително да бъде override-нат в наследник

Може да съществува само в абстрактен клас

Пример:

public abstract class Builder
{
    public abstract void Build();
}


Това означава:
„Всеки клас, който наследи Builder, е длъжен да имплементира Build().“



2️⃣ Абстрактният метод е implicit virtual

Това значи:

Той автоматично е виртуален

Няма нужда (и не трябва) да пишеш virtual

Грешно:

public abstract virtual void Build(); // ❌


Правилно:

public abstract void Build(); // ✔



3️⃣ Override синтаксис(задължителен)

Конкретният клас трябва да override-не абстрактния метод:

public abstract class Builder
{
    public abstract void Build();
}

public class HouseBuilder : Builder
{
    public override void Build()
    {
        Console.WriteLine("Строя къща...");
    }
}


4️⃣ Защо се override-ва абстрактен метод?

Защото:

Базовият клас казва какво трябва да има

Наследникът определя как се прави

Това реализира полиморфизъм.

Builder b = new HouseBuilder();
b.Build(); // Извиква HouseBuilder.Build()

5️⃣ Кога сме ЗАДЪЛЖЕНИ да override-нем?

Когато:

Наследяваме абстрактен клас

И той има абстрактни методи

Иначе → грешка.



6️⃣ Кога НЕ е нужно да override-ваш?

Когато:

Методът в базовия клас НЕ е абстрактен
(има тяло)

Тогава override е по избор:

public abstract class Builder
{
    public void Print() => Console.WriteLine("Аз съм строител");
}



7️⃣ Пълен реалистичен пример
Абстрактен базов клас
public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Honk()
    {
        Console.WriteLine("Бип!");
    }
}

Наследници
public class Car : Vehicle
{
    public override void StartEngine() =>
        Console.WriteLine("Кола: двигателят е стартиран.");

    public override void StopEngine() =>
        Console.WriteLine("Кола: двигателят е спрян.");
}

public class Motorcycle : Vehicle
{
    public override void StartEngine() =>
        Console.WriteLine("Мотор: двигателят е стартиран.");

    public override void StopEngine() =>
        Console.WriteLine("Мотор: двигателят е спрян.");
}

Използване
Vehicle v = new Car();
v.StartEngine();
v.Honk();