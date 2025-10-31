🧩 1.Какво е "Reusing Classes" и "Reusing Code at Class Level"


Когато използваме наследяване, ние реизползваме кода на базовия клас, вместо да го пишем наново.

Това позволява по-лесна поддръжка, по-малко дублиране и по-добра структура.


🧩 2. Inheritance и Access Modifiers (модификатори на достъп)
Modifier	Достъпно от	Обяснение
public навсякъде видимо от всички класове
protected в наследниците  достъпно само за наследяващите класове
internal в същата assembly(проект)  достъпно само в рамките на същия проект
private само в същия клас	не е достъпно в наследниците


🧩 3. „Private fields are inherited, but not visible“

Това означава:
Когато един клас наследи базов, private полета се наследяват вътрешно,
но не можеш да ги достъпиш директно в наследника.

📘 Пример:

class Person
{
    private int age = 30;
}

class Patient : Person
{
    public void Print()
    {
        // Console.WriteLine(age); ❌ Грешка — private полето не е достъпно
    }
}

🧩 4.Shadowing(засенчване / скриване на променлива)

Shadowing(или Hiding) става, когато в наследника декларираш променлива със същото име като в базовия клас.
Така тя „скрива“ (hide) оригиналната променлива от базовия клас.

Пример:
class Person
{
    protected int weight;  // базов член
}

class Patient : Person
{
    protected float weight;   // скрива int weight от базовия клас

    public void Method()
    {
        double weight = 0.5d;  // локална променлива, която скрива float weight

        this.weight = 0.6f;    // достъп до float weight от Patient
        base.weight = 1;       // достъп до int weight от Person
    }
}

🔍 Ред по ред анализ:

double weight = 0.5d;
👉 Локална променлива в метода — засенчва weight от класа Patient.

this.weight = 0.6f;
👉 Достъпваме weight от текущия клас (Patient) — тип float.

base.weight = 1;
👉 Достъпваме weight от базовия клас (Person) — тип int.



🧠 Защо това е важно:

Ако не внимаваш, лесно можеш да засенчиш променливи и да направиш кода объркващ.

Обикновено е по-добре да избягваш shadowing, освен ако нямаш конкретна причина (например в legacy код).

💡 Резюме / Summary Table

| Ключова дума | Какво достъпва                 | Обяснение                                         |
| :----------- | :----------------------------- | :------------------------------------------------ |
| `this`       | член от текущия(derived) клас  | достъпва полета / методи на наследника            |
| `base`       | член от базовия (parent) клас  | достъпва оригиналната версия на полето или метода |






🇬🇧 English Explanation

🧩 1. Reusing Classes / Code

Through inheritance, we can reuse existing class logic without rewriting it.

This makes maintenance easier and code cleaner.


🧩 2. Inheritance and Access Modifiers
Modifier	Accessible from	Meaning
public anywhere visible from all classes
protected derived classes accessible to subclasses
internal same assembly   visible only within the same project
private same class not visible to subclasses


🧩 3. Private fields are inherited but not visible

Even though private members exist in the object (they are inherited internally),
you cannot directly access them from the derived class.

class Person
{
    private int age = 30;
}

class Patient : Person
{
    public void Print()
    {
        // Console.WriteLine(age); ❌ Error — private field not accessible
    }
}

🧩 4.Shadowing Variables

Shadowing(or hiding) happens when a derived class declares a field with the same name as one in its base class.
It “hides” the base version of the variable.

Example:
class Person
{
    protected int weight;
}

class Patient : Person
{
    protected float weight;   // hides the int weight from Person

    public void Method()
    {
        double weight = 0.5d;  // hides float weight from Patient
        this.weight = 0.6f;    // accesses float weight (Patient)
        base.weight = 1;       // accesses int weight (Person)
    }
}

🧠 Why this matters

Variable shadowing can cause confusion and bugs if you’re not careful.

It’s best to avoid reusing variable names unless you have a good reason.

Always use this and base to make your code clear about which variable or method you mean.


| Keyword | What it accesses                      | Explanation                                          |
| :------ | :------------------------------------ | :--------------------------------------------------- |
| `this`  | Member of the current (derived) class | Accesses fields / methods defined in the subclass    |
| `base`  | Member of the base (parent) class     | Accesses the original version of the field or method |


