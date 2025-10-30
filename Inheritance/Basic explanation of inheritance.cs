
Термини в наследяването / Terms in Inheritance

1.Superclass / Base class / Parent class

    Това е класът, който дава своите свойства и методи на друг клас.
    
    This is the class that gives its properties and methods to another class.
    
    Може да има общи методи и свойства, които искаме да използват всички наследници.
    
    It can have common methods and properties that we want all child classes to use.


2.Subclass / Derived class / Child class

    Това е класът, който получава членовете на базовия клас.
    
    This is the class that receives the members from the base class.
    
    Може да добавя свои собствени свойства и методи или да презапише тези на базовия клас (override).
    
    It can add its own properties and methods or override those of the base class.


3.Inheritance(наследяване)

    Това е механизма, чрез който една класа взима членовете на друга класа.
    
    This is the mechanism by which one class takes members from another class.



class BaseClass
{
    public string Name;

    public void Greet()
    {
        Console.WriteLine("Hello from BaseClass");
    }
}

class DerivedClass : BaseClass  // DerivedClass наследява BaseClass
                                // DerivedClass inherits from BaseClass
{
    public void SayBye()
    {
        Console.WriteLine("Goodbye from DerivedClass");
    }
}


Обяснение / Explanation:

BaseClass е superclass / parent / base.

    BaseClass is the superclass / parent / base.

DerivedClass е subclass / child / derived.

    DerivedClass is the subclass / child / derived.

DerivedClass наследява свойството Name и метода Greet() от BaseClass.

    DerivedClass inherits the property Name and the method Greet() from BaseClass.

Също така има свой собствен метод SayBye().

It also has its own method SayBye().


Кратка аналогия / Quick analogy:

Base class = родител, който дава наследство.

Base class = parent that gives inheritance.

Derived class = дете, което наследява всичко, но може да добави свои неща.

Derived class = child that inherits everything but can add its own things.