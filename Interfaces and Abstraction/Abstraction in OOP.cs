
Абстракция в ООП

Дефиниция: Абстракцията означава игнориране на нерелевантни характеристики, свойства или функции и акцент върху тези, които са релевантни на контекста.

Релевантни за какво? Релевантни са за контекста на проекта, който разработваме.

Защо използваме абстракция?

Абстракцията помага да управляваме сложността, като скрива ненужните детайли.

Абстракцията ни позволява да се фокусираме върху това, какво прави обектът, а не върху това как го прави вътрешно.

Пример в C#:

abstract class Device
{
    public string Name { get; set; }

    // Абстрактен метод – показва какво прави устройството
    public abstract void TurnOn();
}

class Laptop : Device
{
    public override void TurnOn()
    {
        Console.WriteLine($"{Name} лаптопът се включва...");
    }
}


✅ Обяснение:

Проектът се интересува само, че Device може да се включи.

Как точно се включва вътрешно е скрито – това е абстракцията.







Abstraction in OOP

Definition: Abstraction means ignoring irrelevant features, properties, or functions and emphasizing only the ones relevant to the context.

Relevant to what? Relevant to the context of the project we are developing.

Why use abstraction?

Abstraction helps manage complexity by hiding unnecessary details.

Abstraction lets you focus on what the object does, instead of how it does it internally.


Example in C#:

abstract class Device
{
    public string Name { get; set; }

    // Abstract method – shows what the device does
    public abstract void TurnOn();
}

class Laptop : Device
{
    public override void TurnOn()
    {
        Console.WriteLine($"{Name} laptop is turning on...");
    }
}


✅ Explanation:

The project only cares that a Device can turn on.

How it actually turns on (internal mechanics) is hidden – that’s abstraction.