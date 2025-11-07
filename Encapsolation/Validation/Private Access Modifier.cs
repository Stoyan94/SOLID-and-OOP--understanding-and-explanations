
Инкапсулацията в C# е основен принцип на обектно-ориентираното програмиране, който служи за скриване на вътрешните данни и детайли на една класа от външния свят. 

Това означава, че само самата класа има достъп до своите частни (private) полета и методи, а външният код не може директно да ги променя.

Модификаторът private е най-ограничаващият – той позволява достъп само в рамките на същата класа.
Например:

private string name;

public Person(string name)
{
    this.name = name;
}


Тук полето name е private, което означава, че само методи вътре в класа Person могат да го достъпят или променят. 
Обикновено достъпът отвън се осигурява чрез публични (public) свойства(properties) или методи, които контролират как данните се четат и записват.






(in English):
Encapsulation in C# is a key object-oriented programming principle used to hide internal data and implementation details from the outside world. This means that only the class itself can access and modify its private fields and methods, while external code cannot access them directly.

The private access modifier is the most restrictive one — it allows access only within the same class.
For example:

private string name;

public Person(string name)
{
    this.name = name;
}


Here, the field name is private, which means it can only be accessed or modified inside the Person class. Usually, external access is provided through public properties or methods that control how data is read or modified.