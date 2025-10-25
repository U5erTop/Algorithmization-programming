## Раздел 1: Частичные Классы (Задачи 1-15)

1. Создайте частичный класс `Person` в двух файлах: первый файл содержит поля, второй - методы.
2. Определите частичный класс `Calculator` с методами сложения в одной части и вычитания в другой.
3. Создайте частичный класс `Customer` с основными свойствами в одной части и вспомогательными методами в другой.
4. Разделите класс `Product` на две части: в первой определите свойства, во второй - методы для расчётов.
5. Создайте частичный класс `Student` с полями в первой части и методами для получения информации во второй.
6. Определите частичный класс `Employee` с основной информацией в одной части и методами расчёта зарплаты в другой.
7. Создайте частичный класс `Rectangle` и разделите его логику на две части.
8. Разделите класс `BankAccount` на две части: операции счёта и логирование.
9. Создайте частичный класс `Book` с информацией о книге и методами поиска.
10. Определите частичный класс `Car` с характеристиками и методами управления.
11. Создайте частичный класс `House` и разделите его функциональность.
12. Определите частичный класс `Game` с логикой инициализации и логикой игры.
13. Создайте частичный класс `Database` с подключением и запросами.
14. Разделите класс `Logger` на две части: логирование в файл и вывод.
15. Создайте частичный класс `Configuration` с загрузкой и сохранением параметров.

## Раздел 2: Частичные Методы (Задачи 16-30)

16. Создайте частичный класс с частичным методом `OnValidation()` для проверки данных.
17. Определите частичный метод `OnError()` в классе `Logger`.
18. Создайте частичный метод `OnPropertyChanged()` в классе `NotificationObject`.
19. Определите частичный метод `OnInitialize()` в классе `Application`.
20. Создайте частичный метод `OnDataLoaded()` в классе `DataManager`.
21. Определите частичный метод `OnStateChanged()` в классе `StateMachine`.
22. Создайте частичный метод `OnBeforeSave()` в классе `Entity`.
23. Определите частичный метод `OnAfterDelete()` в классе `Repository`.
24. Создайте частичный метод `OnProcessing()` в классе `DataProcessor`.
25. Определите частичный метод `OnConnectionOpened()` в классе `Connection`.
26. Создайте частичный метод `OnAuthenticationFailed()` в классе `Authenticator`.
27. Определите частичный метод `OnCacheExpired()` в классе `Cache`.
28. Создайте частичный метод `OnRetry()` в классе `RetryPolicy`.
29. Определите частичный метод `OnTimeout()` в классе `Request`.
30. Создайте частичный метод `OnCompleted()` в классе `AsyncTask`.

## Раздел 3: ReadOnly Поля (Задачи 31-50)

31. Создайте класс `Circle` с readonly полем `Radius`.
32. Определите класс `Point` с readonly полями `X` и `Y`.
33. Создайте класс `Color` с readonly полями `Red`, `Green`, `Blue`.
34. Определите класс `Vector` с readonly полем `Magnitude`.
35. Создайте класс `Complex` для комплексных чисел с readonly полями `Real` и `Imaginary`.
36. Определите класс `Fraction` с readonly полями `Numerator` и `Denominator`.
37. Создайте класс `Date` с readonly полями `Day`, `Month`, `Year`.
38. Определите класс `Time` с readonly полями `Hours`, `Minutes`, `Seconds`.
39. Создайте класс `Money` с readonly полями `Amount` и `Currency`.
40. Определите класс `Range` с readonly полями `Min` и `Max`.
41. Создайте класс `Rectangle` с readonly полями `Width` и `Height`.
42. Определите класс `Triangle` с readonly полями трёх сторон.
43. Создайте класс `Coordinates` с readonly полями `Latitude` и `Longitude`.
44. Определите класс `Version` с readonly полями `Major`, `Minor`, `Patch`.
45. Создайте класс `Interval` с readonly полями `Start` и `End`.
46. Определите класс `Matrix` с readonly полем `Order` (размер матрицы).
47. Создайте класс `Person` с readonly полем `BirthDate` (дата рождения).
48. Определите класс `Employee` с readonly полем `EmployeeID`.
49. Создайте класс `Document` с readonly полями `DocumentID` и `CreatedDate`.
50. Определите класс `ISBN` с readonly полем `Code`.

## Раздел 4: Основные Парадигмы ООП (Задачи 51-70)

### Инкапсуляция (Задачи 51-55)

51. Создайте класс `BankAccount` с приватными полями для баланса и реализуйте управляемый доступ через методы.
52. Определите класс `Person` с приватными полями и публичными свойствами для доступа.
53. Создайте класс `Password` с валидацией пароля через приватные методы.
54. Определите класс `Email` с проверкой корректности электронной почты.
55. Создайте класс `Temperature` с преобразованием между Цельсием и Фаренгейтом через инкапсуляцию.

### Наследование (Задачи 56-60)

56. Создайте базовый класс `Animal` и производный класс `Dog`.
57. Определите базовый класс `Vehicle` и производные классы `Car` и `Motorcycle`.
58. Создайте базовый класс `Shape` и производные классы `Circle` и `Rectangle`.
59. Определите базовый класс `Employee` и производные классы `Manager` и `Developer`.
60. Создайте базовый класс `Account` и производные классы `SavingsAccount` и `CheckingAccount`.

### Полиморфизм (Задачи 61-65)

61. Создайте виртуальный метод `MakeSound()` в классе `Animal` и переопределите его в `Dog` и `Cat`.
62. Определите абстрактный класс `Shape` с абстрактным методом `CalculateArea()`.
63. Создайте интерфейс `IPayable` и реализуйте его в классах `Employee` и `Contractor`.
64. Определите виртуальное свойство `Price` в классе `Product` с переопределением в `DigitalProduct`.
65. Создайте полиморфный массив объектов `Shape` и вычислите общую площадь.

### Абстракция (Задачи 66-70)

66. Создайте абстрактный класс `DatabaseConnection` с абстрактными методами подключения.
67. Определите интерфейс `IRepository` для работы с данными.
68. Создайте абстрактный класс `Logger` с методом логирования.
69. Определите интерфейс `IValidator` для проверки данных.
70. Создайте абстрактный класс `PaymentProcessor` для обработки платежей.

## Раздел 5: Диаграммы Классов UML (Задачи 71-85)

71. Создайте класс на основе UML диаграммы для системы управления библиотекой (Book, Author, Library).
72. Определите классы для системы управления школой (Student, Teacher, Course).
73. Создайте классы для e-commerce системы (Product, Order, Customer).
74. Определите классы для системы управления проектами (Project, Task, Team).
75. Создайте классы для системы управления больницей (Doctor, Patient, Appointment).
76. Определите классы для игровой системы (Character, Inventory, Item).
77. Создайте классы для системы управления рестораном (Menu, Dish, Order).
78. Определите классы для системы бронирования отелей (Hotel, Room, Booking).
79. Создайте классы для системы управления транспортом (Vehicle, Driver, Route).
80. Определите классы для системы управления банком (Bank, Account, Transaction).
81. Создайте классы для системы управления школьной оценкой (Grade, Student, Subject).
82. Определите классы для системы управления событиями (Event, Attendee, Venue).
83. Создайте классы для системы управления социальной сетью (User, Post, Comment).
84. Определите классы для системы управления спортивной лигой (Team, Player, Match).
85. Создайте классы для системы управления кино (Movie, Actor, Cinema).

## Раздел 6: Отношения между Классами (Задачи 86-100)

### Самоассоциация (Задачи 86-91)

86. Создайте класс `Person` с самоассоциацией (ссылка на начальника).
87. Определите класс `Node` для древовидной структуры с самоассоциацией.
88. Создайте класс `Employee` с ссылкой на менеджера (самоассоциация).
89. Определите класс `Category` с родительской категорией (самоассоциация).
90. Создайте класс `TreeNode` для представления дерева.
91. Определите класс `LinkedListNode` с ссылкой на следующий узел.

### Ассоциация (Задачи 92-100)

92. Создайте классы `Student` и `Course` с ассоциацией «один-ко-многим».
93. Определите классы `Doctor` и `Patient` с ассоциацией «один-ко-многим».
94. Создайте классы `Author` и `Book` с ассоциацией.
95. Определите классы `Teacher` и `Class` с ассоциацией.
96. Создайте классы `Company` и `Employee` с ассоциацией.
97. Определите классы `Library` и `Book` с ассоциацией.
98. Создайте классы `Team` и `Player` с ассоциацией.
99. Определите классы `Order` и `Product` с ассоциацией.
100. Создайте классы `Project` и `Developer` с ассоциацией.

---

## Задача 1: Частичные Классы (Задача #1)

**Описание**: Создайте частичный класс `Person` в двух файлах: первый файл содержит поля, второй - методы.

**Person.Part1.cs** (Часть 1 - Поля и свойства):

```csharp
using System;

partial class Person
{
    private string name;
    private int age;
    private string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
}
```

**Person.Part2.cs** (Часть 2 - Методы):

```csharp
using System;

partial class Person
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Email: {Email}");
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }

    public string GetGreeting()
    {
        return $"Привет, {Name}!";
    }
}
```

**Program.cs** (Использование):

```csharp
using System;

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Иван Петров";
        person.Age = 25;
        person.Email = "ivan@example.com";

        person.DisplayInfo();
        Console.WriteLine($"Совершеннолетний: {person.IsAdult()}");
        Console.WriteLine(person.GetGreeting());
    }
}
```

**Объяснение**: Ключевое слово `partial` позволяет разделить определение класса на несколько файлов. Это удобно для разделения ответственности: поля в одном файле, методы в другом. При компиляции компилятор объединяет обе части в один класс.

---

## Задача 2: Частичные Методы (Задача #16)

**Описание**: Создайте частичный класс с частичным методом `OnValidation()` для проверки данных.

**Validator.Part1.cs** (Определение интерфейса):

```csharp
using System;

partial class Validator
{
    private string data;

    public Validator(string inputData)
    {
        data = inputData;
    }

    public bool Validate()
    {
        Console.WriteLine("Начало валидации...");
        OnValidation();
        Console.WriteLine("Валидация завершена.");
        return true;
    }

    // Объявление частичного метода
    partial void OnValidation();
}
```

**Validator.Part2.cs** (Реализация):

```csharp
using System;

partial class Validator
{
    // Реализация частичного метода
    partial void OnValidation()
    {
        if (string.IsNullOrEmpty(data))
        {
            Console.WriteLine("Ошибка: данные пусты!");
        }
        else if (data.Length < 3)
        {
            Console.WriteLine("Ошибка: данные слишком короткие!");
        }
        else
        {
            Console.WriteLine($"✓ Данные валидны: {data}");
        }
    }
}
```

**Program.cs** (Использование):

```csharp
using System;

class Program
{
    static void Main()
    {
        Validator validator1 = new Validator("Привет");
        validator1.Validate();

        Console.WriteLine();

        Validator validator2 = new Validator("Hi");
        validator2.Validate();

        Console.WriteLine();

        Validator validator3 = new Validator("");
        validator3.Validate();
    }
}
```

**Вывод**:
```
Начало валидации...
✓ Данные валидны: Привет
Валидация завершена.

Начало валидации...
Ошибка: данные слишком короткие!
Валидация завершена.

Начало валидации...
Ошибка: данные пусты!
Валидация завершена.
```

**Объяснение**: Частичный метод объявляется в одной части класса и может быть реализован в другой. Если метод не реализован, компилятор просто удаляет вызов. Это полезно для создания расширяемого кода.

---

## Задача 3: ReadOnly Поля (Задача #31)

**Описание**: Создайте класс `Circle` с readonly полем `Radius`.

```csharp
using System;

class Circle
{
    // Readonly поле - инициализируется только в конструкторе
    private readonly double radius;

    public double Radius
    {
        get { return radius; }
    }

    // Конструктор для инициализации readonly поля
    public Circle(double r)
    {
        if (r <= 0)
            throw new ArgumentException("Радиус должен быть положительным!");
        
        radius = r;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Радиус: {Radius}");
        Console.WriteLine($"Площадь: {GetArea():F2}");
        Console.WriteLine($"Периметр: {GetPerimeter():F2}");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle(5);
        circle.DisplayInfo();

        Console.WriteLine();

        Circle circle2 = new Circle(3.5);
        circle2.DisplayInfo();

        // circle.radius = 10; // Ошибка! readonly поле нельзя изменить
    }
}
```

**Вывод**:
```
Радиус: 5
Площадь: 78.50
Периметр: 31.42

Радиус: 3.5
Площадь: 38.48
Периметр: 21.99
```

**Объяснение**: `readonly` поле может быть инициализировано только при объявлении или в конструкторе. После создания объекта значение не может быть изменено. Это гарантирует неизменяемость важных данных.

---

## Задача 4: Парадигмы ООП - Наследование (Задача #56)

**Описание**: Создайте базовый класс `Animal` и производный класс `Dog`.

```csharp
using System;

// Базовый класс
class Animal
{
    protected string name;
    protected int age;

    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Издаёт звук");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}");
    }
}

// Производный класс
class Dog : Animal
{
    private string breed;

    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Гав! Гав!");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Порода: {breed}");
    }

    public void Fetch()
    {
        Console.WriteLine($"{name} приносит мяч!");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Animal("Питомец", 5);
        animal.MakeSound();
        animal.DisplayInfo();

        Console.WriteLine();

        Dog dog = new Dog("Шарик", 3, "Лабрадор");
        dog.MakeSound();
        dog.DisplayInfo();
        dog.Fetch();
    }
}
```

**Вывод**:
```
Издаёт звук
Имя: Питомец, Возраст: 5

Гав! Гав!
Имя: Шарик, Возраст: 3
Порода: Лабрадор
Шарик приносит мяч!
```

**Объяснение**: Наследование позволяет создавать новые классы на основе существующих. Класс `Dog` наследует свойства и методы класса `Animal`. Ключевое слово `virtual` позволяет переопределить методы в производном классе с помощью `override`.

---

## Задача 5: Ассоциация между Классами (Задача #92)

**Описание**: Создайте классы `Student` и `Course` с ассоциацией «один-ко-многим».

```csharp
using System;
using System.Collections.Generic;

class Course
{
    public string Name { get; set; }
    public string Code { get; set; }
    public int Credits { get; set; }

    public Course(string name, string code, int credits)
    {
        Name = name;
        Code = code;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"{Name} ({Code})";
    }
}

class Student
{
    public string Name { get; set; }
    public int StudentID { get; set; }
    
    // Ассоциация - один студент может посещать многие курсы
    private List<Course> enrolledCourses = new List<Course>();

    public Student(string name, int id)
    {
        Name = name;
        StudentID = id;
    }

    public void EnrollInCourse(Course course)
    {
        if (!enrolledCourses.Contains(course))
        {
            enrolledCourses.Add(course);
            Console.WriteLine($"{Name} зачислен на курс: {course.Name}");
        }
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"\nКурсы студента {Name}:");
        if (enrolledCourses.Count == 0)
        {
            Console.WriteLine("  Нет активных курсов");
            return;
        }

        foreach (Course course in enrolledCourses)
        {
            Console.WriteLine($"  - {course}");
        }
    }

    public int GetTotalCredits()
    {
        int total = 0;
        foreach (Course course in enrolledCourses)
        {
            total += course.Credits;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        // Создание курсов
        Course math = new Course("Математика", "MATH101", 3);
        Course english = new Course("Английский язык", "ENG101", 3);
        Course history = new Course("История", "HIST101", 2);
        Course physics = new Course("Физика", "PHYS101", 4);

        // Создание студентов
        Student student1 = new Student("Иван Петров", 101);
        Student student2 = new Student("Мария Сидорова", 102);

        // Регистрация студентов на курсы
        student1.EnrollInCourse(math);
        student1.EnrollInCourse(english);
        student1.EnrollInCourse(physics);

        student2.EnrollInCourse(math);
        student2.EnrollInCourse(history);
        student2.EnrollInCourse(english);

        // Вывод информации
        student1.DisplayCourses();
        Console.WriteLine($"Всего кредитов: {student1.GetTotalCredits()}");

        student2.DisplayCourses();
        Console.WriteLine($"Всего кредитов: {student2.GetTotalCredits()}");
    }
}
```

**Вывод**:
```
Иван Петров зачислен на курс: Математика
Иван Петров зачислен на курс: Английский язык
Иван Петров зачислен на курс: Физика
Мария Сидорова зачислен на курс: Математика
Мария Сидорова зачислен на курс: История
Мария Сидорова зачислен на курс: Английский язык

Курсы студента Иван Петров:
  - Математика (MATH101)
  - Английский язык (ENG101)
  - Физика (PHYS101)
Всего кредитов: 10

Курсы студента Мария Сидорова:
  - Математика (MATH101)
  - История (HIST101)
  - Английский язык (ENG101)
Всего кредитов: 8
```

**Объяснение**: Ассоциация «один-ко-многим» означает, что один объект (Student) может быть связан со многими объектами другого класса (Course). Это реализуется через список `List<Course>`. Студент может записаться на несколько курсов.

---

## Краткое Резюме по Продвинутому ООП

| Концепция | Описание | Использование |
|-----------|---------|----------------|
| **Частичный класс** | Разделение класса на несколько файлов | `partial class` |
| **Частичный метод** | Метод, реализация которого опциональна | `partial void` |
| **ReadOnly поле** | Поле, инициализируемое только в конструкторе | `private readonly` |
| **Инкапсуляция** | Скрытие внутренней реализации | Приватные поля, публичные свойства |
| **Наследование** | Создание новых классов на основе существующих | `class Dog : Animal` |
| **Полиморфизм** | Методы с одинаковым именем, разной реализацией | `virtual` и `override` |
| **Самоассоциация** | Класс имеет ссылку на объект своего же класса | Ссылка на начальника, родителя |
| **Ассоциация** | Связь между двумя разными классами | `List<Course>` в классе `Student` |
