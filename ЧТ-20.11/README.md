# C# Задания: Ограничения параметризированных типов и коллекции (100 заданий + решения)

---

## Раздел 1: Ограничения параметризированных типов 
Использование ограничений where для generic классов и методов.

### Задания 1-50:

1. Создайте generic класс с ограничением where T : class
2. Реализуйте generic класс с ограничением where T : struct
3. Создайте generic метод с ограничением where T : new()
4. Реализуйте generic класс с ограничением where T : IComparable
5. Создайте generic метод с ограничением where T : IEnumerable
6. Реализуйте generic класс с ограничением где один тип наследует другой
7. Создайте generic метод с несколькими ограничениями where T : class, IDisposable
8. Реализуйте generic интерфейс с ограничением where T : IEquatable<T>
9. Создайте generic класс Repository<T> где T : class, new()
10. Реализуйте generic метод для сравнения where T : IComparable<T>
11. Создайте generic класс с ограничением на конкретный тип
12. Реализуйте generic метод Clone<T> где T : class, ICloneable
13. Создайте generic класс для работы с коллекциями где T : ICollection
14. Реализуйте generic метод для поиска где T : IEquatable<T>
15. Создайте generic класс Serializer<T> где T : class, new()
16. Реализуйте generic метод для валидации where T : IValidatable
17. Создайте generic класс Parser<T> с ограничениями на парсинг
18. Реализуйте generic интерфейс Factory<T> где T : class, new()
19. Создайте generic класс для кеша где T : class
20. Реализуйте generic метод для сортировки где T : IComparable<T>
21. Создайте generic класс Observer<T> где T : class
22. Реализуйте generic метод для обхода дерева где T : ITreeNode
23. Создайте generic класс Graph<T> где T : class, IEquatable<T>
24. Реализуйте generic метод для мэпирования типов
25. Создайте generic класс для работы с событиями где T : EventArgs
26. Реализуйте generic метод Sum<T> где T : struct, IComparable
27. Создайте generic класс Comparer<T> где T : IComparable
28. Реализуйте generic интерфейс с множественными ограничениями
29. Создайте generic метод для преобразования типов с ограничениями
30. Реализуйте generic класс для работы с базой данных где T : EntityBase
31. Создайте generic класс Validator<T> с ограничением на interface
32. Реализуйте generic метод для создания объекта где T : class, new()
33. Создайте generic класс для кеширования с ограничением на тип ключа
34. Реализуйте generic метод для сериализации где T : class, ISerializable
35. Создайте generic класс Pipeline<T> где T : class
36. Реализуйте generic метод для фильтрации где T : IFilterable
37. Создайте generic класс для работы с конвертером типов
38. Реализуйте generic интерфейс Mapper<TSource, TDestination>
39. Создайте generic класс для логирования где T : class
40. Реализуйте generic метод для работы с опциональными типами
41. Создайте generic класс Command<T> для паттерна Command
42. Реализуйте generic метод для асинхронных операций
43. Создайте generic класс для работы с результатом где T : class
44. Реализуйте generic интерфейс Provider<T> с ограничениями
45. Создайте generic класс для работы с конфигурацией
46. Реализуйте generic метод FindMin<T> где T : IComparable<T>
47. Создайте generic класс для работы с очередью где T : class
48. Реализуйте generic метод Distinct<T> где T : IEquatable<T>
49. Создайте generic класс для работы со стеком где T : class
50. Реализуйте generic метод для агрегации данных с ограничениями

---

## Раздел 2: Параметризированные коллекции 

Работа с List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T> и другими generic коллекциями.

### Задания 51-100:

51. Создайте List<int> и выполните основные операции
52. Реализуйте работу с List<string> и методами Find, FindAll
53. Создайте Dictionary<string, int> для подсчета элементов
54. Реализуйте List<T> для пользовательского класса
55. Создайте Dictionary<int, List<string>> для группировки данных
56. Реализуйте работу с List<T> методами Sort, Reverse, BinarySearch
57. Создайте Dictionary<string, decimal> для хранения цен
58. Реализуйте Dictionary<TKey, TValue> с пользовательским классом в качестве значения
59. Создайте List<Tuple<int, string>> для хранения пар данных
60. Реализуйте SortedDictionary<string, int> для автоматической сортировки
61. Создайте Dictionary<int, HashSet<string>> для работы с уникальными значениями
62. Реализуйте List<T> с использованием LINQ методов
63. Создайте Dictionary<string, object> для динамических данных
64. Реализуйте Queue<T> и Stack<T> для работы с очередями
65. Создайте List<T> с фильтрацией и преобразованием
66. Реализуйте Dictionary<TKey, TValue> с проверкой наличия ключа
67. Создайте SortedList<TKey, TValue> для сортировки по ключам
68. Реализуйте List<T> для работы с событиями и уведомлениями
69. Создайте Dictionary<string, List<T>> для многоуровневого хранилища
70. Реализуйте LinkedList<T> для связного списка
71. Создайте List<T> с использованием Contains, IndexOf, LastIndexOf
72. Реализуйте Dictionary<int, string> для маппирования значений
73. Создайте List<T> с добавлением и удалением элементов
74. Реализуйте Dictionary<string, int> для счетчика частоты
75. Создайте List<KeyValuePair<TKey, TValue>> для работы с парами
76. Реализуйте Dictionary<TKey, TValue> с итерацией и фильтрацией
77. Создайте List<T> для кеширования результатов
78. Реализуйте Dictionary<int, object> для полиморфных коллекций
79. Создайте List<T> с использованием RemoveAll и RemoveRange
80. Реализуйте Dictionary<string, Dictionary<string, int>> для многомерных данных
81. Создайте List<T> с сортировкой по пользовательскому компаратору
82. Реализуйте Dictionary<string, List<int>> для группировки по категориям
83. Создайте List<T> с методами CopyTo, GetRange, InsertRange
84. Реализуйте Dictionary<TKey, HashSet<TValue>> для уникальных коллекций
85. Создайте List<T> для работы с индексами и срезами
86. Реализуйте Dictionary<string, T> для типизированного хранилища
87. Создайте List<Nullable<T>> для работы с опциональными значениями
88. Реализуйте Dictionary<int, string> с методом TryGetValue
89. Создайте List<T> с использованием Capacity и Count
90. Реализуйте Dictionary<string, decimal> для финансовых данных
91. Создайте List<T> для реализации кастомной коллекции
92. Реализуйте Dictionary<int, List<KeyValuePair<string, object>>>
93. Создайте List<T> с использованием AddRange и InsertRange
94. Реализуйте Dictionary<string, object> для JSON-подобных структур
95. Создайте List<T> с использованием IndexOf и Contains
96. Реализуйте Dictionary<TKey, TValue> с очисткой и проверкой
97. Создайте List<Enum> для работы с перечислениями
98. Реализуйте Dictionary<string, Func<int, int>> для функций
99. Создайте List<T> для реализации паттерна Observer
100. Реализуйте Dictionary<DateTime, string> для логирования событий

---

## Задание 5: Создайте generic метод с ограничением where T : IEnumerable

```csharp
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericConstraintsDemo
{
    class Program
    {
        // Generic метод с ограничением where T : IEnumerable
        static void PrintCollection<T>(T collection) where T : IEnumerable
        {
            Console.WriteLine("Содержимое коллекции:");
            int count = 0;
            foreach (var item in collection)
            {
                Console.WriteLine($"  [{count++}] {item}");
            }
        }
        
        // Метод для подсчета элементов
        static int CountItems<T>(T collection) where T : IEnumerable
        {
            int count = 0;
            foreach (var item in collection)
                count++;
            return count;
        }
        
        // Метод для поиска элемента
        static bool Contains<T>(T collection, object item) where T : IEnumerable
        {
            foreach (var element in collection)
            {
                if (element?.Equals(item) ?? false)
                    return true;
            }
            return false;
        }
        
        // Обобщенный метод для преобразования
        static List<object> ToObjectList<T>(T collection) where T : IEnumerable
        {
            var result = new List<object>();
            foreach (var item in collection)
                result.Add(item);
            return result;
        }
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 5: where T : IEnumerable ===\n");
            
            // 1. Работа со List<int>
            Console.WriteLine("--- List<int> ---");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            PrintCollection(numbers);
            Console.WriteLine($"Количество элементов: {CountItems(numbers)}");
            Console.WriteLine($"Содержит 3: {Contains(numbers, 3)}\n");
            
            // 2. Работа со массивом
            Console.WriteLine("--- int[] ---");
            int[] arr = { 10, 20, 30, 40, 50 };
            PrintCollection(arr);
            Console.WriteLine($"Количество элементов: {CountItems(arr)}\n");
            
            // 3. Работа со строками (string реализует IEnumerable)
            Console.WriteLine("--- string (IEnumerable<char>) ---");
            string text = "Hello";
            PrintCollection(text);
            Console.WriteLine($"Количество символов: {CountItems(text)}\n");
            
            // 4. Работа с Dictionary
            Console.WriteLine("--- Dictionary<string, int> ---");
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "Apple", 5 },
                { "Banana", 3 },
                { "Cherry", 8 }
            };
            PrintCollection(dict);
            Console.WriteLine($"Количество элементов: {CountItems(dict)}\n");
            
            // 5. Работа с HashSet
            Console.WriteLine("--- HashSet<string> ---");
            HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie" };
            PrintCollection(names);
            Console.WriteLine($"Содержит 'Bob': {Contains(names, "Bob")}\n");
            
            // 6. Работа с очередью
            Console.WriteLine("--- Queue<double> ---");
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(1.5);
            queue.Enqueue(2.7);
            queue.Enqueue(3.14);
            PrintCollection(queue);
            
            // 7. Преобразование в список объектов
            Console.WriteLine("\n--- Преобразование в List<object> ---");
            var mixed = new List<object> { 1, "two", 3.0, true };
            var objectList = ToObjectList(mixed);
            Console.WriteLine("Преобразованный список:");
            foreach (var obj in objectList)
                Console.WriteLine($"  {obj} ({obj.GetType().Name})");
        }
    }
}
```

---

## Задание 9: Создайте generic класс Repository<T> где T : class, new()

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryDemo
{
    // Интерфейс сущности
    interface IEntity
    {
        int Id { get; set; }
    }
    
    // Generic Repository с ограничениями
    class Repository<T> where T : class, new()
    {
        private List<T> _data = new List<T>();
        private int _nextId = 1;
        
        // Добавление элемента
        public void Add(T item)
        {
            dynamic d = item;
            d.Id = _nextId++;
            _data.Add(item);
            Console.WriteLine($"✓ Добавлен: {item}");
        }
        
        // Получение всех элементов
        public IEnumerable<T> GetAll() => _data;
        
        // Получение по ID
        public T GetById(int id)
        {
            return _data.FirstOrDefault(x => ((dynamic)x).Id == id);
        }
        
        // Удаление элемента
        public bool Remove(T item)
        {
            bool removed = _data.Remove(item);
            if (removed) Console.WriteLine($"✓ Удален: {item}");
            return removed;
        }
        
        // Обновление элемента
        public void Update(T item)
        {
            var index = _data.FindIndex(x => ((dynamic)x).Id == ((dynamic)item).Id);
            if (index >= 0)
            {
                _data[index] = item;
                Console.WriteLine($"✓ Обновлен: {item}");
            }
        }
        
        // Получение количества элементов
        public int Count => _data.Count;
        
        // Очистка репозитория
        public void Clear()
        {
            _data.Clear();
            Console.WriteLine("✓ Репозиторий очищен");
        }
        
        // Метод для создания нового экземпляра (использует new())
        public T CreateNew()
        {
            return new T();
        }
    }
    
    // Пользовательские классы
    class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public override string ToString() => $"User #{Id}: {Name} ({Email})";
    }
    
    class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        
        public override string ToString() => $"Product #{Id}: {Name} - ${Price:F2} (Stock: {StockQuantity})";
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 9: Repository<T> с ограничениями ===\n");
            
            // 1. User Repository
            Console.WriteLine("--- User Repository ---");
            var userRepo = new Repository<User>();
            
            userRepo.Add(new User { Name = "Alice", Email = "alice@example.com" });
            userRepo.Add(new User { Name = "Bob", Email = "bob@example.com" });
            userRepo.Add(new User { Name = "Charlie", Email = "charlie@example.com" });
            
            Console.WriteLine($"\nВсего пользователей: {userRepo.Count}");
            Console.WriteLine("Все пользователи:");
            foreach (var user in userRepo.GetAll())
                Console.WriteLine($"  {user}");
            
            // Получение по ID
            Console.WriteLine($"\nПользователь с ID 2: {userRepo.GetById(2)}");
            
            // 2. Product Repository
            Console.WriteLine("\n--- Product Repository ---");
            var productRepo = new Repository<Product>();
            
            productRepo.Add(new Product { Name = "Ноутбук", Price = 1200.00m, StockQuantity = 5 });
            productRepo.Add(new Product { Name = "Мышка", Price = 25.00m, StockQuantity = 50 });
            productRepo.Add(new Product { Name = "Клавиатура", Price = 75.00m, StockQuantity = 30 });
            
            Console.WriteLine($"\nВсего товаров: {productRepo.Count}");
            Console.WriteLine("Все товары:");
            foreach (var product in productRepo.GetAll())
                Console.WriteLine($"  {product}");
            
            // 3. Обновление
            Console.WriteLine("\n--- Операции обновления ---");
            var user1 = userRepo.GetById(1);
            user1.Email = "alice.new@example.com";
            userRepo.Update(user1);
            
            // 4. Создание нового экземпляра через ограничение new()
            Console.WriteLine("\n--- Создание новых экземпляров ---");
            var newUser = userRepo.CreateNew();
            Console.WriteLine($"Новый пользователь создан (ID: {newUser.Id}, Name: {newUser.Name ?? "null"})");
            
            var newProduct = productRepo.CreateNew();
            Console.WriteLine($"Новый товар создан (ID: {newProduct.Id}, Name: {newProduct.Name ?? "null"})");
            
            // 5. Удаление
            Console.WriteLine("\n--- Удаление элементов ---");
            var bobUser = userRepo.GetById(2);
            userRepo.Remove(bobUser);
            Console.WriteLine($"Осталось пользователей: {userRepo.Count}");
        }
    }
}
```

---

## Задание 31: Создайте generic класс Validator<T> с ограничением на interface

```csharp
using System;
using System.Collections.Generic;

namespace ValidatorDemo
{
    // Интерфейс для валидируемых объектов
    interface IValidatable
    {
        bool IsValid();
        string GetValidationMessage();
    }
    
    // Generic Validator с ограничением
    class Validator<T> where T : IValidatable
    {
        private List<T> _validItems = new List<T>();
        private List<T> _invalidItems = new List<T>();
        private List<string> _validationLog = new List<string>();
        
        // Валидация элемента
        public bool Validate(T item)
        {
            bool isValid = item.IsValid();
            
            if (isValid)
                _validItems.Add(item);
            else
                _invalidItems.Add(item);
            
            string message = $"[{(isValid ? "✓" : "✗")}] {item.GetValidationMessage()}";
            _validationLog.Add(message);
            
            return isValid;
        }
        
        // Валидация коллекции
        public int ValidateCollection(IEnumerable<T> items)
        {
            int validCount = 0;
            foreach (var item in items)
            {
                if (Validate(item))
                    validCount++;
            }
            return validCount;
        }
        
        // Получение результатов
        public void PrintReport()
        {
            Console.WriteLine("=== Отчет валидации ===");
            Console.WriteLine($"Валидных: {_validItems.Count}");
            Console.WriteLine($"Невалидных: {_invalidItems.Count}");
            
            Console.WriteLine("\nДетали:");
            foreach (var log in _validationLog)
                Console.WriteLine(log);
        }
        
        public List<T> GetValidItems() => _validItems;
        public List<T> GetInvalidItems() => _invalidItems;
    }
    
    // Классы для демонстрации
    class User : IValidatable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public bool IsValid() => !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email);
        
        public string GetValidationMessage()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return "User: Name is required";
            if (string.IsNullOrWhiteSpace(Email))
                return "User: Email is required";
            return $"User: {Name} ({Email}) is valid";
        }
        
        public override string ToString() => $"User: {Name} - {Email}";
    }
    
    class Product : IValidatable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public bool IsValid() => !string.IsNullOrWhiteSpace(Name) && Price > 0;
        
        public string GetValidationMessage()
        {
            if (string.IsNullOrWhiteSpace(Name))
                return "Product: Name is required";
            if (Price <= 0)
                return "Product: Price must be greater than 0";
            return $"Product: {Name} (${Price:F2}) is valid";
        }
        
        public override string ToString() => $"Product: {Name} - ${Price:F2}";
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 31: Generic Validator<T> ===\n");
            
            // 1. Валидация пользователей
            Console.WriteLine("--- User Validator ---");
            var userValidator = new Validator<User>();
            
            var users = new List<User>
            {
                new User { Name = "Alice", Email = "alice@example.com" },
                new User { Name = "Bob", Email = null },
                new User { Name = null, Email = "charlie@example.com" },
                new User { Name = "Diana", Email = "diana@example.com" }
            };
            
            int validUsers = userValidator.ValidateCollection(users);
            Console.WriteLine($"\nВалидных пользователей: {validUsers} из {users.Count}");
            userValidator.PrintReport();
            
            // 2. Валидация продуктов
            Console.WriteLine("\n\n--- Product Validator ---");
            var productValidator = new Validator<Product>();
            
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200 },
                new Product { Name = "Mouse", Price = 25 },
                new Product { Name = null, Price = 100 },
                new Product { Name = "Keyboard", Price = -50 },
                new Product { Name = "Monitor", Price = 400 }
            };
            
            int validProducts = productValidator.ValidateCollection(products);
            Console.WriteLine($"\nВалидных товаров: {validProducts} из {products.Count}");
            productValidator.PrintReport();
            
            // 3. Работа с результатами
            Console.WriteLine("\n\n--- Валидные товары ---");
            foreach (var product in productValidator.GetValidItems())
                Console.WriteLine($"  {product}");
            
            Console.WriteLine("\nНевалидные товары");
            foreach (var product in productValidator.GetInvalidItems())
                Console.WriteLine($"  {product}");
        }
    }
}
```

---

## Задание 33: Создайте generic класс для кеширования с ограничением на тип ключа

```csharp
using System;
using System.Collections.Generic;

namespace CacheDemo
{
    // Generic Cache с ограничением на ключ
    class Cache<TKey, TValue> where TKey : notnull where TValue : class
    {
        private Dictionary<TKey, CacheEntry> _cache = new Dictionary<TKey, CacheEntry>();
        private Dictionary<TKey, int> _accessCount = new Dictionary<TKey, int>();
        
        private class CacheEntry
        {
            public TValue Value { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime LastAccessedAt { get; set; }
            public int AccessCount { get; set; }
        }
        
        // Получить значение из кеша
        public TValue Get(TKey key)
        {
            if (_cache.TryGetValue(key, out var entry))
            {
                entry.LastAccessedAt = DateTime.Now;
                entry.AccessCount++;
                Console.WriteLine($"  Cache HIT for key: {key} (Access #{entry.AccessCount})");
                return entry.Value;
            }
            Console.WriteLine($"  Cache MISS for key: {key}");
            return null;
        }
        
        // Добавить значение в кеш
        public void Set(TKey key, TValue value, bool replace = false)
        {
            if (_cache.ContainsKey(key) && !replace)
            {
                Console.WriteLine($"  Key {key} already exists. Use replace=true to overwrite");
                return;
            }
            
            _cache[key] = new CacheEntry
            {
                Value = value,
                CreatedAt = DateTime.Now,
                LastAccessedAt = DateTime.Now,
                AccessCount = 1
            };
            
            Console.WriteLine($"  Cached: {key} = {value}");
        }
        
        // Проверить наличие ключа
        public bool ContainsKey(TKey key) => _cache.ContainsKey(key);
        
        // Удалить из кеша
        public bool Remove(TKey key)
        {
            bool removed = _cache.Remove(key);
            if (removed)
                Console.WriteLine($"  Removed from cache: {key}");
            return removed;
        }
        
        // Очистить кеш
        public void Clear()
        {
            _cache.Clear();
            Console.WriteLine("  Cache cleared");
        }
        
        // Получить статистику
        public void PrintStatistics()
        {
            Console.WriteLine("\n=== Cache Statistics ===");
            Console.WriteLine($"Total cached items: {_cache.Count}");
            
            foreach (var kvp in _cache)
            {
                var entry = kvp.Value;
                Console.WriteLine($"\nKey: {kvp.Key}");
                Console.WriteLine($"  Value: {entry.Value}");
                Console.WriteLine($"  Created: {entry.CreatedAt:yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine($"  Last Accessed: {entry.LastAccessedAt:yyyy-MM-dd HH:mm:ss}");
                Console.WriteLine($"  Access Count: {entry.AccessCount}");
                Console.WriteLine($"  Age: {(DateTime.Now - entry.CreatedAt).TotalSeconds:F1}s");
            }
        }
        
        // Получить количество элементов в кеше
        public int Count => _cache.Count;
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 33: Generic Cache<TKey, TValue> ===\n");
            
            // 1. Cache с строковыми ключами
            Console.WriteLine("--- String Cache ---");
            var stringCache = new Cache<string, string>();
            
            stringCache.Set("greeting", "Hello World");
            stringCache.Set("farewell", "Goodbye");
            stringCache.Set("greeting2", "Hi there", replace: false);
            
            Console.WriteLine("\nGetting values:");
            stringCache.Get("greeting");
            stringCache.Get("farewell");
            stringCache.Get("greeting");
            stringCache.Get("unknown");
            
            // 2. Cache с целыми числами как ключи
            Console.WriteLine("\n\n--- Integer Key Cache ---");
            var intCache = new Cache<int, string>();
            
            intCache.Set(1, "First");
            intCache.Set(2, "Second");
            intCache.Set(3, "Third");
            
            Console.WriteLine("\nAccessing:");
            intCache.Get(1);
            intCache.Get(2);
            intCache.Get(1);
            intCache.Get(5);
            
            // 3. Cache с составными ключами (Tuple)
            Console.WriteLine("\n\n--- Tuple Key Cache ---");
            var tupleCache = new Cache<(string, int), string>();
            
            tupleCache.Set(("user", 1), "Alice");
            tupleCache.Set(("user", 2), "Bob");
            tupleCache.Set(("user", 3), "Charlie");
            
            Console.WriteLine("\nAccessing:");
            tupleCache.Get(("user", 1));
            tupleCache.Get(("user", 2));
            tupleCache.Get(("user", 1));
            
            // 4. Статистика
            intCache.PrintStatistics();
            
            // 5. Операции с кешем
            Console.WriteLine("\n\n--- Cache Operations ---");
            Console.WriteLine($"Contains key 2: {intCache.ContainsKey(2)}");
            Console.WriteLine($"Contains key 10: {intCache.ContainsKey(10)}");
            
            Console.WriteLine("\nRemoving key 2:");
            intCache.Remove(2);
            
            Console.WriteLine($"Remaining items: {intCache.Count}");
            
            Console.WriteLine("\nClearing cache:");
            intCache.Clear();
            Console.WriteLine($"Items after clear: {intCache.Count}");
        }
    }
}
```

---

## Задание 83: Создайте List<T> с методами CopyTo, GetRange, InsertRange

```csharp
using System;
using System.Collections.Generic;

namespace ListMethodsDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 83: List<T> методы CopyTo, GetRange, InsertRange ===\n");
            
            // 1. Создание основного списка
            Console.WriteLine("--- 1. Создание списка ---");
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine($"Исходный список: [{string.Join(", ", numbers)}]");
            
            // 2. CopyTo - копирование в массив
            Console.WriteLine("\n--- 2. CopyTo (копирование в массив) ---");
            int[] array1 = new int[5];
            numbers.CopyTo(0, array1, 0, 5); // Копируем первые 5 элементов
            Console.WriteLine($"Копировано первые 5 элементов: [{string.Join(", ", array1)}]");
            
            int[] array2 = new int[10];
            numbers.CopyTo(array2); // Копируем весь список
            Console.WriteLine($"Копировано весь список: [{string.Join(", ", array2)}]");
            
            int[] array3 = new int[20];
            numbers.CopyTo(5, array3, 3, 5); // Копируем 5 элементов, начиная с индекса 5 в array3 с позиции 3
            Console.WriteLine($"CopyTo(5, array3, 3, 5): [{string.Join(", ", array3)}]");
            
            // 3. GetRange - получение подсписка
            Console.WriteLine("\n--- 3. GetRange (получение подсписка) ---");
            List<int> sublist1 = numbers.GetRange(0, 3);
            Console.WriteLine($"GetRange(0, 3): [{string.Join(", ", sublist1)}]");
            
            List<int> sublist2 = numbers.GetRange(3, 4);
            Console.WriteLine($"GetRange(3, 4): [{string.Join(", ", sublist2)}]");
            
            List<int> sublist3 = numbers.GetRange(7, 3);
            Console.WriteLine($"GetRange(7, 3): [{string.Join(", ", sublist3)}]");
            
            // 4. InsertRange - вставка диапазона элементов
            Console.WriteLine("\n--- 4. InsertRange (вставка диапазона) ---");
            List<int> modifiedList = new List<int>(numbers);
            List<int> toInsert = new List<int> { 15, 25, 35 };
            
            modifiedList.InsertRange(2, toInsert);
            Console.WriteLine($"После InsertRange(2, {{15, 25, 35}}): [{string.Join(", ", modifiedList)}]");
            
            // 5. Комбинированный пример: GetRange + InsertRange
            Console.WriteLine("\n--- 5. GetRange + InsertRange (копирование подсписка) ---");
            List<int> source = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> destination = new List<int> { 100, 200, 300 };
            
            Console.WriteLine($"Source: [{string.Join(", ", source)}]");
            Console.WriteLine($"Destination (до): [{string.Join(", ", destination)}]");
            
            var copied = source.GetRange(2, 5); // Копируем элементы с индекса 2, 5 элементов
            destination.InsertRange(1, copied);
            
            Console.WriteLine($"Destination (после InsertRange): [{string.Join(", ", destination)}]");
            
            // 6. Практический пример: работа со строками
            Console.WriteLine("\n--- 6. Практический пример со строками ---");
            List<string> words = new List<string> { "Hello", "World", "How", "Are", "You", "Doing", "Today" };
            Console.WriteLine($"Слова: [{string.Join(", ", words)}]");
            
            // Получить подсписок
            var greeting = words.GetRange(0, 2);
            Console.WriteLine($"Приветствие: [{string.Join(", ", greeting)}]");
            
            // Создать новый список и вставить подсписки
            List<string> newList = new List<string>();
            newList.InsertRange(0, greeting);
            newList.InsertRange(newList.Count, new List<string> { "!" });
            Console.WriteLine($"Новый список: [{string.Join(" ", newList)}]");
            
            // 7. Копирование строк в массив
            Console.WriteLine("\n--- 7. CopyTo со строками ---");
            string[] wordArray = new string[5];
            words.CopyTo(2, wordArray, 0, 5);
            Console.WriteLine($"Скопировано 5 слов с индекса 2: [{string.Join(", ", wordArray)}]");
            
            // 8. Удаление и замена через GetRange + InsertRange
            Console.WriteLine("\n--- 8. Замена диапазона (Remove + Insert) ---");
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Исходный: [{string.Join(", ", nums)}]");
            
            // Удаляем элементы с индекса 3, количество 3
            nums.RemoveRange(3, 3);
            Console.WriteLine($"После RemoveRange(3, 3): [{string.Join(", ", nums)}]");
            
            // Вставляем новые элементы
            nums.InsertRange(3, new List<int> { 40, 50, 60 });
            Console.WriteLine($"После InsertRange: [{string.Join(", ", nums)}]");
            
            // 9. Работа с коллекцией пользовательских объектов
            Console.WriteLine("\n--- 9. List<object> операции ---");
            List<object> mixed = new List<object> { 1, "two", 3.0, true, 5 };
            Console.WriteLine($"Смешанный список: [{string.Join(", ", mixed)}]");
            
            var subMixed = mixed.GetRange(1, 3);
            Console.WriteLine($"Подсписок (1, 3): [{string.Join(", ", subMixed)}]");
            
            object[] objectArray = new object[3];
            mixed.CopyTo(1, objectArray, 0, 3);
            Console.WriteLine($"CopyTo в массив: [{string.Join(", ", objectArray)}]");
        }
    }
}
```

---

## 📋 Рекомендации по выполнению

### Ограничения параметризированных типов
- `where T : class` — только ссылочные типы
- `where T : struct` — только типы значений
- `where T : new()` — должен иметь конструктор без параметров
- `where T : IInterface` — должен реализовать интерфейс
- `where T : BaseClass` — должен наследовать базовый класс
- Можно комбинировать: `where T : class, IDisposable, new()`

### Параметризированные коллекции
- **List<T>** — динамический массив, добавление/удаление
- **Dictionary<TKey, TValue>** — ассоциативный массив, быстрый поиск
- **Queue<T>** — FIFO (First In, First Out)
- **Stack<T>** — LIFO (Last In, First Out)
- **HashSet<T>** — уникальные значения
- **LinkedList<T>** — связный список
- **SortedDictionary<TKey, TValue>** — автоматическая сортировка
- **SortedList<TKey, TValue>** — сортированный по ключам

### Основные методы List<T>
- `Add()`, `AddRange()` — добавление элементов
- `Insert()`, `InsertRange()` — вставка в позицию
- `Remove()`, `RemoveAt()`, `RemoveRange()`, `RemoveAll()` — удаление
- `Contains()`, `IndexOf()`, `FindIndex()`, `Find()`, `FindAll()` — поиск
- `Sort()`, `Reverse()` — сортировка
- `CopyTo()` — копирование в массив
- `GetRange()` — получение подсписка
- `Clear()` — очистка

### Основные методы Dictionary<TKey, TValue>
- `Add()` — добавление пары
- `TryGetValue()` — безопасное получение значения
- `ContainsKey()`, `ContainsValue()` — проверка наличия
- `Remove()` — удаление по ключу
- `Keys`, `Values` — получение коллекций ключей/значений
- `Clear()` — очистка

---
