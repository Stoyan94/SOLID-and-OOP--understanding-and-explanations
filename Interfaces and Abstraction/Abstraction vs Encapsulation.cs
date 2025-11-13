Абстракция vs Инкапсулация

Абстракция:

Процес на скриване на детайлите на реализацията и показване само на функционалността към потребителя.

Реализира се чрез интерфейси и абстрактни класове.

Фокусира се върху какво прави обектът, а не как го прави.

Инкапсулация:

Използва се за скриване на кода и данните в една единица, за да се защити от външни манипулации.

Реализира се чрез модификатори на достъп (private, protected, public и др.).

Фокусира се върху контролиран достъп до вътрешното състояние на обекта.

Бърз пример:

class BankAccount
{
    private double balance; // Инкапсулация: скриване на данните

    public void Deposit(double amount) // Абстракция: показва функционалността
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public double GetBalance() // Абстракция: показва функционалността
    {
        return balance;
    }
}


✅ Обяснение:

Инкапсулация: balance е private и външен код не може да го променя директно.

Абстракция: Deposit и GetBalance показват действията, които могат да се извършат с акаунта, без да се разкриват вътрешните детайли.






Abstraction vs Encapsulation

Abstraction:

The process of hiding implementation details and showing only the functionality to the user.

Achieved with interfaces and abstract classes.

Focuses on what an object does rather than how it does it.

Encapsulation:

Used to hide code and data inside a single unit to protect it from outside interference.

Achieved with access modifiers (private, protected, public, etc.).

Focuses on controlling access to the internal state of an object.

Quick Example:

class BankAccount
{
    private double balance; // Encapsulation: hide the data

    public void Deposit(double amount) // Abstraction: show functionality
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public double GetBalance() // Abstraction: show functionality
    {
        return balance;
    }
}


✅ Explanation:

Encapsulation: balance is private, so external code cannot modify it directly.

Abstraction: Deposit and GetBalance show the actions you can do with the account without exposing the internal details.