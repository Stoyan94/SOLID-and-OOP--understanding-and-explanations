Inheritance has a transitive relation / Наследяването е транзитивно

Български:

Транзитивно наследяване означава, че ако клас A наследява клас B, а клас B наследява клас C, то A автоматично наследява членовете на C.

С други думи, наследяването се „преминава“ през веригата на класовете.

Пример:

class Person
{
    public string Name { get; set; }
}

class Student : Person
{
    public string School { get; set; }
}

class CollegeStudent : Student
{
    public string College { get; set; }
}


Student наследява Person, следователно има Name.

CollegeStudent наследява Student, следователно има и School, и Name.

Транзитивността означава, че CollegeStudent получава всичко от Student и Person.

💡 Основна идея:

Всеки наследник получава всички членове на всички предшественици по веригата.







English:

Transitive inheritance means that if class A inherits from class B, and class B inherits from class C, then A automatically inherits the members of C.

In other words, inheritance is “passed along” the class chain.

Example:

class Person
{
    public string Name { get; set; }
}

class Student : Person
{
    public string School { get; set; }
}

class CollegeStudent : Student
{
    public string College { get; set; }
}


Student inherits from Person, so it has Name.

CollegeStudent inherits from Student, so it has both School and Name.

Transitivity means CollegeStudent gets everything from Student and Person.

💡 Key takeaway:

Each derived class gets all members of all ancestors in the chain.