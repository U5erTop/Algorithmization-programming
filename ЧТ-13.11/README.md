# C# Задания: Обобщения (Generics), Ковариантность, Nullable типы, Операции поглощения (100 заданий + решения)

## 📚 Полный список 100 заданий с решениями 5 случайных задач

---

## Раздел 1: Обобщения (Generics) (Задания 1-25)

Создание generic классов, методов, интерфейсов и работа с ограничениями типов.

### Задания 1-25:

1. Создайте generic класс Stack<T> с методами Push, Pop, Peek
2. Реализуйте generic класс Queue<T> для очереди элементов
3. Создайте generic метод для поиска элемента в массиве
4. Реализуйте generic класс Pair<T> для хранения двух значений одного типа
5. Создайте generic метод для обмена значениями двух переменных
6. Реализуйте generic класс для работы с кешем (Cache<TKey, TValue>)
7. Создайте generic класс LinkedList<T> для связного списка
8. Реализуйте generic метод для сортировки массива
9. Создайте generic интерфейс IRepository<T> для доступа к данным
10. Реализуйте generic класс для работы с матрицей Matrix<T>
11. Создайте generic метод для конвертации коллекции в другой тип
12. Реализуйте generic класс для хранения истории операций (History<T>)
13. Создайте generic метод для фильтрации элементов массива
14. Реализуйте generic класс для работы с графом Graph<T>
15. Создайте generic метод для поиска минимума и максимума
16. Реализуйте generic класс Container<T> с ограничениями типа
17. Создайте generic метод для обхода дерева Tree<T>
18. Реализуйте generic интерфейс IComparer<T> для сравнения
19. Создайте generic класс для работы с событиями EventDispatcher<TEvent>
20. Реализуйте generic метод для создания копии объекта (Clone<T>)
21. Создайте generic класс для работы с конвертерами Converter<TIn, TOut>
22. Реализуйте generic метод для валидации значения по типу
23. Создайте generic класс для работы с обработчиком Handler<TRequest, TResponse>
24. Реализуйте generic метод для группировки элементов по типам
25. Создайте generic класс для работы с pipeline обработки Pipeline<T>

---

## Раздел 2: Ковариантность и контрвариантность обобщений (Задания 26-50)

Работа с out и in параметрами, вариантность в интерфейсах и делегатах.

### Задания 26-50:

26. Создайте ковариантный интерфейс IProducer<out T> для чтения данных
27. Реализуйте контрвариантный интерфейс IConsumer<in T> для записи данных
28. Создайте пример ковариантности с IEnumerable<out T>
29. Реализуйте контрвариантный делегат Action<in T>
30. Создайте ковариантный делегат Func<out TResult>
31. Реализуйте иерархию классов для демонстрации вариантности (Animal -> Dog -> Puppy)
32. Создайте пример ошибки при нарушении правил вариантности
33. Реализуйте generic интерфейс с ковариантными параметрами
34. Создайте контрвариантный компаратор для сравнения объектов
35. Реализуйте пример ковариантности при работе с коллекциями
36. Создайте generic класс с поддержкой вариантности
37. Реализуйте ковариантный Factory<out T> для создания объектов
38. Создайте контрвариантный обработчик EventHandler<in TEvent>
39. Реализуйте пример безопасного приведения типов с вариантностью
40. Создайте интерфейс Repository<out T> с ковариантностью
41. Реализуйте контрвариантный validator для проверки данных
42. Создайте пример комбинирования ковариантности и контрвариантности
43. Реализуйте generic метод с ограничениями для поддержки вариантности
44. Создайте ковариантный интерфейс для работы с итераторами
45. Реализуйте контрвариантный интерфейс для обработки ошибок
46. Создайте пример вариантности в делегатах EventHandler
47. Реализуйте generic класс с явным указанием вариантности
48. Создайте интерфейс для преобразования данных с вариантностью
49. Реализуйте систему типов с поддержкой ковариантности
50. Создайте generic интерфейс с multiple вариантными параметрами

---

## Раздел 3: Nullable типы (Задания 51-75)

Работа с Nullable<T>, проверка на null, методы GetValueOrDefault.

### Задания 51-75:

51. Создайте nullable тип int? и работайте с HasValue и Value
52. Реализуйте методы для работы с nullable типами
53. Создайте generic метод для работы с Nullable<T>
54. Реализуйте проверку nullable значения перед использованием
55. Создайте пример использования Nullable<T> в структурах
56. Реализуйте метод для конвертации между nullable типами
57. Создайте класс для работы с опциональными значениями
58. Реализуйте методы Equals и GetHashCode для nullable типов
59. Создайте пример использования nullable типов в свойствах класса
60. Реализуйте валидацию данных с использованием nullable типов
61. Создайте метод для получения значения или значения по умолчанию
62. Реализуйте коллекцию nullable значений
63. Создайте пример преобразования null в значение по умолчанию
64. Реализуйте систему для работы с опциональными параметрами
65. Создайте метод для создания nullable копии объекта
66. Реализуйте сравнение nullable значений
67. Создайте пример использования nullable в LINQ запросах
68. Реализуйте обработку исключений при работе с nullable
69. Создайте метод для фильтрации null значений из коллекции
70. Реализуйте класс Wrapper<T> для обеспечения nullability
71. Создайте пример использования nullable типов в генериках
72. Реализуйте мэпер для преобразования null значений
73. Создайте систему для работы с отсутствующими значениями
74. Реализуйте логирование nullable значений
75. Создайте пример кеширования nullable результатов

---

## Раздел 4: Операции поглощения (Null-coalescing operations) (Задания 76-100)

Операторы ?? и ??=, работа с null-safe navigation.

### Задания 76-100:

76. Создайте пример оператора ?? (null-coalescing) для строк
77. Реализуйте использование ?? для обработки null значений
78. Создайте цепочку операторов ?? (a ?? b ?? c ?? defaultValue)
79. Реализуйте метод для получения первого не-null значения
80. Создайте пример оператора ??= (null-coalescing assignment)
81. Реализуйте использование ?? в условных выражениях
82. Создайте метод для установки значения только если null
83. Реализуйте использование ?? с коллекциями
84. Создайте пример ?? в LINQ выражениях
85. Реализуйте обработка null ссылок на объекты через ??
86. Создайте метод для установки значения свойства если null
87. Реализуйте использование ?? в обработчиках событий
88. Создайте пример ?? при парсинге данных
89. Реализуйте цепочку вызовов с ?? (null-safe navigation)
90. Создайте метод для работы с null в коллекциях через ??
91. Реализуйте использование ?? для параметров метода
92. Создайте пример ?? с методом Invoke на делегатах
93. Реализуйте обработка null в асинхронных методах через ??
94. Создайте пример ?? при работе с конфигурацией
95. Реализуйте использование ?? для установки значений по умолчанию
96. Создайте метод для преобразования null в пустую коллекцию
97. Реализуйте логирование с использованием ?? для сообщений
98. Создайте пример ?? при работе с базой данных
99. Реализуйте использование ?? в конструкторах классов
100. Создайте метод для валидации и установки значений через ??

---

# ✅ РЕШЕНИЯ 5 СЛУЧАЙНЫХ ЗАДАНИЙ

## Задание 5: Создайте generic метод для обмена значениями двух переменных

```csharp
using System;

namespace GenericSwapDemo
{
    class Program
    {
        // Generic метод для обмена двух значений
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        
        // Generic метод с возвращением tuple
        static (T, T) SwapReturn<T>(T a, T b)
        {
            return (b, a);
        }
        
        // Generic класс для обмена с логированием
        class SwapHelper<T>
        {
            private T _value1;
            private T _value2;
            
            public SwapHelper(T value1, T value2)
            {
                _value1 = value1;
                _value2 = value2;
            }
            
            public void Display()
            {
                Console.WriteLine($"Value1: {_value1}, Value2: {_value2}");
            }
            
            public void DoSwap()
            {
                Console.WriteLine($"Before: {_value1}, {_value2}");
                (_value1, _value2) = (_value2, _value1);
                Console.WriteLine($"After: {_value1}, {_value2}");
            }
        }
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 5: Generic метод для обмена значений ===\n");
            
            // 1. Обмен int значений
            Console.WriteLine("--- Обмен целых чисел ---");
            int a = 10, b = 20;
            Console.WriteLine($"До обмена: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"После обмена: a = {a}, b = {b}");
            
            // 2. Обмен string значений
            Console.WriteLine("\n--- Обмен строк ---");
            string s1 = "Hello", s2 = "World";
            Console.WriteLine($"До обмена: s1 = '{s1}', s2 = '{s2}'");
            Swap(ref s1, ref s2);
            Console.WriteLine($"После обмена: s1 = '{s1}', s2 = '{s2}'");
            
            // 3. Обмен double значений
            Console.WriteLine("\n--- Обмен вещественных чисел ---");
            double x = 3.14, y = 2.71;
            Console.WriteLine($"До обмена: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"После обмена: x = {x}, y = {y}");
            
            // 4. Использование SwapReturn
            Console.WriteLine("\n--- SwapReturn (с возвращением tuple) ---");
            int n1 = 100, n2 = 200;
            (n1, n2) = SwapReturn(n1, n2);
            Console.WriteLine($"После SwapReturn: n1 = {n1}, n2 = {n2}");
            
            // 5. SwapHelper класс
            Console.WriteLine("\n--- SwapHelper класс ---");
            var helper = new SwapHelper<char>('A', 'B');
            helper.Display();
            helper.DoSwap();
            
            // 6. Обмен пользовательских объектов
            Console.WriteLine("\n--- Обмен пользовательских объектов ---");
            var person1 = new Person { Name = "Alice", Age = 25 };
            var person2 = new Person { Name = "Bob", Age = 30 };
            
            Console.WriteLine($"До обмена: {person1}, {person2}");
            Swap(ref person1, ref person2);
            Console.WriteLine($"После обмена: {person1}, {person2}");
        }
    }
    
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public override string ToString() => $"{Name} ({Age})";
    }
}
```

---

## Задание 9: Создайте generic интерфейс IRepository<T> для доступа к данным

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericRepositoryDemo
{
    // Generic интерфейс для работы с данными
    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        bool Exists(int id);
    }
    
    // Класс для представления пользователя
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public override string ToString() => $"#{Id} {Name} ({Email})";
    }
    
    // Класс для представления продукта
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public override string ToString() => $"#{Id} {Name} - ${Price:F2}";
    }
    
    // Базовая реализация Repository
    class Repository<T> : IRepository<T> where T : class
    {
        private List<T> _data = new List<T>();
        private int _nextId = 1;
        
        public virtual void Add(T item)
        {
            _data.Add(item);
            dynamic d = item;
            d.Id = _nextId++;
            Console.WriteLine($"✓ Добавлен: {item}");
        }
        
        public virtual void Remove(T item)
        {
            _data.Remove(item);
            Console.WriteLine($"✓ Удален: {item}");
        }
        
        public virtual T GetById(int id)
        {
            return _data.FirstOrDefault(x => ((dynamic)x).Id == id);
        }
        
        public virtual IEnumerable<T> GetAll()
        {
            return _data;
        }
        
        public virtual void Update(T item)
        {
            var index = _data.FindIndex(x => ((dynamic)x).Id == ((dynamic)item).Id);
            if (index >= 0)
            {
                _data[index] = item;
                Console.WriteLine($"✓ Обновлен: {item}");
            }
        }
        
        public virtual bool Exists(int id)
        {
            return _data.Any(x => ((dynamic)x).Id == id);
        }
    }
    
    // Специализированный Repository с фильтрацией
    class UserRepository : Repository<User>
    {
        public List<User> FindByName(string name)
        {
            return GetAll().Where(u => u.Name.Contains(name)).ToList();
        }
        
        public User FindByEmail(string email)
        {
            return GetAll().FirstOrDefault(u => u.Email == email);
        }
    }
    
    // Специализированный Repository для продуктов
    class ProductRepository : Repository<Product>
    {
        public List<Product> FindByPrice(decimal minPrice, decimal maxPrice)
        {
            return GetAll().Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }
        
        public List<Product> FindExpensive(decimal threshold)
        {
            return GetAll().Where(p => p.Price > threshold).OrderByDescending(p => p.Price).ToList();
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 9: Generic IRepository<T> ===\n");
            
            // 1. UserRepository
            Console.WriteLine("--- UserRepository ---");
            var userRepo = new UserRepository();
            
            var user1 = new User { Name = "Alice", Email = "alice@example.com" };
            var user2 = new User { Name = "Bob", Email = "bob@example.com" };
            var user3 = new User { Name = "Charlie", Email = "charlie@example.com" };
            
            userRepo.Add(user1);
            userRepo.Add(user2);
            userRepo.Add(user3);
            
            Console.WriteLine("\nВсе пользователи:");
            foreach (var user in userRepo.GetAll())
                Console.WriteLine($"  {user}");
            
            Console.WriteLine("\nПоиск по имени 'Alice':");
            foreach (var user in userRepo.FindByName("Alice"))
                Console.WriteLine($"  {user}");
            
            Console.WriteLine("\nПоиск по email 'bob@example.com':");
            var found = userRepo.FindByEmail("bob@example.com");
            Console.WriteLine($"  {found}");
            
            // 2. ProductRepository
            Console.WriteLine("\n--- ProductRepository ---");
            var productRepo = new ProductRepository();
            
            var prod1 = new Product { Name = "Ноутбук", Price = 1200.00m };
            var prod2 = new Product { Name = "Мышка", Price = 25.00m };
            var prod3 = new Product { Name = "Монитор", Price = 400.00m };
            var prod4 = new Product { Name = "Клавиатура", Price = 80.00m };
            
            productRepo.Add(prod1);
            productRepo.Add(prod2);
            productRepo.Add(prod3);
            productRepo.Add(prod4);
            
            Console.WriteLine("\nВсе продукты:");
            foreach (var prod in productRepo.GetAll())
                Console.WriteLine($"  {prod}");
            
            Console.WriteLine("\nПродукты стоимостью $50-$500:");
            foreach (var prod in productRepo.FindByPrice(50, 500))
                Console.WriteLine($"  {prod}");
            
            Console.WriteLine("\nДорогие продукты (>$100):");
            foreach (var prod in productRepo.FindExpensive(100))
                Console.WriteLine($"  {prod}");
            
            // 3. Операции обновления
            Console.WriteLine("\n--- Операции Update/Remove ---");
            user1.Name = "Alice Smith";
            userRepo.Update(user1);
            
            userRepo.Remove(user2);
            
            Console.WriteLine("\nПользователи после изменений:");
            foreach (var user in userRepo.GetAll())
                Console.WriteLine($"  {user}");
        }
    }
}
```

---

## Задание 31: Реализуйте иерархию классов для демонстрации вариантности (Animal -> Dog -> Puppy)

```csharp
using System;
using System.Collections.Generic;

namespace VarianceHierarchyDemo
{
    // Базовый класс Animal
    class Animal
    {
        public string Name { get; set; }
        
        public virtual void MakeSound()
        {
            Console.WriteLine("Звук животного");
        }
        
        public override string ToString() => $"{GetType().Name}: {Name}";
    }
    
    // Класс Dog наследует Animal
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав! Гав!");
        }
    }
    
    // Класс Puppy наследует Dog
    class Puppy : Dog
    {
        public override void MakeSound()
        {
            Console.WriteLine("Пищик! Пищик!");
        }
    }
    
    // Ковариантный интерфейс (out T)
    interface IProducer<out T>
    {
        T Produce();
    }
    
    // Контрвариантный интерфейс (in T)
    interface IConsumer<in T>
    {
        void Consume(T item);
    }
    
    // Реализация Producer
    class AnimalProducer : IProducer<Animal>
    {
        public Animal Produce() => new Animal { Name = "Generic Animal" };
    }
    
    class DogProducer : IProducer<Dog>
    {
        public Dog Produce() => new Dog { Name = "Buddy" };
    }
    
    class PuppyProducer : IProducer<Puppy>
    {
        public Puppy Produce() => new Puppy { Name = "Max" };
    }
    
    // Реализация Consumer
    class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine($"Consuming: {animal}");
            animal.MakeSound();
        }
    }
    
    class DogConsumer : IConsumer<Dog>
    {
        public void Consume(Dog dog)
        {
            Console.WriteLine($"Consuming Dog: {dog}");
            dog.MakeSound();
        }
    }
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 31: Ковариантность и контрвариантность ===\n");
            
            // 1. Демонстрация иерархии
            Console.WriteLine("--- Иерархия классов ---");
            Animal generic = new Animal { Name = "Animal" };
            Dog dog = new Dog { Name = "Rex" };
            Puppy puppy = new Puppy { Name = "Buddy" };
            
            generic.MakeSound();
            dog.MakeSound();
            puppy.MakeSound();
            
            // 2. Ковариантность: IProducer<out T>
            Console.WriteLine("\n--- Ковариантность (IProducer<out T>) ---");
            
            IProducer<Animal> animalProducer = new AnimalProducer();
            IProducer<Dog> dogProducer = new DogProducer();
            IProducer<Puppy> puppyProducer = new PuppyProducer();
            
            // Ковариантность позволяет это:
            IProducer<Animal> producerAsAnimal1 = dogProducer; // Dog может быть Animal
            IProducer<Animal> producerAsAnimal2 = puppyProducer; // Puppy может быть Animal
            
            Console.WriteLine("Производители:");
            Console.WriteLine($"  AnimalProducer: {animalProducer.Produce()}");
            Console.WriteLine($"  DogProducer как Animal: {producerAsAnimal1.Produce()}");
            Console.WriteLine($"  PuppyProducer как Animal: {producerAsAnimal2.Produce()}");
            
            // 3. Контрвариантность: IConsumer<in T>
            Console.WriteLine("\n--- Контрвариантность (IConsumer<in T>) ---");
            
            IConsumer<Animal> animalConsumer = new AnimalConsumer();
            IConsumer<Dog> dogConsumer = new DogConsumer();
            
            // Контрвариантность позволяет это:
            IConsumer<Dog> consumerForDog = animalConsumer; // Animal может обрабатывать Dog
            IConsumer<Puppy> consumerForPuppy = animalConsumer; // Animal может обрабатывать Puppy
            
            Console.WriteLine("\nПотребители:");
            consumerForDog.Consume(new Dog { Name = "Собака" });
            consumerForPuppy.Consume(new Puppy { Name = "Щенок" });
            
            // 4. Тестирование присваивания
            Console.WriteLine("\n--- Проверка типов ---");
            Console.WriteLine($"animalProducer is IProducer<Animal>: {animalProducer is IProducer<Animal>}");
            Console.WriteLine($"dogProducer is IProducer<Animal>: {dogProducer is IProducer<Animal>}"); // true благодаря ковариантности
            Console.WriteLine($"puppyProducer is IProducer<Animal>: {puppyProducer is IProducer<Animal>}"); // true
            
            // 5. Практический пример: коллекции
            Console.WriteLine("\n--- Практический пример с коллекциями ---");
            var dogs = new List<Dog> { new Dog { Name = "Rex" }, new Dog { Name = "Max" } };
            var puppies = new List<Puppy> { new Puppy { Name = "Buddy" } };
            
            // IEnumerable<out T> позволяет это:
            IEnumerable<Animal> animalsFromDogs = dogs;
            IEnumerable<Animal> animalsFromPuppies = puppies;
            
            Console.WriteLine("\nВсе животные:");
            foreach (var animal in animalsFromDogs)
                Console.WriteLine($"  {animal}");
            foreach (var animal in animalsFromPuppies)
                Console.WriteLine($"  {animal}");
        }
    }
}
```

---

## Задание 33: Реализуйте generic интерфейс с ковариантными параметрами

```csharp
using System;
using System.Collections.Generic;

namespace CovarianceInterfaceDemo
{
    // Ковариантный интерфейс: выдает только значения типа T
    interface IReadOnlyRepository<out T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
    
    // Контрвариантный интерфейс: принимает только значения типа T
    interface IValidator<in T> where T : class
    {
        bool Validate(T item);
        void LogValidation(T item, bool isValid);
    }
    
    // Интерфейс с обоими параметрами (никакой вариантности)
    interface IRepository<T> where T : class
    {
        void Add(T item);
        T GetById(int id);
    }
    
    // Классы для иерархии
    abstract class Shape
    {
        public string Name { get; set; }
        public abstract double GetArea();
        public override string ToString() => $"{GetType().Name}: {Name}";
    }
    
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea() => Math.PI * Radius * Radius;
    }
    
    class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea() => Side * Side;
    }
    
    // Реализация репозитория для Shape
    class ShapeRepository : IReadOnlyRepository<Shape>
    {
        private List<Shape> _shapes = new List<Shape>
        {
            new Circle { Name = "Circle1", Radius = 5 },
            new Square { Name = "Square1", Side = 4 }
        };
        
        public Shape GetById(int id) => id < _shapes.Count ? _shapes[id] : null;
        public IEnumerable<Shape> GetAll() => _shapes;
    }
    
    // Реализация репозитория для Circle
    class CircleRepository : IReadOnlyRepository<Circle>
    {
        private List<Circle> _circles = new List<Circle>
        {
            new Circle { Name = "Circle1", Radius = 3 },
            new Circle { Name = "Circle2", Radius = 5 },
            new Circle { Name = "Circle3", Radius = 7 }
        };
        
        public Circle GetById(int id) => id < _circles.Count ? _circles[id] : null;
        public IEnumerable<Circle> GetAll() => _circles;
    }
    
    // Валидатор
    class ShapeValidator : IValidator<Shape>
    {
        public bool Validate(Shape item)
        {
            if (item == null) return false;
            double area = item.GetArea();
            return area > 0;
        }
        
        public void LogValidation(Shape item, bool isValid)
        {
            Console.WriteLine($"  [{(isValid ? "✓" : "✗")}] {item} - Area: {item.GetArea():F2}");
        }
    }
    
    class Program
    {
        // Метод принимает ковариантный интерфейс
        static void DisplayShapes(IReadOnlyRepository<Shape> repo)
        {
            Console.WriteLine("Фигуры в репозитории:");
            foreach (var shape in repo.GetAll())
                Console.WriteLine($"  {shape} - Area: {shape.GetArea():F2}");
        }
        
        // Метод принимает контрвариантный интерфейс
        static void ValidateShapes(IEnumerable<Shape> shapes, IValidator<Shape> validator)
        {
            Console.WriteLine("Валидация фигур:");
            foreach (var shape in shapes)
            {
                bool isValid = validator.Validate(shape);
                validator.LogValidation(shape, isValid);
            }
        }
        
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 33: Generic интерфейс с ковариантностью ===\n");
            
            // 1. Ковариантный репозиторий Shape
            Console.WriteLine("--- 1. ShapeRepository ---");
            IReadOnlyRepository<Shape> shapeRepo = new ShapeRepository();
            DisplayShapes(shapeRepo);
            
            // 2. Ковариантный репозиторий Circle (может использоваться как Shape!)
            Console.WriteLine("\n--- 2. CircleRepository как Shape (ковариантность) ---");
            IReadOnlyRepository<Circle> circleRepo = new CircleRepository();
            // Благодаря ковариантности (out T), CircleRepository может быть использован как IReadOnlyRepository<Shape>
            IReadOnlyRepository<Shape> circleAsShapeRepo = circleRepo;
            DisplayShapes(circleAsShapeRepo);
            
            // 3. Валидация
            Console.WriteLine("\n--- 3. Валидация фигур ---");
            var validator = new ShapeValidator();
            
            List<Shape> allShapes = new List<Shape>
            {
                new Circle { Name = "BigCircle", Radius = 10 },
                new Square { Name = "BigSquare", Side = 8 },
                new Circle { Name = "SmallCircle", Radius = 2 }
            };
            
            ValidateShapes(allShapes, validator);
            
            // 4. Практический пример: получение различных типов
            Console.WriteLine("\n--- 4. Использование ковариантности ---");
            
            // Все это возможно благодаря ковариантности (out T)
            IReadOnlyRepository<Shape> repo1 = shapeRepo;      // Shape repo
            IReadOnlyRepository<Shape> repo2 = circleRepo;     // Circle repo как Shape
            
            Console.WriteLine("Репо 1 (Shape):");
            foreach (var shape in repo1.GetAll())
                Console.WriteLine($"  {shape}");
            
            Console.WriteLine("\nРепо 2 (Circle как Shape):");
            foreach (var shape in repo2.GetAll())
                Console.WriteLine($"  {shape}");
            
            // 5. Проверка типов
            Console.WriteLine("\n--- 5. Проверка типов ---");
            Console.WriteLine($"circleRepo is IReadOnlyRepository<Shape>: {circleRepo is IReadOnlyRepository<Shape>}");
            Console.WriteLine($"validator is IValidator<Shape>: {validator is IValidator<Shape>}");
        }
    }
}
```

---

## Задание 83: Реализуйте использование ?? с коллекциями

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

namespace NullCoalescingCollectionsDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ЗАДАНИЕ 83: ?? оператор с коллекциями ===\n");
            
            // 1. ?? с List - замена null на пустой список
            Console.WriteLine("--- 1. ?? с List<T> ---");
            List<int> numbers = null;
            List<int> safeNumbers = numbers ?? new List<int> { 1, 2, 3 };
            Console.WriteLine($"Список: [{string.Join(", ", safeNumbers)}]");
            
            // 2. ?? с Array
            Console.WriteLine("\n--- 2. ?? с массивами ---");
            int[] array = null;
            int[] safeArray = array ?? new[] { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Массив: [{string.Join(", ", safeArray)}]");
            
            // 3. ?? с коллекцией для безопасного перебора
            Console.WriteLine("\n--- 3. Безопасный перебор коллекции ---");
            List<string> items = null;
            foreach (var item in items ?? new List<string> { "Default1", "Default2" })
                Console.WriteLine($"  - {item}");
            
            // 4. ?? в LINQ Where с пустой коллекцией
            Console.WriteLine("\n--- 4. ?? в LINQ запросах ---");
            List<int> data = null;
            var filtered = (data ?? new List<int> { 1, 2, 3, 4, 5 })
                .Where(x => x > 2)
                .ToList();
            Console.WriteLine($"Отфильтровано: [{string.Join(", ", filtered)}]");
            
            // 5. ?? для объединения коллекций
            Console.WriteLine("\n--- 5. ?? для объединения коллекций ---");
            List<string> list1 = null;
            List<string> list2 = new List<string> { "Item1", "Item2" };
            var combined = (list1 ?? new List<string>()).Concat(list2).ToList();
            Console.WriteLine($"Объединенные: [{string.Join(", ", combined)}]");
            
            // 6. ?? с методом, возвращающим коллекцию
            Console.WriteLine("\n--- 6. ?? с методом, возвращающим коллекцию ---");
            List<Product> products = GetProducts() ?? new List<Product>
            {
                new Product { Id = 1, Name = "Default Product", Price = 99.99m }
            };
            foreach (var product in products)
                Console.WriteLine($"  {product}");
            
            // 7. ?? для значений в коллекции
            Console.WriteLine("\n--- 7. ?? для обработки элементов коллекции ---");
            var values = new List<int?> { 1, null, 3, null, 5 };
            var nonNullValues = values.Select(v => v ?? 0).ToList();
            Console.WriteLine($"Все значения: [{string.Join(", ", nonNullValues)}]");
            
            // 8. ??= с коллекцией (присваивание если null)
            Console.WriteLine("\n--- 8. ??= оператор (присваивание если null) ---");
            List<char> chars = null;
            chars ??= new List<char> { 'A', 'B', 'C' };
            Console.WriteLine($"Символы: [{string.Join(", ", chars)}]");
            
            chars ??= new List<char> { 'X', 'Y', 'Z' }; // Не будет применено
            Console.WriteLine($"Символы (второй раз): [{string.Join(", ", chars)}]");
            
            // 9. Цепочка ?? для коллекций
            Console.WriteLine("\n--- 9. Цепочка ?? операторов ---");
            List<int> col1 = null;
            List<int> col2 = null;
            List<int> col3 = new List<int> { 100, 200, 300 };
            var result = col1 ?? col2 ?? col3 ?? new List<int> { 999 };
            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
            
            // 10. ?? для безопасной работы с Dictionary
            Console.WriteLine("\n--- 10. ?? с Dictionary ---");
            Dictionary<string, List<int>> dict = null;
            var dictValue = (dict ?? new Dictionary<string, List<int>>())
                .GetValueOrDefault("key", new List<int> { 1, 2, 3 });
            Console.WriteLine($"Значение: [{string.Join(", ", dictValue)}]");
            
            // 11. Практический пример: обработка данных с ?? 
            Console.WriteLine("\n--- 11. Практический пример: фильтр товаров ---");
            List<Product> storedProducts = null;
            var productsToDisplay = (storedProducts ?? LoadDefaultProducts())
                .Where(p => p.Price < 150)
                .OrderBy(p => p.Price)
                .ToList();
            
            Console.WriteLine("Товары дешевле $150:");
            foreach (var p in productsToDisplay)
                Console.WriteLine($"  {p}");
            
            // 12. ?? для параметров метода
            Console.WriteLine("\n--- 12. ?? для параметров метода ---");
            ProcessItems(null);
            ProcessItems(new List<string> { "A", "B", "C" });
        }
        
        static List<Product> GetProducts() => null; // Возвращает null
        
        static List<Product> LoadDefaultProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Price = 99.99m },
                new Product { Id = 2, Name = "Product B", Price = 149.99m },
                new Product { Id = 3, Name = "Product C", Price = 199.99m }
            };
        }
        
        static void ProcessItems(List<string> items)
        {
            items ??= new List<string> { "Default1", "Default2", "Default3" };
            Console.WriteLine($"Обрабатываются элементы: [{string.Join(", ", items)}]");
        }
    }
    
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        
        public override string ToString() => $"#{Id} {Name} - ${Price:F2}";
    }
}
```

---

## 📋 Рекомендации по выполнению

### Обобщения (Generics)
- Используйте `<T>` для создания гибких типов
- Применяйте `where T : class/struct/new()` для ограничений
- Generic методы часто мощнее, чем перегрузка методов
- IEnumerable<T>, IList<T>, IDictionary<T> — наиболее частые generic интерфейсы

### Ковариантность и Контрвариантность
- `out T` — ковариантность, только возврат (producer)
- `in T` — контрвариантность, только параметр (consumer)
- Работает только с ссылочными типами
- IEnumerable<out T> по умолчанию ковариантен

### Nullable типы
- `int?` эквивалентно `Nullable<int>`
- `HasValue` и `Value` для проверки и доступа
- `GetValueOrDefault()` для безопасного получения значения
- Используйте в опциональных параметрах и возвращаемых значениях

### Операции поглощения
- `??` — возвращает левое значение если не null, иначе правое
- `??=` — присваивает только если текущее значение null
- `?.` — null-safe navigation operator (опциональный доступ)
- Всегда предпочитайте `??` вместо многоуровневых проверок

---

## 🔗 Дополнительные материалы

- [Generics в C#](https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/types/generics)
- [Ковариантность и контрвариантность](https://learn.microsoft.com/ru-ru/dotnet/standard/generics/covariance-and-contravariance)
- [Nullable типы](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/nullable-value-types)
- [Null-coalescing оператор](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/null-coalescing-operator)
- [Null-safe navigation operator](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-)

---

**Успешное изучение обобщений, вариантности и работы с null в C#! 🚀**