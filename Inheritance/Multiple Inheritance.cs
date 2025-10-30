Multiple Inheritance / Множествено наследяване

Български:

Множествено наследяване означава, че един клас може да наследява повече от един базов клас.

Проблем: директното множествено наследяване на класове може да доведе до конфликти и объркване, наречено „diamond problem“.

Diamond Problem / Диамантен проблем

   A
  / \
 B   C
  \ /
   D


Ако клас D наследява и B, и C, а и двата имат метод с едно и също име, D не знае коя версия да използва.



Решение в C# / Solution in C#

Интерфейси (Interfaces)

Вместо да наследяваш директно няколко класа, можеш да наследяваш няколко интерфейса, защото те не съдържат конкретна реализация, само декларации.

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public void Fly() { Console.WriteLine("Duck flies"); }
    public void Swim() { Console.WriteLine("Duck swims"); }
}


Така Duck наследява поведение от няколко интерфейса без конфликт.



Композиция (Composition)

Вместо да наследяваш няколко класа, можеш да създадеш обекти на други класове вътре в твоя клас и да използваш тяхната функционалност.

class Engine { public void Start() => Console.WriteLine("Engine starts"); }
class Car
{
    private Engine engine = new Engine();  // композиция
    public void Start() => engine.Start();
}


Извод: C# не позволява директно множествено наследяване на класове, за да избегне конфликти, но проблемът се решава чрез интерфейси или композиция.





English:

Multiple inheritance means a class can inherit from more than one base class.

Problem: Direct multiple inheritance of classes can cause conflicts and ambiguity, known as the diamond problem.

Diamond Problem
   A
  / \
 B   C
  \ /
   D


If D inherits from both B and C, and both have a method with the same name, D does not know which version to use.



Solution in C#

Interfaces

Instead of inheriting multiple classes, you can inherit multiple interfaces, because they do not contain implementation, only declarations.

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public void Fly() { Console.WriteLine("Duck flies"); }
    public void Swim() { Console.WriteLine("Duck swims"); }
}


Duck inherits behavior from multiple interfaces without conflict.



Composition

Instead of inheriting multiple classes, a class can contain objects of other classes and use their functionality.

class Engine { public void Start() => Console.WriteLine("Engine starts"); }
class Car
{
    private Engine engine = new Engine();  // composition
    public void Start() => engine.Start();
}


Takeaway: C# does not allow direct multiple inheritance of classes to avoid conflicts, but the problem is solved via interfaces or composition.