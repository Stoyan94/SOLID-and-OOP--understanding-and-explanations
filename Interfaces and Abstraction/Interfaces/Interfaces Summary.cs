1) What is an Interface ?

An interface is a pure contract that describes what behavior a class must have — without specifying exactly how that behavior is implemented.

It contains only:

Methods(without a body, unless it’s a default implementation)

Properties(without fields)

Events

Indexers

That is, an interface defines what an object can do, not what it is.
This makes it perfect for writing flexible, modular, and easily extendable code.


🟦 2) Interfaces are fully abstract by nature

Before C# 8.0, interfaces could only contain abstract members.
That’s why the compiler silently adds:

public abstract void Print();


even if you just write:

void Print();


So:
🔹 Methods are public and abstract
🔹 Cannot have fields
🔹 Cannot have constructors
🔹 Cannot have access modifiers (everything is public)



🟦 3) From C# 8.0, interfaces can have default implementations

Example:

public interface IUser
{
    void Save();

    // new – method with implementation
    void Print()
    {
        Console.WriteLine("Default print for user.");
    }
}


A class implementing the interface does not need to override this method — unless it wants different behavior.

This allows you to add new methods to interfaces without breaking existing code.



🟦 4) Implementing an interface

A class must implement all abstract members:

public interface IPrintable
{
    void Print();
}

public class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Hello");
    }
}


If the class does not implement all members → compiler error.



🟦 5) A class can implement multiple interfaces

This is how C# supports multiple inheritance without the complexities of C++:

class Robot : IMovable, IRotatable, IPrintable
{
}



🟦 6) Interfaces can inherit other interfaces

public interface IA
{
    void A();
}

public interface IB
{
    void B();
}

public interface IC : IA, IB
{
    void C();
}


A class implementing IC must have A(), B(), and C().



🟦 7) Order of inheritance for classes and interfaces

When a class inherits a base class +interfaces, the order is:

class Car : Vehicle, IMovable, IPrintable
{
}


The base class always comes first.



🟦 8) Explicit Interface Implementation

This is a powerful technique when two interfaces have methods with the same name.
It allows you to “hide” the implementation from the class itself and access it only through the interface.

Example:

public interface IWriter
{
    void Write();
}

public interface ILogger
{
    void Write();
}

public class FileLog : ILogger, IWriter
{
    void ILogger.Write()
    {
        Console.WriteLine("Log write");
    }

    void IWriter.Write()
    {
        Console.WriteLine("File write");
    }
}


Usage:

FileLog f = new FileLog();
// f.Write(); ❌ Not accessible

((ILogger)f).Write(); ✔
((IWriter)f).Write(); ✔




🟦 9) Interface vs Abstract Class

Feature	Interface	Abstract class
Can have implementation?	Yes (from C# 8 – default)	Yes
Can have fields?	❌ No	✔ Yes
Constructors?	❌ No	✔ Yes
Multiple inheritance?	✔ Yes (many interfaces)	❌ No
Access modifiers	All public Yes

Interface = behavior
Abstract class = behavior + shared structure



🟦 10) Typical real-world examples

✔ Sorting (IComparable)

class Player : IComparable<Player>
{
    public int Score { get; set; }

    public int CompareTo(Player other)
        => Score.CompareTo(other.Score);
}


✔ Working with streams (IDisposable)

using (var file = new FileStream("a.txt", FileMode.Open))
{
    // IDisposable closes the file automatically
}


✔ Collections(IEnumerable)

foreach (var item in myList) { }








BG



1) Какво представлява интерфейсът?

Интерфейсът е чист договор, който описва какво поведение трябва да има един клас — без да казва как точно се реализира това поведение.

Той съдържа само:

методи(без тяло, освен ако не е default implementation)

свойства(без поле)

събития

indexer-и

Т.е. интерфейсът дефинира какво може да прави обектът, а не кой е.
Това го прави перфектен за писане на гъвкав, модулен, лесно разширяем код.



🟦 2) Интерфейсът е напълно абстрактен по природа

Преди C# 8.0 — интерфейсите съдържаха само abstract членове.
Затова компилаторът тихо добавя:

public abstract void Print();


дори ако ти напишеш само:

void Print();


Тоест:
🔹 Методите са public, abstract
🔹 Не могат да имат полета
🔹 Не могат да имат конструктори
🔹 Не могат да имат модификатори на достъп (всичко е public)



🟦 3) От C# 8.0 интерфейсите могат да имат default implementation

Пример:

public interface IUser
{
    void Save();

    // ново – метод с реализация
    void Print()
    {
        Console.WriteLine("Default print for user.");
    }
}


Класът, който имплементира интерфейса, не е длъжен да override-ва този метод—освен ако иска различно поведение.

Това позволява да добавяш нови методи към интерфейси, без да чупиш стария код.



🟦 4) Имплементиране на интерфейс

Класът трябва да имплементира всички абстрактни членове:

public interface IPrintable
{
    void Print();
}

public class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Hello");
    }
}



Ако класът не имплементира всички членове → компилаторна грешка.

🟦 5) Един клас може да имплементира много интерфейси

Това е начинът C# да поддържа множество наследяване, без сложностите на C++:

class Robot : IMovable, IRotatable, IPrintable
{
}



🟦 6) Интерфейсите могат да наследяват други интерфейси
public interface IA
{
    void A();
}

public interface IB
{
    void B();
}

public interface IC : IA, IB
{
    void C();
}



Класът, който имплементира IC, трябва да има A(), B() и C().

🟦 7) Ред на наследяване при класове и интерфейси

Когато класът наследява базов клас + интерфейси, редът е:

class Car : Vehicle, IMovable, IPrintable
{
}


Базовият клас е винаги първи.



🟦 8) Explicit Interface Implementation

Това е мощна техника, когато два интерфейса имат методи с еднакво име.
Позволява да “скриеш” имплементацията от самия клас и да я достъпваш само през интерфейса.

Пример:

public interface IWriter
{
    void Write();
}

public interface ILogger
{
    void Write();
}

public class FileLog : ILogger, IWriter
{
    void ILogger.Write()
    {
        Console.WriteLine("Log write");
    }

    void IWriter.Write()
    {
        Console.WriteLine("File write");
    }
}


Използване:

FileLog f = new FileLog();
// f.Write(); ❌ Няма достъп

((ILogger)f).Write(); ✔
((IWriter)f).Write(); ✔



🟦 9) Интерфейс vs Абстрактен клас
Характеристика	Interface	Abstract class
Може да има имплементация?	Да (от C# 8 – default)	Да
Може да има полета?	❌ Не	✔ Да
Конструктори?	❌ Не	✔ Да
Множество наследяване?	✔ Да (много интерфейси)	❌ Не
Модификатори на достъп	Всичко е public Има

Интерфейс = поведение
Абстрактен клас = поведение + обща структура



🟦 10) Типични реални примери
✔ Сортиране (IComparable)
class Player : IComparable<Player>
{
    public int Score { get; set; }

    public int CompareTo(Player other)
        => Score.CompareTo(other.Score);
}

✔ Работа с потоци (IDisposable)
using (var file = new FileStream("a.txt", FileMode.Open))
{
    // IDisposable затваря файла автоматично
}

✔ Колекции(IEnumerable)
foreach (var item in myList) { }