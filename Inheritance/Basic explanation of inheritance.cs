
������� � ������������� / Terms in Inheritance

1.Superclass / Base class / Parent class

    ���� � ������, ����� ���� ������ �������� � ������ �� ���� ����.
    
    This is the class that gives its properties and methods to another class.
    
    ���� �� ��� ���� ������ � ��������, ����� ������ �� ��������� ������ ����������.
    
    It can have common methods and properties that we want all child classes to use.


2.Subclass / Derived class / Child class

    ���� � ������, ����� �������� ��������� �� ������� ����.
    
    This is the class that receives the members from the base class.
    
    ���� �� ������ ���� ��������� �������� � ������ ��� �� ��������� ���� �� ������� ���� (override).
    
    It can add its own properties and methods or override those of the base class.


3.Inheritance(�����������)

    ���� � ���������, ���� ����� ���� ����� ����� ��������� �� ����� �����.
    
    This is the mechanism by which one class takes members from another class.



class BaseClass
{
    public string Name;

    public void Greet()
    {
        Console.WriteLine("Hello from BaseClass");
    }
}

class DerivedClass : BaseClass  // DerivedClass ��������� BaseClass
                                // DerivedClass inherits from BaseClass
{
    public void SayBye()
    {
        Console.WriteLine("Goodbye from DerivedClass");
    }
}


��������� / Explanation:

BaseClass � superclass / parent / base.

    BaseClass is the superclass / parent / base.

DerivedClass � subclass / child / derived.

    DerivedClass is the subclass / child / derived.

DerivedClass ��������� ���������� Name � ������ Greet() �� BaseClass.

    DerivedClass inherits the property Name and the method Greet() from BaseClass.

���� ���� ��� ���� �������� ����� SayBye().

It also has its own method SayBye().


������ �������� / Quick analogy:

Base class = �������, ����� ���� ����������.

Base class = parent that gives inheritance.

Derived class = ����, ����� ��������� ������, �� ���� �� ������ ���� ����.

Derived class = child that inherits everything but can add its own things.