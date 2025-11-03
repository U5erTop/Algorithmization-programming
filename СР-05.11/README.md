# README: Решения 5 задач по статическим членам, статическим классам, расширяющим методам и вложенным классам в C#

## Задача 1: Статические члены класса (Задача #1)

**Описание**: Создайте класс `Counter` с одним статическим полем для подсчета созданных объектов.

**Решение**:

```csharp
using System;

class Counter
{
    // Статическое поле - общее для всех объектов класса
    public static int TotalCount { get; private set; } = 0;
    
    // Экземплярное поле
    public int InstanceId { get; private set; }

    // Конструктор
    public Counter()
    {
        TotalCount++; // Увеличиваем общий счетчик
        InstanceId = TotalCount; // Присваиваем уникальный ID
    }

    // Статический метод
    public static void DisplayTotalCount()
    {
        Console.WriteLine($"Всего создано объектов: {TotalCount}");
    }

    // Экземплярный метод
    public void DisplayMyId()
    {
        Console.WriteLine($"Мой ID: {InstanceId}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Создание объектов Counter:");
        
        Counter counter1 = new Counter();
        counter1.DisplayMyId(); // Мой ID: 1
        Counter.DisplayTotalCount(); // Всего создано объектов: 1

        Counter counter2 = new Counter();
        counter2.DisplayMyId(); // Мой ID: 2
        Counter.DisplayTotalCount(); // Всего создано объектов: 2

        Counter counter3 = new Counter();
        counter3.DisplayMyId(); // Мой ID: 3
        Counter.DisplayTotalCount(); // Всего создано объектов: 3

        // Статическое поле одно на всех
        Console.WriteLine($"\nФинальный подсчет: {Counter.TotalCount}");
    }
}
```

**Вывод**:
```
Создание объектов Counter:
Мой ID: 1
Всего создано объектов: 1
Мой ID: 2
Всего создано объектов: 2
Мой ID: 3
Всего создано объектов: 3

Финальный подсчет: 3
```

**Объяснение**: 
- **Статические члены** принадлежат классу, а не отдельным объектам
- Все объекты класса делят один общий **статический счетчик**
- Статические методы вызываются через имя класса, а не объекта
- Экземплярные поля уникальны для каждого объекта
- Статические поля инициализируются один раз при загрузке класса

---

## Задача 2: Статический класс MathTools (Задача #26)

**Описание**: Определите полностью статический класс `MathTools` с методами сложения/вычитания.

**Решение**:

```csharp
using System;

// Статический класс - не может быть инстанцирован
public static class MathTools
{
    // Статическая константа
    public const double PI = 3.14159265359;
    public const double E = 2.71828182846;

    // Статические методы
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Деление на ноль!");
        return (double)a / b;
    }

    public static int Power(int baseNumber, int exponent)
    {
        return (int)Math.Pow(baseNumber, exponent);
    }

    public static int Absolute(int number)
    {
        return Math.Abs(number);
    }

    public static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }

    public static int Min(int a, int b)
    {
        return Math.Min(a, b);
    }
}

class Program
{
    static void Main()
    {
        // Использование статического класса
        Console.WriteLine("Статический класс MathTools:");
        Console.WriteLine($"5 + 3 = {MathTools.Sum(5, 3)}");
        Console.WriteLine($"5 - 3 = {MathTools.Subtract(5, 3)}");
        Console.WriteLine($"5 * 3 = {MathTools.Multiply(5, 3)}");
        Console.WriteLine($"15 / 3 = {MathTools.Divide(15, 3)}");
        Console.WriteLine($"2 ^ 8 = {MathTools.Power(2, 8)}");
        Console.WriteLine($"|-5| = {MathTools.Absolute(-5)}");
        Console.WriteLine($"Max(5, 3) = {MathTools.Max(5, 3)}");
        Console.WriteLine($"Min(5, 3) = {MathTools.Min(5, 3)}");

        Console.WriteLine($"\nКонстанты:");
        Console.WriteLine($"PI = {MathTools.PI}");
        Console.WriteLine($"E = {MathTools.E}");

        // MathTools mathTools = new MathTools(); // ОШИБКА! Нельзя создать объект статического класса
    }
}
```

**Вывод**:
```
Статический класс MathTools:
5 + 3 = 8
5 - 3 = 2
5 * 3 = 15
15 / 3 = 5
2 ^ 8 = 256
|-5| = 5
Max(5, 3) = 5
Min(5, 3) = 3

Константы:
PI = 3.14159265359
E = 2.71828182846
```

**Объяснение**:
- **Статический класс** не может быть инстанцирован (нет `new`)
- Используется для группировки связанных статических методов
- Часто применяется для утилит и помощников
- Все члены должны быть статическими
- Класс помечается модификатором `sealed` (автоматически)

---

## Задача 3: Расширяющий метод (Задача #42)

**Описание**: Создайте расширяющий метод для int: проверка на чётность.

**Решение**:

```csharp
using System;
using System.Collections.Generic;

// Статический класс для расширяющих методов
public static class IntExtensions
{
    // Расширяющий метод - добавляет функциональность к int
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }

    public static bool IsPrime(this int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static int Square(this int number)
    {
        return number * number;
    }

    public static int Cube(this int number)
    {
        return number * number * number;
    }

    public static string ToBinary(this int number)
    {
        return Convert.ToString(number, 2);
    }

    public static int CountDigits(this int number)
    {
        return Math.Abs(number).ToString().Length;
    }
}

// Расширяющие методы для string
public static class StringExtensions
{
    public static int CountWords(this string text)
    {
        return string.IsNullOrEmpty(text) ? 0 : text.Split(' ').Length;
    }

    public static string Reverse(this string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static bool IsPalindrome(this string text)
    {
        string cleaned = text.Replace(" ", "").ToLower();
        return cleaned == cleaned.Reverse();
    }

    public static string FirstLetter(this string text)
    {
        return string.IsNullOrEmpty(text) ? "" : text[0].ToString();
    }
}

// Расширяющие методы для List<int>
public static class ListExtensions
{
    public static int Sum(this List<int> numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
            sum += num;
        return sum;
    }

    public static double Average(this List<int> numbers)
    {
        if (numbers.Count == 0) return 0;
        return (double)numbers.Sum() / numbers.Count;
    }

    public static int Max(this List<int> numbers)
    {
        if (numbers.Count == 0) return 0;
        int max = numbers[0];
        foreach (int num in numbers)
            if (num > max) max = num;
        return max;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Расширяющие методы для int ===");
        int number1 = 5;
        int number2 = 8;

        Console.WriteLine($"{number1} четное? {number1.IsEven()}");
        Console.WriteLine($"{number1} нечетное? {number1.IsOdd()}");
        Console.WriteLine($"{number1} простое? {number1.IsPrime()}");
        Console.WriteLine($"{number1} в квадрате = {number1.Square()}");
        Console.WriteLine($"{number1} в кубе = {number1.Cube()}");
        Console.WriteLine($"{number1} в двоичной системе = {number1.ToBinary()}");
        Console.WriteLine($"Количество цифр в {number2} = {number2.CountDigits()}");

        Console.WriteLine("\n=== Расширяющие методы для string ===");
        string text = "Hello World";
        Console.WriteLine($"'{text}' содержит {text.CountWords()} слов");
        Console.WriteLine($"'{text}' в обратном порядке = '{text.Reverse()}'");
        Console.WriteLine($"Первая буква '{text}' = '{text.FirstLetter()}'");
        
        string palindrome = "racecar";
        Console.WriteLine($"'{palindrome}' палиндром? {palindrome.IsPalindrome()}");

        Console.WriteLine("\n=== Расширяющие методы для List<int> ===");
        List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
        Console.WriteLine($"Список: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Сумма: {numbers.Sum()}");
        Console.WriteLine($"Средее арифметическое: {numbers.Average():F2}");
        Console.WriteLine($"Максимум: {numbers.Max()}");
    }
}
```

**Вывод**:
```
=== Расширяющие методы для int ===
5 четное? False
5 нечетное? True
5 простое? True
5 в квадрате = 25
5 в кубе = 125
5 в двоичной системе = 101
Количество цифр в 8 = 1

=== Расширяющие методы для string ===
'Hello World' содержит 2 слов
'Hello World' в обратном порядке = 'dlroW olleH'
Первая буква 'Hello World' = 'H'
'racecar' палиндром? True

=== Расширяющие методы для List<int> ===
Список: [2, 4, 6, 8, 10]
Сумма: 30
Средее арифметическое: 6.00
Максимум: 10
```

**Объяснение**:
- **Расширяющие методы** позволяют добавлять функциональность к существующим типам
- Находятся в статических классах
- Первый параметр предваряется ключевым словом `this`
- Вызываются как методы экземпляра объекта
- Очень полезны для написания чистого и читаемого кода

---

## Задача 4: Вложенный класс (Задача #61)

**Описание**: Реализуйте класс `Person` с вложенным классом `Passport`.

**Решение**:

```csharp
using System;

// Класс Person с вложенным классом
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    // Вложенный публичный класс
    public class Passport
    {
        public string Number { get; set; }
        public string IssuingCountry { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsValid { get; set; }

        public Passport(string number, string country)
        {
            Number = number;
            IssuingCountry = country;
            IssueDate = DateTime.Now;
            ExpiryDate = DateTime.Now.AddYears(10);
            IsValid = true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"  Номер паспорта: {Number}");
            Console.WriteLine($"  Страна: {IssuingCountry}");
            Console.WriteLine($"  Выдан: {IssueDate:dd.MM.yyyy}");
            Console.WriteLine($"  Действителен до: {ExpiryDate:dd.MM.yyyy}");
            Console.WriteLine($"  Статус: {(IsValid ? "Действителен" : "Истек")}");
        }

        public override string ToString()
        {
            return $"Паспорт #{Number} ({IssuingCountry})";
        }
    }

    // Вложенный приватный класс (используется только внутри Person)
    private class MedicalRecord
    {
        public string BloodType { get; set; }
        public string[] Allergies { get; set; }
        public DateTime LastCheckup { get; set; }

        public MedicalRecord(string bloodType)
        {
            BloodType = bloodType;
            Allergies = new string[0];
            LastCheckup = DateTime.Now;
        }
    }

    // Приватное поле медицинской записи
    private MedicalRecord medicalRecord;

    // Свойство для доступа к паспорту
    public Passport CurrentPassport { get; set; }

    // Конструктор
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        medicalRecord = new MedicalRecord("O");
    }

    // Метод для добавления паспорта
    public void SetPassport(string number, string country)
    {
        CurrentPassport = new Passport(number, country);
    }

    // Метод для отображения информации
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Личная информация:");
        Console.WriteLine($"  Имя: {FirstName}");
        Console.WriteLine($"  Фамилия: {LastName}");
        Console.WriteLine($"  Возраст: {Age}");
        
        if (CurrentPassport != null)
        {
            Console.WriteLine($"\nПаспорт:");
            CurrentPassport.DisplayInfo();
        }
        else
        {
            Console.WriteLine($"\nПаспорт: Не указан");
        }
    }

    // Метод для обновления типа крови (приватное использование)
    public void SetBloodType(string bloodType)
    {
        medicalRecord.BloodType = bloodType;
        Console.WriteLine($"Тип крови обновлен на: {bloodType}");
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта Person
        Person person1 = new Person("Иван", "Петров", 30);

        // Создание паспорта через вложенный класс
        person1.SetPassport("123456789", "Россия");

        // Отображение информации
        person1.DisplayPersonInfo();

        Console.WriteLine("\n" + new string('=', 50) + "\n");

        // Второй пример
        Person person2 = new Person("Мария", "Сидорова", 25);
        person2.SetPassport("987654321", "Казахстан");
        person2.SetBloodType("AB");

        person2.DisplayPersonInfo();

        Console.WriteLine("\n" + new string('=', 50) + "\n");

        // Работа с паспортом напрямую
        Console.WriteLine("Информация о паспорте:");
        Console.WriteLine(person1.CurrentPassport);

        // Создание отдельного объекта паспорта (вложенный класс)
        Person.Passport passport = new Person.Passport("555555555", "США");
        Console.WriteLine($"\nНовый паспорт: {passport}");
    }
}
```

**Вывод**:
```
Личная информация:
  Имя: Иван
  Фамилия: Петров
  Возраст: 30

Паспорт:
  Номер паспорта: 123456789
  Страна: Россия
  Выдан: 03.11.2025
  Действителен до: 03.11.2035
  Статус: Действителен

==================================================

Личная информация:
  Имя: Мария
  Фамилия: Сидорова
  Возраст: 25

Паспорт:
  Номер паспорта: 987654321
  Страна: Казахстан
  Выдан: 03.11.2025
  Действителен до: 03.11.2035
  Статус: Действителен
Тип крови обновлен на: AB

==================================================

Информация о паспорте:
Паспорт #123456789 (Россия)

Новый паспорт: Паспорт #555555555 (США)
```

**Объяснение**:
- **Вложенные классы** определяются внутри другого класса
- **Публичные вложенные классы** доступны снаружи через `Внешний.Вложенный`
- **Приватные вложенные классы** используются только в пределах внешнего класса
- Вложенные классы имеют доступ к приватным членам внешнего класса
- Способствуют логической группировке связанных типов
- Используются для создания ассоциированных вспомогательных классов

---

## Задача 5: Вложенный статический класс-утилита (Задача #80)

**Описание**: Реализуйте класс с вложенным static классом-утилитой.

**Решение**:

```csharp
using System;
using System.Collections.Generic;

// Основной класс для работы с пользователями
class UserManager
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredDate { get; set; }
        public bool IsActive { get; set; }

        public User(int id, string username, string email)
        {
            Id = id;
            Username = username;
            Email = email;
            RegisteredDate = DateTime.Now;
            IsActive = true;
        }

        public override string ToString()
        {
            return $"User(Id={Id}, Username={Username}, Email={Email}, Active={IsActive})";
        }
    }

    // Вложенный статический класс для валидации
    public static class Validator
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPassword(string password)
        {
            // Минимум 8 символов, содержит букву и цифру
            if (password.Length < 8)
                return false;

            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasLetter && hasDigit;
        }

        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 3)
                return false;

            foreach (char c in username)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                    return false;
            }

            return true;
        }
    }

    // Вложенный статический класс для утилит
    public static class Utils
    {
        public static User CreateUser(int id, string username, string email, string password)
        {
            // Валидация
            if (!Validator.IsValidUsername(username))
                throw new ArgumentException("Неверное имя пользователя");

            if (!Validator.IsValidEmail(email))
                throw new ArgumentException("Неверный email");

            if (!Validator.IsValidPassword(password))
                throw new ArgumentException("Пароль должен содержать минимум 8 символов, букву и цифру");

            User user = new User(id, username, email);
            user.Password = HashPassword(password);
            return user;
        }

        public static string HashPassword(string password)
        {
            // Простое хеширование (в реальном приложении использовать BCrypt)
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }

        public static void PrintUserInfo(User user)
        {
            Console.WriteLine($"ID: {user.Id}");
            Console.WriteLine($"Имя пользователя: {user.Username}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Зарегистрирован: {user.RegisteredDate:dd.MM.yyyy HH:mm}");
            Console.WriteLine($"Статус: {(user.IsActive ? "Активен" : "Неактивен")}");
        }

        public static List<User> FilterActiveUsers(List<User> users)
        {
            List<User> activeUsers = new List<User>();
            foreach (User user in users)
            {
                if (user.IsActive)
                    activeUsers.Add(user);
            }
            return activeUsers;
        }

        public static User FindUserByUsername(List<User> users, string username)
        {
            foreach (User user in users)
            {
                if (user.Username == username)
                    return user;
            }
            return null;
        }
    }

    // Хранилище пользователей
    private List<User> users = new List<User>();
    private int nextId = 1;

    public void RegisterUser(string username, string email, string password)
    {
        try
        {
            User newUser = Utils.CreateUser(nextId++, username, email, password);
            users.Add(newUser);
            Console.WriteLine($"✓ Пользователь {username} успешно зарегистрирован");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"✗ Ошибка регистрации: {ex.Message}");
        }
    }

    public void DisplayAllUsers()
    {
        Console.WriteLine("\nВсе пользователи:");
        foreach (User user in users)
        {
            Console.WriteLine(user);
        }
    }

    public void DisplayActiveUsers()
    {
        Console.WriteLine("\nАктивные пользователи:");
        List<User> activeUsers = Utils.FilterActiveUsers(users);
        foreach (User user in activeUsers)
        {
            Console.WriteLine(user);
        }
    }

    public void FindAndDisplay(string username)
    {
        User user = Utils.FindUserByUsername(users, username);
        if (user != null)
        {
            Console.WriteLine($"\nИнформация о пользователе '{username}':");
            Utils.PrintUserInfo(user);
        }
        else
        {
            Console.WriteLine($"\nПользователь '{username}' не найден");
        }
    }
}

class Program
{
    static void Main()
    {
        UserManager manager = new UserManager();

        Console.WriteLine("=== Регистрация пользователей ===\n");

        // Успешная регистрация
        manager.RegisterUser("john_doe", "john@example.com", "password123");
        manager.RegisterUser("jane_smith", "jane@example.com", "secure456");

        // Ошибки регистрации
        manager.RegisterUser("ab", "invalid", "short");
        manager.RegisterUser("user!", "bad@email", "nodigits");

        manager.DisplayAllUsers();
        manager.DisplayActiveUsers();

        // Поиск пользователя
        manager.FindAndDisplay("john_doe");
        manager.FindAndDisplay("nonexistent");

        // Прямое использование вложенного валидатора
        Console.WriteLine("\n=== Проверка валидности ===");
        Console.WriteLine($"Email 'test@example.com' валиден? {UserManager.Validator.IsValidEmail("test@example.com")}");
        Console.WriteLine($"Email 'invalid-email' валиден? {UserManager.Validator.IsValidEmail("invalid-email")}");
        Console.WriteLine($"Пароль 'pass' валиден? {UserManager.Validator.IsValidPassword("pass")}");
        Console.WriteLine($"Пароль 'secure123' валиден? {UserManager.Validator.IsValidPassword("secure123")}");
    }
}
```

**Вывод**:
```
=== Регистрация пользователей ===

✓ Пользователь john_doe успешно зарегистрирован
✓ Пользователь jane_smith успешно зарегистрирован
✗ Ошибка регистрации: Неверное имя пользователя
✗ Ошибка регистрации: Неверный email

Все пользователи:
User(Id=1, Username=john_doe, Email=john@example.com, Active=True)
User(Id=2, Username=jane_smith, Email=jane@example.com, Active=True)

Активные пользователи:
User(Id=1, Username=john_doe, Email=john@example.com, Active=True)
User(Id=2, Username=jane_smith, Email=jane@example.com, Active=True)

Информация о пользователе 'john_doe':
ID: 1
Имя пользователя: john_doe
Email: john@example.com
Зарегистрирован: 03.11.2025 20:47
Статус: Активен

Пользователь 'nonexistent' не найден

=== Проверка валидности ===
Email 'test@example.com' валиден? True
Email 'invalid-email' валиден? False
Пароль 'pass' валиден? False
Пароль 'secure123' валиден? True
```

**Объяснение**:
- **Вложенный статический класс** используется для группировки утилит и методов-помощников
- Класс `Validator` содержит методы проверки данных
- Класс `Utils` содержит вспомогательные методы для создания и обработки пользователей
- Вложенные классы логически связаны с `UserManager` и недоступны отдельно
- Улучшает организацию кода и делает API более интуитивным

---

## Краткая таблица концепций

| Концепция | Описание | Пример |
|-----------|---------|--------|
| **Статические члены** | Принадлежат классу, а не объектам | `static int count = 0;` |
| **Статический метод** | Вызывается через класс | `ClassName.Method()` |
| **Статический класс** | Содержит только статические члены | `static class Utilities` |
| **Расширяющий метод** | Добавляет функцию к существующему типу | `public static bool IsEven(this int)` |
| **Вложенный класс** | Класс внутри класса | `class Outer { class Inner }` |
| **Приватный вложенный** | Видим только в пределах внешнего класса | `private class Helper` |
| **Статический вложенный** | Используется для утилит | `public static class Utils` |
