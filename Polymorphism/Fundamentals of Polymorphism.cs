Polymorphism in C# — Explanation + Real Examples
What is polymorphism?

Polymorphism means “many forms”.
One method or behavior can have multiple implementations depending on which object executes it.

It is similar to a word that has several meanings depending on the context.
Example: the word “charge” → fee, attack, accuse, electricity.

In programming: the method MakeSound() is a “word”,
but its meaning changes depending on the animal.

Polymorphism is the third pillar of OOP (after encapsulation and inheritance),
because it allows inherited classes to define their own behavior.
This makes code flexible, extensible, and maintainable.

1. Compile-time Polymorphism (Method Overloading)

Same method name → different parameters.

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public double Add(double a, double b) => a + b;
}

2.Run - time Polymorphism(Method Overriding)

Base method → different behavior in derived classes.

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound...");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

Usage:
Animal dog = new Dog();
Animal cat = new Cat();

dog.MakeSound(); // Woof!
cat.MakeSound(); // Meow!

Real - world example(payments):
public class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("Processing payment...");
    }
}

public class CardPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with card.");
    }
}

public class PaypalPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with PayPal.");
    }
}

Payment payment = new CardPayment();
payment.Pay();   // Paid with card.

payment = new PaypalPayment();
payment.Pay();   // Paid with PayPal.








🇧🇬 Полиморфизъм в C# — Обяснение + Реални Примери
Какво е полиморфизъм?

Полиморфизмът означава „много форми“.
Един метод или поведение може да има различни реализации в зависимост от това кой обект го изпълнява.

Това е подобно на дума, която има различни значения според контекста.
Пример: думата “ключ” → може да е инструмент, част от врата, музикален ключ.

В програмирането: методът MakeSound() е „дума“ → но значението ѝ се променя според животното.

Полиморфизмът е третият стълб на ООП (след енкапсулация и наследяване),
защото позволява на наследените класове да дефинират свое собствено поведение.
Това прави кода гъвкав, разширяем и лесен за поддръжка.

1. Compile-time Polymorphism (Method Overloading)

Един метод → различни параметри.

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public double Add(double a, double b) => a + b;
}

2.Run - time Polymorphism(Method Overriding)

Базов метод → различно поведение в наследените класове.

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound...");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

Използване:
Animal dog = new Dog();
Animal cat = new Cat();

dog.MakeSound(); // Woof!
cat.MakeSound(); // Meow!

Реален пример от практика (плащания):
public class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("Processing payment...");
    }
}

public class CardPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with card.");
    }
}

public class PaypalPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with PayPal.");
    }
}

Payment payment = new CardPayment();
payment.Pay();   // Paid with card.

payment = new PaypalPayment();
payment.Pay();   // Paid with PayPal.