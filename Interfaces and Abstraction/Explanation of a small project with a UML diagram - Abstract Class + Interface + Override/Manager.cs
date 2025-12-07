UML Diagram – Abstract Class + Interface + Override (C#)
🔹 UML Diagram (Text Version)
          ┌──────────────────────────┐
          │       IWorker            │  ← Interface
          │──────────────────────────│
          │ + Work() : void          │
          └──────────────────────────┘
                     ▲
                     │ implements
                     │
          ┌──────────────────────────┐
          │    IReportable           │  ← Interface
          │──────────────────────────│
          │ + Report() : void        │
          └──────────────────────────┘
                     ▲
                     │ implements
                     │
          ┌────────────────────────────────────────────┐
          │            abstract class Employee          │  ← Abstract Class
          │────────────────────────────────────────────│
          │ - Name : string                             │
          │────────────────────────────────────────────│
          │ + Employee(name : string)                   │  ← Constructor
          │ + DisplayName() : void                      │  ← Normal Method
          │ # CalculateSalary() : double (abstract)     │  ← Abstract Method
          └────────────────────────────────────────────┘
                     ▲
                     │ inherits
                     │
       ┌──────────────────────────────────────────────┐
       │                 class Manager                 │  ← Concrete Class
       │──────────────────────────────────────────────│
       │ + Manager(name : string)                      │
       │──────────────────────────────────────────────│
       │ + CalculateSalary() : double (override)       │
       │ + Work() : void (from IWorker)                │
       │ + Report() : void (from IReportable)          │
       └──────────────────────────────────────────────┘

🟦 C# Code (Exactly from the UML Diagram)

public interface IWorker
{
    void Work();
}

public interface IReportable
{
    void Report();
}

public abstract class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public void DisplayName()
    {
        Console.WriteLine($"Employee: {Name}");
    }

    // Abstract method → MUST be overridden
    public abstract double CalculateSalary();
}

public class Manager : Employee, IWorker, IReportable
{
    public Manager(string name) 
        : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 5000.00;
    }

    public void Work()
    {
        Console.WriteLine("Manager is working...");
    }

    public void Report()
    {
        Console.WriteLine("Manager is creating a report...");
    }
}

🟦 English Explanation

Interfaces (IWorker, IReportable) define what a class must do: Work() and Report().
Any class implementing these interfaces must provide concrete implementations.

Abstract class Employee provides:

common data (Name field)

common methods (DisplayName())

an abstract method (CalculateSalary()) that must be overridden in derived concrete classes


Manager class:

inherits from Employee

implements IWorker and IReportable

overrides CalculateSalary()

provides concrete implementations for Work() and Report()


This is a classic example of:

Multiple interface implementation

Inheritance

Method overriding

Polymorphism


🟦 Example Usage
Employee emp = new Manager("Alice");
emp.DisplayName();       // Employee: Alice
Console.WriteLine(emp.CalculateSalary()); // 5000.00

IWorker worker = (IWorker)emp;
worker.Work();           // Manager is working...

IReportable reporter = (IReportable)emp;
reporter.Report();       // Manager is creating a report...


✅ This shows polymorphism: the same object can be treated as Employee, IWorker, or IReportable and behaves correctly.







BG

UML Диаграма – Abstract Class + Interface + Override (C#)
🔹 UML Диаграма (Текстова)
          ┌──────────────────────────┐
          │       IWorker            │  ← Interface
          │──────────────────────────│
          │ + Work() : void          │
          └──────────────────────────┘
                     ▲
                     │ implements
                     │
          ┌──────────────────────────┐
          │    IReportable           │  ← Interface
          │──────────────────────────│
          │ + Report() : void        │
          └──────────────────────────┘
                     ▲
                     │ implements
                     │
          ┌────────────────────────────────────────────┐
          │            abstract class Employee          │  ← Abstract Class
          │────────────────────────────────────────────│
          │ - Name : string                             │
          │────────────────────────────────────────────│
          │ + Employee(name : string)                   │  ← Constructor
          │ + DisplayName() : void                      │  ← Normal Method
          │ # CalculateSalary() : double (abstract)     │  ← Abstract Method
          └────────────────────────────────────────────┘
                     ▲
                     │ inherits
                     │
       ┌──────────────────────────────────────────────┐
       │                 class Manager                 │  ← Concrete Class
       │──────────────────────────────────────────────│
       │ + Manager(name : string)                      │
       │──────────────────────────────────────────────│
       │ + CalculateSalary() : double (override)       │
       │ + Work() : void (from IWorker)                │
       │ + Report() : void (from IReportable)          │
       └──────────────────────────────────────────────┘


🟦 C# Code (точно от UML диаграмата)

🎯 Напълно реален пример за интервю / изпит — прецизен и чист.
public interface IWorker
{
    void Work();
}

public interface IReportable
{
    void Report();
}

public abstract class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public void DisplayName()
    {
        Console.WriteLine($"Employee: {Name}");
    }

    // Abstract method → MUST be overridden
    public abstract double CalculateSalary();
}

public class Manager : Employee, IWorker, IReportable
{
    public Manager(string name) 
        : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 5000.00;
    }

    public void Work()
    {
        Console.WriteLine("Manager is working...");
    }

    public void Report()
    {
        Console.WriteLine("Manager is creating a report...");
    }
}


🟦 Българско обяснение

Интерфейсите (IWorker, IReportable) казват какво трябва да прави класа → Work(), Report()

Абстрактният клас (Employee) дава:

общи данни (Name поле)

общи методи (DisplayName)

абстрактен метод, който Manager е длъжен да override-не → CalculateSalary()



Manager:

наследява → Employee

имплементира → IWorker и IReportable

override-ва → CalculateSalary()

Това е класически пример за множество имплементации + наследяване + override + полиморфизъм.


Пример за използване
Employee emp = new Manager("Alice");
emp.DisplayName();       // Employee: Alice
Console.WriteLine(emp.CalculateSalary()); // 5000.00

IWorker worker = (IWorker)emp;
worker.Work();           // Мениджърът работи...

IReportable reporter = (IReportable)emp;
reporter.Report();       // Мениджърът създава отчет...


✅ Това показва полиморфизъм: един и същ обект може да се третира като Employee, IWorker или IReportable и да се държи правилно.