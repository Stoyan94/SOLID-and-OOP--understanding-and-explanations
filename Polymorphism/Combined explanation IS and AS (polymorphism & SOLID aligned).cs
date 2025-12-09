🇬🇧 Combined explanation: is and as (polymorphism & SOLID aligned)

The C# is and as operators are not deprecated,
but using them to check for specific concrete types and then casting is bad practice in 90% of real-world scenarios.

❌ Why is it bad?

Breaks LSP – if you're working with an interface/base type, you shouldn’t care about the actual subtype.

Breaks OCP – every new subtype forces you to add new if (obj is ...) branches.

Destroys polymorphism – instead of relying on abstraction, you manually check types.

Creates code smells – strong coupling between concrete classes.

Usually indicates wrong design – missing interface or abstraction.

❗ The golden rule:

If you’re writing if (obj is T) or using obj as T, your design is probably violating OOP principles.

❗ Scott Meyers’ quote (perfectly aligned):

“Anytime you find yourself writing code of the form
‘if the object is of type T1, then do something, but if it's of type T2, then do something else,’
slap yourself.”
— Effective C++, Scott Meyers

This is a warning that type-checking destroys proper OOP design.

✔ What to do instead?

Use interfaces, abstract classes, virtual methods, overriding, polymorphism —
not type checking.







🇧🇬 Комбинирано обяснение: is и as (в духа на полиморфизма и SOLID)

Операторите is и as в C# не са deprecated,
но използването им за проверка на конкретни типове и каст към конкретен клас е лоша практика в 90% от случаите.

❌ Защо е лошо?

Нарушава LSP (Liskov Substitution Principle) – ако работиш с интерфейс или базов клас, не трябва да те интересува реалният тип.

Нарушава OCP (Open/Closed Principle) – всеки нов тип те кара да добавяш нови if (x is Something).

Унищожава полиморфизма – вместо да използваш виртуални методи/интерфейси, проверяваш типове ръчно.

Води до code smells – зависиш от конкретни класове → tight coupling.

Обикновено означава грешен дизайн: щом се налага каст → липсва интерфейс или абстракция.

❗ Златното правило:

Ако пишеш if (obj is T) или obj as T → вероятно нарушаваш полиморфизма.

❗ Цитатът на Скот Майърс (точно по темата):

“Anytime you find yourself writing code of the form
‘if the object is of type T1, do something, but if it's of type T2, do something else’,
slap yourself.”
— Effective C++, Scott Meyers

Това е директен шамар към type-check логиката —
ако правиш това, не използваш ООП правилно.

✔ Какво се прави вместо това?

Използваш интерфейси, абстрактни класове, виртуални методи, override, полиморфизъм,
а не проверки на типове.