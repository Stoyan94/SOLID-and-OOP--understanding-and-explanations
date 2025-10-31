Какво е виртуален метод (virtual)?

Когато един метод е маркиран като virtual в базов клас, това означава:

„Този метод може да бъде променен (презаписан) от наследяващ клас.“

Тоест базовият клас дефинира поведение по подразбиране, а наследниците могат да го променят, ако имат нужда.

Пример 1: Без virtual
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

Animal a = new Dog();
a.Eat(); // 👉 Резултат: Animal is eating ❗


🧠 Защо?

Без virtual компилаторът избира метода според типа на променливата (Animal), не според реалния обект (Dog).

Пример 2: С virtual и override
public class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

Animal a = new Dog();
a.Eat(); // 👉 Резултат: Dog is eating ✅


💡 Сега Eat() е виртуален → когато извикаш a.Eat(), програмата вижда, че реалният обект е Dog и извиква неговата версия.

Това се нарича полиморфизъм (poly = много, morph = форма) — един и същи метод има различно поведение според обекта.


🧱 Как работи вътрешно (супер просто)

Когато даден метод е virtual, C# зад кулисите използва виртуална таблица (vtable) — нещо като списък от методи, които могат да бъдат презаписани.

Клас Animal има Eat().

Клас Dog има своя версия на Eat() — при създаване на Dog, в таблицата му се записва, че при извикване на Eat() трябва да се използва неговата имплементация.



🧠 Може ли override метод да приема различни параметри?

❌ Не, не може да се променят параметрите или типа на връщане (освен в някои редки случаи с ковариантност при интерфейси).

Пример за некоректно override:

public class Animal
{
    public virtual void Speak(string sound) { }
}

public class Dog : Animal
{
    public override void Speak(int sound) { } // ❌ Грешка! Различен тип параметър
}


🟢 Ако искаш методи със същото име, но различни параметри — това се нарича method overloading (претоварване), не override.

✅ Правилен пример:
public class Animal
{
    public virtual void Speak(string sound)
    {
        Console.WriteLine("Animal says: " + sound);
    }
}

public class Dog : Animal
{
    public override void Speak(string sound)
    {
        Console.WriteLine("Dog barks: " + sound);
    }
}




🏡 Virtual Properties

virtual може да се използва и при properties (свойства):

public class Animal
{
    public virtual string Sound { get; set; } = "Some sound";
}

public class Dog : Animal
{
    public override string Sound { get; set; } = "Bark";
}

Animal animal = new Dog();
Console.WriteLine(animal.Sound); // 👉 Bark ✅


Тоест принципът е същият – свойството може да бъде презаписано от наследник.

🧭 Диаграма (схематично):
Animal
│
├── virtual Eat()
│
└── Dog : Animal
     └── override Eat()


Извикваш Eat():

Ако обектът е Animal → ползва оригиналния Eat()

Ако обектът е Dog → ползва презаписания Eat()

💡 Кратко обобщение:
Ключова дума	Къде се използва	Какво прави
virtual	        В базов клас	    Позволява метод/свойство да бъде презаписано
override	    В наследен клас	    Реално презаписва базовия метод
new             В наследен клас     Скрива базовия метод, без да го override-ва






🧩 What Is a Virtual Method (virtual)?

When a method is marked as virtual in a base class, it means:

“This method can be changed (overridden) by a derived class.”

In other words, the base class defines default behavior, and the subclasses can modify it if needed.

Example 1: Without virtual
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

Animal a = new Dog();
a.Eat(); // 👉 Result: Animal is eating ❗


🧠 Why?

Without virtual, the compiler chooses the method based on the variable type (Animal), not on the actual object type (Dog).

Example 2: With virtual and override
public class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

Animal a = new Dog();
a.Eat(); // 👉 Result: Dog is eating ✅


💡 Now Eat() is virtual → when you call a.Eat(), the program checks that the real object is Dog and calls its version.

This is called polymorphism (poly = many, morph = form) — the same method behaves differently depending on the object.


🧱 How It Works Internally (simple explanation)

When a method is declared as virtual, C# internally uses a virtual table (vtable) — think of it as a list of methods that can be overridden.

Class Animal has Eat().

Class Dog has its own version of Eat().
When a Dog is created, the vtable records that calling Eat() should use the Dog implementation.



🧠 Can an Overridden Method Have Different Parameters?

❌ No. You cannot change the parameters or return type (except in very rare cases with covariance for interfaces).

Incorrect override example:
public class Animal
{
    public virtual void Speak(string sound) { }
}

public class Dog : Animal
{
    public override void Speak(int sound) { } // ❌ Error! Different parameter type
}


🟢 If you want methods with the same name but different parameters — that’s called method overloading, not overriding.

✅ Correct Example:
public class Animal
{
    public virtual void Speak(string sound)
    {
        Console.WriteLine("Animal says: " + sound);
    }
}

public class Dog : Animal
{
    public override void Speak(string sound)
    {
        Console.WriteLine("Dog barks: " + sound);
    }
}

🏡 Virtual Properties

virtual can also be used on properties:

public class Animal
{
    public virtual string Sound { get; set; } = "Some sound";
}

public class Dog : Animal
{
    public override string Sound { get; set; } = "Bark";
}

Animal animal = new Dog();
Console.WriteLine(animal.Sound); // 👉 Bark ✅


So the principle is the same – a property can be overridden by a derived class.

🧭 Diagram(schematic):
Animal
│
├── virtual Eat()
│
└── Dog : Animal
     └── override Eat()


When you call Eat():

If the object is Animal → uses the original Eat()

If the object is Dog → uses the overridden Eat()

💡 Quick Summary
Keyword	   Where it’s used	    What it does
virtual	   In a base class      Allows a method/property to be overridden
override   In a derived class   Actually overrides the base method
new        In a derived class   Hides the base method without overriding it