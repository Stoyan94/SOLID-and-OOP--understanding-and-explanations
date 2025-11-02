Обяснение: ключовата дума this в C#

Ключовата дума this е референция към текущия обект, върху който се извиква даден метод или свойство.
Тя сочи към текущия екземпляр (instance) на класа.
С други думи — this означава:

“Този конкретен обект, с който в момента работим.”

🔹 Използвания на this:

Достъп до текущите полета и свойства на класа

Когато локална променлива или параметър има същото име като поле, this премахва двусмислието.

Предаване на текущия обект като параметър на друг метод

Можем да предадем this на друг метод, който приема обект от същия тип.

Връщане на текущия обект от метод

Може да върнеш this от метод, например при method chaining (вързани извиквания).

Извикване на други методи на текущия клас

Може да се използва, за да уточниш, че методът или свойството принадлежи на текущия обект.


📘 Примери:

1️⃣ Разрешаване на конфликти между имена
public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name; // this сочи към полето на класа
    }
}


➡️ Без this, компилаторът не би знаел кое name имаш предвид — параметъра или полето.
this.name ясно показва, че искаме полето на текущия обект.


2️⃣ Предаване на текущия обект като параметър

public class Car
{
    public string Model { get; set; }

    public void Show(Car car)
    {
        Console.WriteLine("Car model: " + car.Model);
    }

    public void Display()
    {
        Show(this); // предаваме текущия обект
    }
}


➡️ this тук препраща към същия обект, върху който се извиква Display().


3️⃣ Връщане на текущия обект (method chaining)

public class Builder
{
    private string text = "";

    public Builder Add(string value)
    {
        text += value;
        return this; // връща текущия обект
    }

    public void Show() => Console.WriteLine(text);
}

// Използване:
var b = new Builder();
b.Add("Hello ").Add("World!").Show();


➡️ return this позволява няколко извиквания едно след друго — chain pattern.









🇬🇧 Explanation: keyword this in C#

The keyword this is a reference to the current object — the instance on which a method or property is called.
In other words, it points to the current instance of the class.

🔹 Uses of this:

Access current fields or properties
– Used when local variables or parameters have the same names as class fields.

Pass the current object as a parameter
– You can send this to another method that accepts the same class type.

Return the current object
– Used for method chaining, returning the same instance.

Call another method of the same class
– Makes it clear that a method belongs to the current instance.

📘 Examples:
1️⃣ Resolving name conflicts
public class Person
{
    private string name;

    public Person(string name)
    {
        this.name = name; // refers to the class field
    }
}


➡️ Without this, the compiler wouldn’t know if you mean the parameter or the field.

2️⃣ Passing current object
public class Car
{
    public string Model { get; set; }

    public void Show(Car car)
    {
        Console.WriteLine("Car model: " + car.Model);
    }

    public void Display()
    {
        Show(this); // passes the current object
    }
}

3️⃣ Returning the current object
public class Builder
{
    private string text = "";

    public Builder Add(string value)
    {
        text += value;
        return this; // returns the same instance
    }

    public void Show() => Console.WriteLine(text);
}


➡️ return this allows you to chain method calls fluently.