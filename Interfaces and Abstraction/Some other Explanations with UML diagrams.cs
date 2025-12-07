Abstract Method → Override → Polymorphism (EN)

Abstract Method

Exists only as a declaration, no body.

Must be inside an abstract class.

public abstract void Build();


Override

The derived class is required to provide an implementation.

public override void Build()
{
Console.WriteLine("Building a modern house...");
}


Polymorphism

When you call the method through a base-class reference, the overridden version in the derived class is executed.

abstract class House
{
    public abstract void Build();
}

class ModernHouse : House
{
    public override void Build()
    {
        Console.WriteLine("Building a modern house...");
    }
}

House h = new ModernHouse();
h.Build(); 
// → Building a modern house...

🟦 Abstract Class vs Interface (EN)
| Feature                               | Abstract Class                     | Interface                                   |
| ------------------------------------- | ---------------------------------  | ------------------------------------------- |
| Can be instantiated?                  | ❌ No                              | ❌ No                                        |
| Can have abstract methods?            | ✔ Yes                             | ✔ Yes |
| Can contain method implementation?    | ✔ Yes (normal or virtual methods) | ✔ Yes (default interface methods)           |
| Constructors allowed ?                | ✔ Yes                             | ❌ No |
| Can contain fields?                   | ✔ Yes                             | ❌ No                                        |
| Can inherit another class?            | ✔ Yes                             | ❌ No                                        |
| Can implement interfaces?             | ✔ Yes                             | ✔ Yes                                       |
| Can a class inherit multiple of them? | ❌ No                              | ❌ No (but it can implement many interfaces)|
| Typical use                           | Shared logic + required overrides  | Pure contract, no internal logic            |
| Keywords                              | `abstract`, `virtual`, `override`  | `interface`                                 |




Abstract Method → Override → Polymorphism
        ABSTRACT CLASS
              │
              │  съдържа
              ▼
      ABSTRACT METHOD (няма тяло)
              │
              │  задължително
              ▼
        OVERRIDE в наследника
              │
              │  позволява
              ▼
         POLYMORPHISM
   (извиква се правилният метод
    според реалния тип на обекта)

Обяснение:

Abstract method → само декларация: public abstract void Build();

Override → детето задължително дава имплементация:
public override void Build() { ... }

Polymorphism → когато държиш референция към базовия клас, но реалният тип е наследник → извиква се override-натия метод.

Пример:

abstract class House
{
    public abstract void Build();
}

class ModernHouse : House
{
    public override void Build()
    {
        Console.WriteLine("Building a modern house...");
    }
}

House h = new ModernHouse();
h.Build();
// → Building a modern house...


Abstract Class vs Interface (C#)
| Характеристика                          | Abstract Class                                     | Interface |
| --------------------------------------- | -------------------------------------------------- | ----------------------------------------------- |
| Може ли да се инстанцира?               | ❌ Не                                              | ❌ Не                                            |
| Може да има abstract methods?           | ✔️ Да                                              | ✔️ Да |
| Може да има *имплементация на методи*?  | ✔️ Да (normal or virtual)                          | ✔️ Да (default interface methods)               |
| Може да има конструктор?                | ✔️ Да                                              | ❌ Не                                            |
| Поддържа ли полета (fields)?            | ✔️ Да                                              | ❌ Не (само const/readonly properties)           |
| Може ли да наследи друг клас?           | ✔️ Да                                              | ❌ Не                                            |
| Може ли да имплементира интерфейси?     | ✔️ Да                                              | ✔️ Да                                           |
| Може ли клас да наследи повече от един? | ❌ Не                                              | ❌ Не (но може да имплементира много интерфейси) |
| Типична употреба                        | Когато имаш **частична логика + абстрактни части** | Когато дефинираш **чист контракт** без логика   |
| Ключови думи                            | `abstract`, `virtual`, `override`                  | `interface`, `implements` (`:`)                 |
