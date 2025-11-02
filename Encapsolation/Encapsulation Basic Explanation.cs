🔹 Какво е инкапсулация

Инкапсулацията е един от основните принципи на обектно-ориентираното програмиране (ООП).
Тя представлява съчетаването на данните (полета) и поведението (методи) в една цялостна структура — клас, като вътрешната реализация се скрива от външния свят.

Целта е да се защити вътрешното състояние на обекта, така че външният код да не може директно да променя или достъпва чувствителни данни. 

Вместо това, достъпът се извършва чрез контролирани интерфейси — публични свойства или методи, които решават кога и как информацията може да бъде прочетена или променена.

Инкапсулацията:

Намалява сложността – външният потребител не се интересува как е реализиран даден клас, а само как да го използва.

Увеличава гъвкавостта – можеш да променяш вътрешната логика, без да засягаш останалия код.

Осигурява защита – предпазва данните от неправилни или опасни промени.

Позволява валидация и контрол – например можеш да проверяваш стойности преди те да бъдат записани в обекта.

Пример: ако имаш клас „Банкова сметка“, не искаш някой директно да променя баланса. 
    Вместо това, достъпът трябва да става чрез методи като „депозирай“ или „тегли“, които проверяват дали операцията е валидна.

Така запазваш цялостта и сигурността на данните, без да ограничиш функционалността.

📘 Пример:

public class Person
{
    private string name; // частно поле
    private int age;     // частно поле

    public Person(string name, int age) // конструктор
    {
        Name = name; // задаваме чрез property, не директно
        Age = age;
    }

    public string Name   // property
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty!");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative!");
            age = value;
        }
    }
}

🔹 Какво се случва тук

name и age са частни полета — никой отвън не може да ги промени директно.

Name и Age са публични свойства — през тях контролираме достъпа.

Конструкторът получава параметри със същите имена (name, age), но те са локални променливи, които съществуват само в рамките на конструктора.

Когато пишеш Name = name;,

лявата страна(Name) е property на класа;

дясната(name) е параметър на конструктора.

➡️ Те не са едно и също нещо.
Полето name и параметърът name имат различен обхват (scope).
Property-то използва вътрешното поле name чрез get и set.


🧠 Защо не е едно и също:
В конструктора имаш три нива на достъп:

Параметрите(string name, int age) – живеят само в конструктора.

Свойствата (Name, Age) – достъпни отвън (публични).

Полетата (private string name;) – достъпни само вътре в класа.

Така се осигурява инкапсулация — контролиран достъп и възможност за валидация, data binding и гъвкавост при промени.


Това ти дава:
Защита на данните – никой не може да променя полетата директно.

Контрол върху валидирането – чрез set можеш да проверяваш стойности преди запис.

По-лесна поддръжка и гъвкавост на кода – можеш да променяш вътрешната логика, без да нарушаваш външния интерфейс.






🇬🇧 Explanation in English
🔹 What is Encapsulation

Encapsulation is one of the core principles of Object-Oriented Programming (OOP).
It means bundling data (fields) and behavior (methods) into a single unit — a class, while hiding the internal implementation details from the outside world.

The main goal is to protect the internal state of an object, so that external code cannot directly access or modify sensitive data.
Instead, access is provided through controlled interfaces — public properties or methods that decide when and how information can be read or changed.

Encapsulation:

Reduces complexity – the user of a class doesn’t need to know how it works internally, only how to use it.

Increases flexibility – internal implementation can be changed without affecting other parts of the program.

Provides protection – prevents data from being altered in an unsafe or invalid way.

Enables validation and control – you can verify or filter data before assigning it to internal fields.

For example, if you have a “Bank Account” class, you don’t want anyone to directly change the balance. Instead, access should go through methods like “Deposit” or “Withdraw,” which perform checks before updating the balance.
This ensures data integrity, consistency, and security, while still keeping the code easy to work with.

📘 Example:

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        Name = name; // using property, not direct field
        Age = age;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty!");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative!");
            age = value;
        }
    }
}

🔹 What happens here

name and age are private fields — hidden from outside.

Name and Age are public properties — control access to fields.

The constructor parameters (string name, int age) are local variables, existing only inside the constructor.

When you write Name = name;:

the left side (Name) refers to the property,

the right side (name) refers to the constructor parameter.

➡️ They are not the same thing — same word, different scope.
The property internally uses the private field (name) via its set accessor.

🎯 This gives you:

Data protection

Validation control

Easier code maintenance and flexibility