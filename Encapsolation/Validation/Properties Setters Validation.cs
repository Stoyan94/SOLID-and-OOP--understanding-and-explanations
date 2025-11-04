Основна идея

Тук става дума за валидация в setter-а (в свойството).
Свойството (property) е най-доброто място за проста проверка на данни, преди те да бъдат записани във вътрешното поле.
Това е част от инкапсулацията — ти контролираш какви стойности могат да влизат в обекта.

📘 Примерът:
public decimal Salary
{
    get { return this.salary; }
    set
    {
        if (value < 650)
            throw new ArgumentException("Salary cannot be less than 650!");
        this.salary = value;
    }
}

🔹 Какво прави кодът:

get връща текущата стойност на полето salary.

set се изпълнява при опит за задаване на нова стойност.

Ако новата стойност (value) е по-малка от 650, се хвърля изключение (ArgumentException).

Ако проверката мине успешно, стойността се записва в полето чрез this.salary = value;.


🔹 Защо е полезно:

Гарантира, че никой не може да зададе невалидна стойност.

Дава по-добър контрол върху състоянието на обекта.

Помага за откриване на грешки рано, при опит за задаване на неправилна стойност.

🔹 Важно:

Извикващият(caller) трябва да обработи изключението (try-catch),
защото setter-ът може да хвърли грешка.

📘 Пример за обработка:

try
{
    employee.Salary = 500; // това ще хвърли грешка
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}







🇬🇧 Explanation(English)
🔹 Main idea

This example shows data validation inside a setter.
A property’s setter is a good place to perform simple validation checks before assigning a value to the internal field.
This is part of encapsulation — controlling how data enters the object.

📘 Example:
public decimal Salary
{
    get { return this.salary; }
    set
    {
        if (value < 650)
            throw new ArgumentException("Salary cannot be less than 650!");
        this.salary = value;
    }
}

🔹 What happens:

The get accessor returns the current value of salary.

The set accessor runs whenever someone assigns a new value.

If the new value(value) is less than 650, it throws an ArgumentException.

Otherwise, it safely stores the value in the field.

🔹 Why this is good:

Ensures that invalid data cannot be assigned.

Gives control over the object’s internal state.

Helps detect problems early, when incorrect data is provided.

🔹 Important:

The caller must handle the possible exception (try-catch),
since the setter can throw an error.

📘 Example:

try
{
    employee.Salary = 500; // will throw an exception
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);