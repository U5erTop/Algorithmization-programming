# C# Задания: Делегаты, комбинированные делегаты, анонимные методы и лямбда выражения 

---

## Раздел 1: Делегаты 

Основные концепции делегатов как типов, ссылающихся на методы, создание и использование делегатов.

### Задания 1-25:

1. Создайте простой делегат для операции с двумя числами (int, int) -> int
2. Реализуйте делегат для метода, который выполняет арифметическую операцию
3. Создайте делегат для вывода сообщения с одним параметром string
4. Реализуйте делегат для проверки условия (predicate) - (T) -> bool
5. Создайте делегат типа Action для выполнения действия без возврата значения
6. Реализуйте делегат типа Func для преобразования значения
7. Создайте делегат для фильтрации коллекции чисел
8. Реализуйте делегат callback для асинхронной операции
9. Создайте делегат для сортировки объектов по различным критериям
10. Реализуйте делегат для обработки ошибок при выполнении операции
11. Создайте делегат для преобразования строки (string) -> string
12. Реализуйте делегат для поиска элемента в коллекции
13. Создайте делегат для валидации данных
14. Реализуйте делегат для форматирования объекта в строку
15. Создайте делегат типа Comparison для сравнения двух объектов
16. Реализуйте делегат для конвертации между типами
17. Создайте делегат для обработки элементов коллекции
18. Реализуйте делегат для выполнения математической функции
19. Создайте делегат для обхода графа или дерева
20. Реализуйте делегат для создания объектов (factory pattern)
21. Создайте делегат для кеширования результатов функции
22. Реализуйте делегат для логирования операций
23. Создайте делегат для таймера и отложенного выполнения
24. Реализуйте делегат для обработки пользовательского ввода
25. Создайте делегат для паттерна Observer

---

## Раздел 2: Комбинированные (групповые) делегаты 

Работа с многоадресными делегатами, операторы + и -, цепочки обработчиков.

### Задания 26-50:

26. Создайте делегат и используйте оператор + для добавления методов
27. Реализуйте цепочку вызовов методов через объединение делегатов
28. Создайте многоадресные делегаты (multicast) и продемонстрируйте вызов
29. Реализуйте делегат с методом подписки для нескольких обработчиков
30. Создайте делегат для логирования и отправки email одновременно
31. Реализуйте делегат с методом отписки (оператор -)
32. Создайте систему уведомлений на основе групповых делегатов
33. Реализуйте делегат для обработки событий в цепочке обработчиков
34. Создайте делегат для выполнения нескольких операций последовательно
35. Реализуйте делегат для вызова методов разных классов
36. Создайте делегат для логирования, сохранения и вывода данных
37. Реализуйте систему подписки на события с множественными слушателями
38. Создайте делегат для обработки исключений в цепочке вызовов
39. Реализуйте делегат с проверкой результата каждого метода
40. Создайте делегат для синхронизации нескольких операций
41. Реализуйте делегат для обработки асинхронных операций по очереди
42. Создайте делегат для вызова методов с условием
43. Реализуйте делегат для накопления результатов (reduce/fold)
44. Создайте делегат для логирования каждого шага вычисления
45. Реализуйте систему плагинов на основе групповых делегатов
46. Создайте делегат для выполнения валидации несколькими правилами
47. Реализуйте делегат для отправки уведомлений различными каналами
48. Создайте делегат для мониторинга производительности методов
49. Реализуйте делегат для кеширования результатов с логированием
50. Создайте делегат для обработки очереди задач

---

## Раздел 3: Анонимные методы 

Создание анонимных методов с использованием delegate{}, closure и работа с внешними переменными.

### Задания 51-75:

51. Создайте анонимный метод для простой операции (int, int) -> int
52. Реализуйте анонимный метод для фильтрации коллекции
53. Создайте анонимный метод для поиска элемента
54. Реализуйте анонимный метод с переменными внешней области видимости (closure)
55. Создайте анонимный метод для обработки события
56. Реализуйте анонимный метод для преобразования данных
57. Создайте анонимный метод для валидации значения
58. Реализуйте анонимный метод для отсортирования коллекции
59. Создайте анонимный метод для логирования операций
60. Реализуйте анонимный метод с параметром ref
61. Создайте анонимный метод для вычисления факториала
62. Реализуйте анонимный метод для работы со строками
63. Создайте анонимный метод для обработки исключений
64. Реализуйте анонимный метод для создания кешированного значения
65. Создайте анонимный метод для работы с файловой системой
66. Реализуйте анонимный метод для парсинга данных
67. Создайте анонимный метод для работы с базой данных
68. Реализуйте анонимный метод для асинхронных операций
69. Создайте анонимный метод для обхода коллекции
70. Реализуйте анонимный метод для группировки данных
71. Создайте анонимный метод для вычисления суммы элементов
72. Реализуйте анонимный метод для работы с датами
73. Создайте анонимный метод для шифрования данных
74. Реализуйте анонимный метод для вывода отчетов
75. Создайте анонимный метод для системы логирования

---

## Раздел 4: Лямбда операторы и лямбда выражения 

Lambda выражения, LINQ, expression trees, лямбда с несколькими параметрами.

### Задания 76-100:

76. Создайте лямбда выражение для простой математической операции x => x * 2
77. Реализуйте лямбда выражение для фильтрации списка (x => x > 5)
78. Создайте лямбда выражение для преобразования строк (s => s.ToUpper())
79. Реализуйте лямбда выражение для работы с LINQ (Where, Select, OrderBy)
80. Создайте лямбда выражение с несколькими параметрами (x, y) => x + y
81. Реализуйте лямбда выражение для фильтрации сложных объектов
82. Создайте лямбда выражение для группировки данных
83. Реализуйте лямбда выражение для проверки условия на элементах списка
84. Создайте лямбда выражение для поиска минимума и максимума
85. Реализуйте лямбда выражение для сортировки по нескольким критериям
86. Создайте лямбда выражение для работы с датами и временем
87. Реализуйте лямбда выражение для работы с вложенными коллекциями
88. Создайте лямбда выражение для преобразования типов
89. Реализуйте лямбда выражение для подсчета элементов
90. Создайте лямбда выражение для работы с enum значениями
91. Реализуйте лямбда выражение для создания словаря из коллекции
92. Создайте лямбда выражение для фильтрации с несколькими условиями
93. Реализуйте лямбда выражение для рекурсивных операций
94. Создайте лямбда выражение для работы с исключениями
95. Реализуйте лямбда выражение для параллельной обработки данных (PLINQ)
96. Создайте лямбда выражение для работы с Dictionary
97. Реализуйте лямбда выражение для LINQ to SQL
98. Создайте лямбда выражение для Anonymous types
99. Реализуйте лямбда выражение для работы с файлами
100. Создайте лямбда выражение для Expression trees

---


## Задание 5: Создайте делегат типа Action для выполнения действия без возврата значения

```csharp
using System;
using System.Collections.Generic;

namespace ActionDelegateDemo
{
    class Program
    {
        // Определяем пользовательские делегаты
        public delegate void MessagePrinter(string message);
        public delegate void NumberProcessor(int number);
        
        // Методы, соответствующие делегатам
        static void PrintMessage(string msg)
        {
            Console.WriteLine($"[INFO] {msg}");
        }
        
        static void LogMessage(string msg)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {msg}");
        }
        
        static void ProcessNumber(int num)
        {
            Console.WriteLine($"Число: {num}, Квадрат: {num * num}, Куб: {num * num * num}");
        }
        
        static void PrintToFile(int value)
        {
            Console.WriteLine($"Запись в файл: {value}");
        }
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 5: Action делегат ===\n");
            
            // 1. Использование встроенного Action<T>
            Console.WriteLine("--- Встроенный Action<string> ---");
            Action<string> printAction = Console.WriteLine;
            printAction("Hello от Action делегата");
            
            // 2. Использование Action с несколькими параметрами
            Console.WriteLine("\n--- Action с двумя параметрами ---");
            Action<string, int> displayInfo = (name, age) =>
            {
                Console.WriteLine($"Имя: {name}, Возраст: {age}");
            };
            displayInfo("Иван", 25);
            displayInfo("Мария", 30);
            
            // 3. Пользовательский делегат void
            Console.WriteLine("\n--- Пользовательский делегат MessagePrinter ---");
            MessagePrinter printer = PrintMessage;
            printer("Задача выполнена успешно");
            
            // 4. Многоадресный делегат Action
            Console.WriteLine("\n--- Многоадресный Action ---");
            Action<string> multiAction = PrintMessage;
            multiAction += LogMessage;
            multiAction("Работа с файлами");
            
            // 5. NumberProcessor делегат
            Console.WriteLine("\n--- NumberProcessor для разных операций ---");
            NumberProcessor processor = ProcessNumber;
            processor(5);
            processor += PrintToFile;
            processor(10);
            
            // 6. Работа с коллекциями через Action
            Console.WriteLine("\n--- ForEach с Action ---");
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.ForEach(name => Console.WriteLine($"  - {name}"));
            
            // 7. Action с условиями
            Console.WriteLine("\n--- Action с условиями ---");
            Action<int> conditionalAction = (num) =>
            {
                if (num % 2 == 0)
                    Console.WriteLine($"{num} - четное число");
                else
                    Console.WriteLine($"{num} - нечетное число");
            };
            conditionalAction(7);
            conditionalAction(12);
            
            // 8. Система уведомлений на основе Action
            Console.WriteLine("\n--- Система уведомлений ---");
            Action<string> notificationSystem = null;
            notificationSystem += msg => Console.WriteLine($"[EMAIL] Отправка письма: {msg}");
            notificationSystem += msg => Console.WriteLine($"[SMS] Отправка SMS: {msg}");
            notificationSystem += msg => Console.WriteLine($"[PUSH] Отправка пушнотификации: {msg}");
            
            notificationSystem("Важное сообщение");
        }
    }
}
```

---

## Задание 9: Создайте делегат для сортировки объектов по различным критериям

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingDelegateDemo
{
    class Program
    {
        // Определяем класс для работы
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double GPA { get; set; }
            
            public override string ToString()
            {
                return $"{Name,-15} Age: {Age,2}  GPA: {GPA:F2}";
            }
        }
        
        // Делегат для сравнения
        public delegate int StudentComparer(Student a, Student b);
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 9: Делегат для сортировки ===\n");
            
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 22, GPA = 3.8 },
                new Student { Name = "Bob", Age = 20, GPA = 3.5 },
                new Student { Name = "Charlie", Age = 23, GPA = 3.9 },
                new Student { Name = "Diana", Age = 21, GPA = 3.6 }
            };
            
            Console.WriteLine("Исходный список:");
            foreach (var student in students)
                Console.WriteLine(student);
            
            // 1. Сортировка по имени
            Console.WriteLine("\n--- Сортировка по имени (A-Z) ---");
            StudentComparer byName = (a, b) => a.Name.CompareTo(b.Name);
            List<Student> sortedByName = students.OrderBy(s => s, Comparer<Student>.Create(byName)).ToList();
            foreach (var student in sortedByName)
                Console.WriteLine(student);
            
            // 2. Сортировка по возрасту (по возрастанию)
            Console.WriteLine("\n--- Сортировка по возрасту (возрастание) ---");
            StudentComparer byAge = (a, b) => a.Age.CompareTo(b.Age);
            List<Student> sortedByAge = students.OrderBy(s => s, Comparer<Student>.Create(byAge)).ToList();
            foreach (var student in sortedByAge)
                Console.WriteLine(student);
            
            // 3. Сортировка по GPA (по убыванию)
            Console.WriteLine("\n--- Сортировка по GPA (убывание) ---");
            StudentComparer byGPADesc = (a, b) => b.GPA.CompareTo(a.GPA);
            List<Student> sortedByGPADesc = students.OrderBy(s => s, Comparer<Student>.Create(byGPADesc)).ToList();
            foreach (var student in sortedByGPADesc)
                Console.WriteLine(student);
            
            // 4. Использование IComparer с делегатом
            Console.WriteLine("\n--- Встроенный Comparison<T> ---");
            List<Student> studentsCopy = new List<Student>(students);
            
            // Sort по возрасту (встроенный Comparison)
            Comparison<Student> comparisonByAge = (a, b) => a.Age.CompareTo(b.Age);
            studentsCopy.Sort(comparisonByAge);
            
            Console.WriteLine("После сортировки по возрасту:");
            foreach (var student in studentsCopy)
                Console.WriteLine(student);
            
            // 5. Сложная сортировка - по GPA, потом по имени
            Console.WriteLine("\n--- Сложная сортировка (GPA DESC, затем Name ASC) ---");
            var complexSort = students
                .OrderByDescending(s => s.GPA)
                .ThenBy(s => s.Name)
                .ToList();
            
            foreach (var student in complexSort)
                Console.WriteLine(student);
            
            // 6. Сортировка через Sort() с делегатом
            Console.WriteLine("\n--- Sort() с делегатом ---");
            List<Student> studentsToSort = new List<Student>(students);
            studentsToSort.Sort((a, b) =>
            {
                // Сначала по GPA (убывание), потом по имени (возрастание)
                int gpaCompare = b.GPA.CompareTo(a.GPA);
                if (gpaCompare != 0)
                    return gpaCompare;
                return a.Name.CompareTo(b.Name);
            });
            
            foreach (var student in studentsToSort)
                Console.WriteLine(student);
        }
    }
}
```

---

## Задание 31: Реализуйте делегат с методом отписки (оператор -)

```csharp
using System;
using System.Collections.Generic;

namespace UnsubscribeDelegateDemo
{
    class Program
    {
        public delegate void EventNotification(string message);
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 31: Отписка от делегата (оператор -) ===\n");
            
            // Определяем методы-обработчики
            EventNotification notification = null;
            
            // Метод 1: Логирование
            void LogEvent(string msg) => Console.WriteLine($"[LOG] {DateTime.Now}: {msg}");
            
            // Метод 2: Отправка email
            void SendEmail(string msg) => Console.WriteLine($"[EMAIL] Отправка: {msg}");
            
            // Метод 3: Сохранение в файл
            void SaveToFile(string msg) => Console.WriteLine($"[FILE] Сохранение: {msg}");
            
            // Метод 4: Уведомление пользователя
            void NotifyUser(string msg) => Console.WriteLine($"[ALERT] {msg}");
            
            // 1. Подписываемся на события
            Console.WriteLine("--- Подписка на события ---");
            notification += LogEvent;
            notification += SendEmail;
            notification += SaveToFile;
            notification += NotifyUser;
            
            Console.WriteLine($"Количество подписчиков: {notification.GetInvocationList().Length}\n");
            notification("Система готова к работе");
            
            // 2. Отписываемся от одного обработчика
            Console.WriteLine("\n--- Отписка от SendEmail ---");
            notification -= SendEmail;
            Console.WriteLine($"Количество подписчиков: {notification.GetInvocationList().Length}\n");
            notification("Событие после отписки от Email");
            
            // 3. Отписываемся от другого обработчика
            Console.WriteLine("\n--- Отписка от SaveToFile ---");
            notification -= SaveToFile;
            Console.WriteLine($"Количество подписчиков: {notification.GetInvocationList().Length}\n");
            notification("Еще одно событие");
            
            // 4. Отписываемся от всех обработчиков
            Console.WriteLine("\n--- Полная отписка (обнуление делегата) ---");
            notification = null;
            Console.WriteLine("Делегат обнулен\n");
            
            // 5. Практический пример: система подписки
            Console.WriteLine("--- Практический пример: система подписки ---\n");
            
            var logger = new EventLogger();
            var emailService = new EmailService();
            var alertSystem = new AlertSystem();
            
            EventNotification systemNotification = null;
            systemNotification += logger.Log;
            systemNotification += emailService.SendEmail;
            systemNotification += alertSystem.Alert;
            
            Console.WriteLine("Все сервисы подписаны\n");
            systemNotification("Критическая ошибка в системе");
            
            // Отписываем Email сервис
            Console.WriteLine("\n--- Отписка Email сервиса ---");
            systemNotification -= emailService.SendEmail;
            systemNotification("Предупреждение");
            
            // 6. Проверка подписки перед вызовом
            Console.WriteLine("\n--- Безопасный вызов делегата ---");
            if (systemNotification != null)
            {
                systemNotification("Еще одно сообщение");
            }
            else
            {
                Console.WriteLine("Нет подписчиков, делегат пуст");
            }
            
            // 7. Удаление всех обработчиков
            Console.WriteLine("\n--- Удаление всех подписок ---");
            systemNotification -= logger.Log;
            systemNotification -= alertSystem.Alert;
            
            Console.WriteLine($"Остаток подписчиков: {systemNotification?.GetInvocationList().Length ?? 0}");
        }
    }
    
    // Классы для демонстрации
    class EventLogger
    {
        public void Log(string message) => Console.WriteLine($"[LOG] {message}");
    }
    
    class EmailService
    {
        public void SendEmail(string message) => Console.WriteLine($"[EMAIL] Отправка: {message}");
    }
    
    class AlertSystem
    {
        public void Alert(string message) => Console.WriteLine($"[ALERT] ⚠️ {message}");
    }
}
```

---

## Задание 33: Реализуйте делегат для обработки событий в цепочке обработчиков

```csharp
using System;
using System.Collections.Generic;

namespace EventChainDemo
{
    class Program
    {
        // Делегат для обработки событий
        public delegate void EventHandler(Event evt);
        
        // Класс для представления события
        public class Event
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Timestamp { get; set; }
            public EventPriority Priority { get; set; }
            public List<string> Log { get; set; }
            
            public Event(string name, string description, EventPriority priority)
            {
                Name = name;
                Description = description;
                Priority = priority;
                Timestamp = DateTime.Now;
                Log = new List<string>();
            }
            
            public override string ToString()
            {
                return $"[{Priority}] {Name}: {Description}";
            }
        }
        
        public enum EventPriority { Low, Medium, High, Critical }
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 33: Цепочка обработчиков событий ===\n");
            
            // Создаем цепочку обработчиков
            EventHandler chain = null;
            
            // Обработчик 1: Логирование
            chain += (evt) =>
            {
                evt.Log.Add($"[1. LOGGER] Событие: {evt.Name}");
                Console.WriteLine($"✓ Логирование: {evt.Name}");
            };
            
            // Обработчик 2: Проверка приоритета
            chain += (evt) =>
            {
                evt.Log.Add($"[2. PRIORITY CHECK] Приоритет: {evt.Priority}");
                Console.WriteLine($"✓ Проверка приоритета: {evt.Priority}");
            };
            
            // Обработчик 3: Отправка уведомления
            chain += (evt) =>
            {
                evt.Log.Add($"[3. NOTIFIER] Отправка уведомления");
                Console.WriteLine($"✓ Уведомление отправлено");
            };
            
            // Обработчик 4: Сохранение в хранилище
            chain += (evt) =>
            {
                evt.Log.Add($"[4. STORAGE] Сохранение события");
                Console.WriteLine($"✓ Событие сохранено");
            };
            
            // Обработчик 5: Аналитика
            chain += (evt) =>
            {
                evt.Log.Add($"[5. ANALYTICS] Анализ события");
                Console.WriteLine($"✓ Анализ завершен");
            };
            
            // Создаем и обрабатываем события
            Console.WriteLine("--- Обработка события с приоритетом High ---\n");
            var highPriorityEvent = new Event("UserLogin", "Пользователь вошел в систему", EventPriority.High);
            chain(highPriorityEvent);
            
            Console.WriteLine("\n--- Лог обработки ---");
            foreach (var logEntry in highPriorityEvent.Log)
                Console.WriteLine(logEntry);
            
            // Другое событие
            Console.WriteLine("\n\n--- Обработка события с приоритетом Critical ---\n");
            var criticalEvent = new Event("SecurityBreach", "Обнаружена попытка взлома", EventPriority.Critical);
            chain(criticalEvent);
            
            Console.WriteLine("\n--- Лог обработки ---");
            foreach (var logEntry in criticalEvent.Log)
                Console.WriteLine(logEntry);
            
            // Пример: условная цепочка
            Console.WriteLine("\n\n--- Условная цепочка обработчиков ---\n");
            
            EventHandler conditionalChain = (evt) =>
            {
                // Этап 1: Проверка
                if (evt.Priority >= EventPriority.High)
                {
                    Console.WriteLine("$1 ALERT: Высокий приоритет!");
                    evt.Log.Add("[ALERT] Высокий приоритет");
                }
            };
            
            conditionalChain += (evt) =>
            {
                // Этап 2: Логирование
                Console.WriteLine($"2 LOG: {evt.Description}");
                evt.Log.Add("[LOG] " + evt.Description);
            };
            
            conditionalChain += (evt) =>
            {
                // Этап 3: Отправка администратору
                if (evt.Priority == EventPriority.Critical)
                {
                    Console.WriteLine("3 ADMIN NOTIFY: Отправка администратору");
                    evt.Log.Add("[ADMIN] Уведомление отправлено администратору");
                }
            };
            
            var criticalEvent2 = new Event("SystemError", "Критическая ошибка системы", EventPriority.Critical);
            conditionalChain(criticalEvent2);
            
            Console.WriteLine("\n--- Итоговый лог ---");
            foreach (var logEntry in criticalEvent2.Log)
                Console.WriteLine(logEntry);
        }
    }
}
```

---

## Задание 83: Реализуйте лямбда выражение для проверки условия на элементах списка

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaConditionDemo
{
    class Program
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
            public string Category { get; set; }
            
            public override string ToString()
            {
                return $"#{Id} {Name,-25} Price: ${Price,7:F2}  Stock: {StockQuantity,3}  Category: {Category}";
            }
        }
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 83: Лямбда выражения для проверки условий ===\n");
            
            // Инициализируем данные
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Ноутбук", Price = 1200.00m, StockQuantity = 5, Category = "Electronics" },
                new Product { Id = 2, Name = "Мышка", Price = 25.00m, StockQuantity = 50, Category = "Electronics" },
                new Product { Id = 3, Name = "Клавиатура", Price = 75.00m, StockQuantity = 30, Category = "Electronics" },
                new Product { Id = 4, Name = "Монитор", Price = 400.00m, StockQuantity = 10, Category = "Electronics" },
                new Product { Id = 5, Name = "Книга", Price = 15.00m, StockQuantity = 100, Category = "Books" },
                new Product { Id = 6, Name = "Наушники", Price = 80.00m, StockQuantity = 0, Category = "Electronics" },
                new Product { Id = 7, Name = "USB кабель", Price = 5.00m, StockQuantity = 200, Category = "Accessories" },
                new Product { Id = 8, Name = "Веб-камера", Price = 60.00m, StockQuantity = 15, Category = "Electronics" }
            };
            
            // 1. Простое условие: цена больше 50
            Console.WriteLine("--- 1. Товары дороже $50 ---");
            var expensiveProducts = products.Where(p => p.Price > 50);
            foreach (var product in expensiveProducts)
                Console.WriteLine(product);
            
            // 2. Условие: товар в наличии (StockQuantity > 0)
            Console.WriteLine("\n--- 2. Товары в наличии ---");
            var inStock = products.Where(p => p.StockQuantity > 0);
            foreach (var product in inStock)
                Console.WriteLine(product);
            
            // 3. Логическое И: категория "Electronics" И цена < 100
            Console.WriteLine("\n--- 3. Электроника дешевле $100 ---");
            var cheapElectronics = products.Where(p => p.Category == "Electronics" && p.Price < 100);
            foreach (var product in cheapElectronics)
                Console.WriteLine(product);
            
            // 4. Логическое ИЛИ: либо дешево, либо много в наличии
            Console.WriteLine("\n--- 4. Либо дешево, либо много на складе ---");
            var cheapOrPlenty = products.Where(p => p.Price < 30 || p.StockQuantity > 50);
            foreach (var product in cheapOrPlenty)
                Console.WriteLine(product);
            
            // 5. НЕ (отрицание): товары НЕ категории "Books"
            Console.WriteLine("\n--- 5. Товары НЕ из категории 'Books' ---");
            var notBooks = products.Where(p => p.Category != "Books");
            foreach (var product in notBooks)
                Console.WriteLine(product);
            
            // 6. Сложное условие: в наличии И (дешево ИЛИ электроника)
            Console.WriteLine("\n--- 6. В наличии И (цена < 30 ИЛИ Electronics) ---");
            var complex = products.Where(p => 
                p.StockQuantity > 0 && 
                (p.Price < 30 || p.Category == "Electronics")
            );
            foreach (var product in complex)
                Console.WriteLine(product);
            
            // 7. Проверка содержания строки
            Console.WriteLine("\n--- 7. Название содержит 'кабель' ---");
            var nameContains = products.Where(p => p.Name.Contains("кабель", StringComparison.OrdinalIgnoreCase));
            foreach (var product in nameContains)
                Console.WriteLine(product);
            
            // 8. Проверка диапазона: цена между 50 и 200
            Console.WriteLine("\n--- 8. Цена между $50 и $200 ---");
            var priceRange = products.Where(p => p.Price >= 50 && p.Price <= 200);
            foreach (var product in priceRange)
                Console.WriteLine(product);
            
            // 9. All() - все товары соответствуют условию
            Console.WriteLine("\n--- 9. Все ли товары стоят менее $2000? ---");
            bool allCheap = products.All(p => p.Price < 2000);
            Console.WriteLine($"Результат: {allCheap}");
            
            // 10. Any() - хотя бы один товар соответствует условию
            Console.WriteLine("\n--- 10. Есть ли товары, которых нет в наличии? ---");
            bool hasOutOfStock = products.Any(p => p.StockQuantity == 0);
            Console.WriteLine($"Результат: {hasOutOfStock}");
            Console.WriteLine($"Без наличия: {products.First(p => p.StockQuantity == 0).Name}");
            
            // 11. First() с условием
            Console.WriteLine("\n--- 11. Первый товар категории 'Electronics' ---");
            var firstElectronics = products.FirstOrDefault(p => p.Category == "Electronics");
            Console.WriteLine($"Результат: {firstElectronics}");
            
            // 12. Count() с условием
            Console.WriteLine("\n--- 12. Сколько товаров электроники? ---");
            int electronicsCount = products.Count(p => p.Category == "Electronics");
            Console.WriteLine($"Товаров электроники: {electronicsCount}");
            
            // 13. Sum() с условием
            Console.WriteLine("\n--- 13. Общая стоимость товаров со скидкой (price < 100) ---");
            decimal totalCheap = products.Where(p => p.Price < 100).Sum(p => p.Price);
            Console.WriteLine($"Общая стоимость: ${totalCheap:F2}");
            
            // 14. Max/Min с условием
            Console.WriteLine("\n--- 14. Самый дорогой товар электроники ---");
            var mostExpensiveElectronics = products
                .Where(p => p.Category == "Electronics")
                .MaxBy(p => p.Price);
            Console.WriteLine($"Результат: {mostExpensiveElectronics}");
            
            // 15. GroupBy с условием
            Console.WriteLine("\n--- 15. Товары, сгруппированные по категориям ---");
            var groupedByCategory = products
                .Where(p => p.StockQuantity > 0)
                .GroupBy(p => p.Category);
            
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"\n{group.Key}:");
                foreach (var product in group)
                    Console.WriteLine($"  {product.Name}");
            }
        }
    }
}
```

---

## 📋 Рекомендации по выполнению

### Делегаты
- Используйте встроенные типы `Action<T>` и `Func<T, TResult>` вместо собственных делегатов где возможно
- Понимайте разницу между делегатом и методом - делегат это тип, метод это реализация
- Всегда проверяйте делегат на null перед вызовом

### Комбинированные делегаты
- Операторы `+` и `-` используются для подписки и отписки
- `GetInvocationList()` показывает все подписанные методы
- Порядок вызова методов соответствует порядку подписки

### Анонимные методы
- Используйте `delegate { }` синтаксис для создания анонимных методов
- Анонимные методы могут захватывать переменные из внешней области видимости (closure)
- Предпочитайте лямбда выражения перед анонимными методами (более современно)

### Лямбда выражения
- `x => x * 2` для одного параметра и одной строки
- `(x, y) => x + y` для нескольких параметров
- `{ }` для нескольких строк кода
- Лямбда выражения преобразуются компилятором в делегаты
- LINQ часто использует лямбда выражения для фильтрации и преобразования

---
