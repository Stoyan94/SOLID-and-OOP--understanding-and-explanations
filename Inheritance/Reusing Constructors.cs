Обяснение на български

🔹 Какво означава „конструкторите не се наследяват“

Когато един клас наследява друг (class Student : Person), методите и свойствата се наследяват,
но конструкторите – не.
Тоест, Student няма директен достъп до конструкторите на Person.

🔹 Как тогава се „реизползват“?

Макар че не се наследяват, можеш да ги извикаш ръчно от конструктора на наследника,
чрез ключовата дума base.

🔹 Пример:
class Person
{
    public string Name { get; }

    public Person(string name)   // базов конструктор
    {
        Name = name;
    }
}

class Student : Person
{
    private School school;

    // конструктор на наследника
    public Student(string name, School school)
        : base(name)   // извиква конструктора на базовия клас Person
    {
        this.school = school;   // инициализация на собственото поле
    }
}

🔹 Какво става тук ред по ред:

Класът Person има конструктор, който приема string name.

Класът Student наследява Person и има свой собствен конструктор.

В този конструктор използваме : base(name) — това казва:
👉 „Преди да изпълниш кода на Student, извикай конструктора на Person с параметъра name.“

След това се изпълнява тялото на конструктора на Student,
където инициализираме school.

🔹 Защо е полезно

Избягва се дублиране на код.

Гарантира се, че базовият клас е правилно инициализиран преди наследника.

Дава възможност да използваме логиката, дефинирана в базовия конструктор.







English Explanation
🔹 “Constructors are not inherited”

When a class inherits another class (class Student : Person),
methods and properties are inherited, but constructors are not.
So Student cannot directly use the constructor of Person.

🔹 How can we reuse them then?

Even though they’re not inherited, we can explicitly call a base class constructor
using the keyword base.

🔹 Example:
class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    private School school;

    public Student(string name, School school)
        : base(name)   // calls Person(string name)
    {
        this.school = school;
    }
}

🔹 What happens here:

Person defines a constructor that takes a string name.

Student inherits from Person and defines its own constructor.

The : base(name) part means:
👉 “Before running the Student constructor, first call the constructor of Person with name.”

After that, the Student constructor body runs and initializes school.

🔹 Why this is good:

Avoids code duplication.

Ensures the base class is properly initialized before the derived one.

Allows reuse of base logic (e.g., setting up properties, validation, etc.).