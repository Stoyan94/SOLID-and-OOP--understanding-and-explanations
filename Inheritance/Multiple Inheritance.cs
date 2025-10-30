Multiple Inheritance / ����������� �����������

���������:

����������� ����������� ��������, �� ���� ���� ���� �� ��������� ������ �� ���� ����� ����.

�������: ���������� ����������� ����������� �� ������� ���� �� ������ �� ��������� � ���������, �������� �diamond problem�.

Diamond Problem / ��������� �������

   A
  / \
 B   C
  \ /
   D


��� ���� D ��������� � B, � C, � � ����� ���� ����� � ���� � ���� ���, D �� ���� ��� ������ �� ��������.



������� � C# / Solution in C#

���������� (Interfaces)

������ �� ���������� �������� ������� �����, ����� �� ���������� ������� ����������, ������ �� �� �������� ��������� ����������, ���� ����������.

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


���� Duck ��������� ��������� �� ������� ���������� ��� ��������.



���������� (Composition)

������ �� ���������� ������� �����, ����� �� �������� ������ �� ����� ������� ����� � ���� ���� � �� ��������� ������� ��������������.

class Engine { public void Start() => Console.WriteLine("Engine starts"); }
class Car
{
    private Engine engine = new Engine();  // ����������
    public void Start() => engine.Start();
}


�����: C# �� ��������� �������� ����������� ����������� �� �������, �� �� ������� ���������, �� ��������� �� ������ ���� ���������� ��� ����������.





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