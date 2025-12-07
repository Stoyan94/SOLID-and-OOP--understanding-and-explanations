Understanding “Implicitly Virtual”

When we say:

“An abstract method is implicitly virtual”

It means:

✔ 1) You don’t write virtual

Because abstract methods automatically behave like virtual methods.

✔ 2) They MUST be overridden

Because they have no body.

✔ 3) They participate in polymorphism

So when you call the method through a base reference, the override in the child is executed.

✅ Example with Explanation
Base class:
public abstract class Animal
{
    public abstract void MakeSound(); // implicitly virtual
}


Explanation:

This method has no body

It is automatically virtual

It MUST be overridden in a subclass

It supports polymorphism

Derived class:
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

Usage:
Animal a = new Dog();
a.MakeSound();

What happens?

Step-by-step:

The reference is Animal (base class)

The object is actually Dog

Because the abstract method is implicitly virtual,
→ the Dog version is called.

This is polymorphism:
“The method that runs depends on the actual object, not the variable type.”



🇧🇬 Обяснение на “implicit virtual” 

Когато казваме:

„Абстрактният метод е implicit virtual“

значи следното:

✔ 1) Не пишеш virtual

Не трябва да пишеш virtual, защото абстрактните методи по подразбиране са виртуални.

✔ 2) Те ЗАДЪЛЖИТЕЛНО се override-ват

Понеже нямат тяло и компилаторът те задължава.

✔ 3) Работят с полиморфизъм

Тоест ако извикаш метода през базовия клас, ще се изпълни override-а от наследника.

✅ Пример с подробно обяснение
Базов клас:

public abstract class Animal
{
    public abstract void MakeSound(); // implicit virtual
}


Обяснение:

Няма тяло → абстрактен

Следователно е виртуален

Задължително се override-ва

Позволява полиморфично поведение

Наследник:

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Бау!");
    }
}

Извикване:

Animal a = new Dog();
a.MakeSound();

Какво реално става?

Променливата е Animal

Обектът е Dog

Понеже абстрактният метод е implicit virtual,
→ изпълнява се версията от Dog.

Това е полиморфизъм:
„Кой метод ще се изпълни зависи от реалния обект, не от типа на променливата.“