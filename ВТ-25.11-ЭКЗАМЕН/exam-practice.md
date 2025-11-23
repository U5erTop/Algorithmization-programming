# Практические задачи по дисциплине "Основы алгоритмизации и программирования" (C#)
---

## Билет 1.

### Задача 1: Анализатор типов данных

**Описание:**
Разработайте программу, которая принимает произвольный объект и выводит полную информацию о его типе: размер в памяти (для value types), находится ли в стеке или куче, выполняется ли boxing при присваивании в object, все поля и их типы. Программа должна корректно обрабатывать nullable типы, generics и сложные вложенные структуры.

**Требования:**
- Анализировать метаинформацию типа через рефлексию
- Вывести размер типа через Marshal.SizeOf() для value types
- Определить является ли тип value или reference type
- Показать все публичные и приватные поля
- Поддержать generic-типы и nullable типы
- Продемонстрировать разницу между стеком и кучей на примерах

**Пример использования:**
```csharp
var analyzer = new TypeAnalyzer();
analyzer.Analyze(42);                           // int - value type, 4 байта, стек
analyzer.Analyze("Hello");                      // string - reference type, куча
analyzer.Analyze(new List<int> { 1, 2, 3 });  // List<int> - reference type
analyzer.Analyze((42, "test"));                 // ValueTuple - value type
```

**Ожидаемый вывод:**
```
=== Анализ типа: System.Int32 ===
Категория: Value Type
Размер: 4 байта
Размещение: Stack
Boxing выполняется: Да, при приведении к object
Поля: нет

=== Анализ типа: System.String ===
Категория: Reference Type
Размер: 16 байта (заголовок объекта)
Размещение: Heap
Boxing выполняется: Нет
Поля: m_firstChar, m_stringLength
```

---

### Задача 2.

**Описание:**
Дан код программы с множественными операциями boxing/unboxing (например, ArrayList с int значениями). Перепишите код, устранив все boxing/unboxing операции с использованием generic-коллекций. Замерьте и сравните производительность до и после оптимизации для 1 000 000 операций. Объясните результаты.

**Требования:**
- Создать неоптимизированную версию с ArrayList и boxing
- Создать оптимизированную версию с List<T>
- Измерить время выполнения обеих версий
- Измерить потребление памяти
- Провести операции: добавление, доступ, удаление элементов
- Вывести результаты в таблице для сравнения

**Исходный неоптимизированный код:**
```csharp
// Плохо: использование ArrayList (boxing для value types)
ArrayList list = new ArrayList();
for (int i = 0; i < 1_000_000; i++)
{
    list.Add(i);  // Boxing!
}

for (int i = 0; i < list.Count; i++)
{
    int value = (int)list[i];  // Unboxing!
}
```

**Пример оптимизированного кода:**
```csharp
// Хорошо: использование List<int> (без boxing)
List<int> list = new List<int>();
for (int i = 0; i < 1_000_000; i++)
{
    list.Add(i);  // Без boxing!
}

for (int i = 0; i < list.Count; i++)
{
    int value = list[i];  // Без unboxing!
}
```

**Ожидаемый результат:**
```
┌─────────────────────────┬──────────────┬──────────────────┐
│ Операция                │ ArrayList    │ List<T>          │
├─────────────────────────┼──────────────┼──────────────────┤
│ Время добавления 1M     │ 450 ms       │ 25 ms            │
│ Время доступа 1M        │ 380 ms       │ 18 ms            │
│ Время удаления 1M       │ 520 ms       │ 45 ms            │
│ Память (MB)             │ 95 MB        │ 12 MB            │
│ Сборок мусора (Gen 2)   │ 15           │ 1                │
└─────────────────────────┴──────────────┴──────────────────┘

Ускорение: 18x раз
Экономия памяти: 87.4%
```

---

### Задача 3.

**Описание:**
Реализуйте систему безопасного преобразования между типами данных, которая учитывает переполнение, потерю точности и некорректные преобразования. Система должна работать с checked/unchecked контекстами, обрабатывать явные и неявные преобразования, и логировать все потенциально опасные операции.

**Требования:**
- Создать класс SafeConverter<T> с методами преобразования
- Поддерживать все встроенные типы данных
- Проверять переполнение (overflow/underflow)
- Проверять потерю точности для float/double
- Логировать все опасные операции
- Возвращать результат с информацией об успехе/ошибке

**Типы преобразований:**
1. int -> byte (с риском переполнения)
2. double -> int (с риском потери точности)
3. string -> int (с риском некорректного формата)
4. decimal -> double (с риском потери точности)
5. object -> конкретный тип (с проверкой типа)

**Пример использования:**
```csharp
var converter = new SafeConverter();

// Успешное преобразование
var result1 = converter.Convert<int, byte>(100);
// Result: Success, Value: 100

// Переполнение
var result2 = converter.Convert<int, byte>(300);
// Result: Overflow, Value: null, Log: "Значение 300 выходит за границы диапазона byte [0, 255]"

// Потеря точности
var result3 = converter.Convert<double, int>(3.14159);
// Result: PrecisionLoss, Value: 3, Log: "Потеря точности при преобразовании 3.14159 -> 3"

// Некорректный формат
var result4 = converter.Convert<string, int>("abc123");
// Result: FormatError, Value: null, Log: "Строка 'abc123' не может быть преобразована в int"
```

**Структура результата:**
```csharp
public class ConversionResult<T>
{
    public ConversionStatus Status { get; set; }
    public T Value { get; set; }
    public string ErrorMessage { get; set; }
    public List<string> Warnings { get; set; }
    public DateTime Timestamp { get; set; }
}

public enum ConversionStatus
{
    Success,
    Overflow,
    Underflow,
    PrecisionLoss,
    TypeMismatch,
    FormatError,
    NotSupported
}
```

---

## Билет 2.

### Задача 1: Интерпретатор логических выражений

**Описание:**
Создайте интерпретатор, который принимает строку с логическим выражением (с операторами &&, ||, !, ==, !=, <, >, <=, >=) и переменными, и вычисляет результат. Реализуйте короткое замыкание (short-circuit evaluation). Поддержите приоритет операторов и скобки. Входные данные: выражение и словарь переменных со значениями.

**Требования:**
- Парсировать логические выражения со скобками
- Поддерживать операторы: &&, ||, !, ==, !=, <, >, <=, >=
- Реализовать правильный приоритет операторов
- Реализовать короткое замыкание (&&, ||)
- Обрабатывать переменные и константы
- Выводить AST (Abstract Syntax Tree) для отладки
- Поддерживать вложенные выражения любой глубины

**Приоритет операторов:**
1. ! (отрицание)
2. <, >, <=, >=, ==, !=
3. && (И с коротким замыканием)
4. || (ИЛИ с коротким замыканием)

**Пример использования:**
```csharp
var interpreter = new ExpressionInterpreter();

var vars = new Dictionary<string, int>
{
    { "x", 10 },
    { "y", 5 },
    { "z", 20 }
};

// Простое выражение
bool result1 = interpreter.Evaluate("x > y", vars);  // true
bool result2 = interpreter.Evaluate("x < y", vars);  // false

// С логическими операторами
bool result3 = interpreter.Evaluate("(x > y) && (z > x)", vars);  // true
bool result4 = interpreter.Evaluate("(x < y) || (z > x)", vars);  // true

// С отрицанием
bool result5 = interpreter.Evaluate("!(x == y)", vars);  // true

// Сложное выражение с короткими замыканиями
bool result6 = interpreter.Evaluate("(x > 0) && (y > 0) && (z > 0)", vars);  // true

// Вывод AST для отладки
interpreter.PrintAST("(x > 5) && ((y < 10) || (z >= 15))", vars);
```

**Ожидаемый AST:**
```
Expression Tree:
└── AND (&&)
    ├── GT (>)
    │   ├── Variable: x (10)
    │   └── Constant: 5
    └── OR (||)
        ├── LT (<)
        │   ├── Variable: y (5)
        │   └── Constant: 10
        └── GTE (>=)
            ├── Variable: z (20)
            └── Constant: 15

Result: true
Short-circuits triggered: 0
```

---

### Задача 2: Умный switch для маршрутизации

**Описание:**
Разработайте систему маршрутизации HTTP-запросов с использованием современного switch expression и pattern matching. Система должна учитывать метод запроса (GET/POST/PUT/DELETE), путь (с возможностью параметров), заголовки и тело запроса. Реализуйте не менее 20 различных маршрутов с разными паттернами.

**Требования:**
- Использовать switch expressions с pattern matching
- Поддерживать параметры в пути (/users/{id}, /posts/{id}/comments/{cid})
- Проверять заголовки (Content-Type, Authorization и т.д.)
- Обрабатывать разные типы тел запроса
- Применять приоритет правил (более специфичные сначала)
- Возвращать структурированный ответ
- Логировать все маршруты и совпадения

**Структуры данных:**
```csharp
public record HttpRequest(
    string Method,
    string Path,
    Dictionary<string, string> Headers,
    string Body);

public record RouteMatch(
    bool Success,
    string Handler,
    Dictionary<string, string> Parameters,
    string Message);
```

**Пример использования:**
```csharp
var router = new SmartRouter();

// GET /users - список пользователей
var req1 = new HttpRequest("GET", "/users", new(), "");
var match1 = router.Route(req1);
// Handler: GetAllUsers, Match: Success

// GET /users/123 - получить пользователя
var req2 = new HttpRequest("GET", "/users/123", new(), "");
var match2 = router.Route(req2);
// Handler: GetUser, Parameters: { id: 123 }, Match: Success

// POST /users + Content-Type: application/json
var req3 = new HttpRequest("POST", "/users", 
    new() { { "Content-Type", "application/json" } },
    "{\\"name\\": \\"John\\"}");
var match3 = router.Route(req3);
// Handler: CreateUser, Match: Success

// GET /posts/5/comments/42
var req4 = new HttpRequest("GET", "/posts/5/comments/42", new(), "");
var match4 = router.Route(req4);
// Handler: GetComment, Parameters: { postId: 5, commentId: 42 }, Match: Success

// POST /auth/login + Bearer token
var req5 = new HttpRequest("POST", "/auth/login",
    new() { { "Authorization", "Bearer token123" } },
    "");
var match5 = router.Route(req5);
// Handler: Login, Match: Success
```

**Маршруты (20+ примеров):**
```
1. GET /api/health -> HealthCheck
2. GET /users -> GetAllUsers
3. GET /users/{id} -> GetUser
4. POST /users -> CreateUser
5. PUT /users/{id} -> UpdateUser
6. DELETE /users/{id} -> DeleteUser
7. GET /posts/{id} -> GetPost
8. GET /posts/{id}/comments -> GetComments
9. POST /posts/{id}/comments -> AddComment
10. GET /posts/{id}/comments/{cid} -> GetComment
11. POST /auth/login -> Login
12. POST /auth/logout -> Logout
13. POST /auth/refresh + Bearer -> RefreshToken
14. GET /files/{id} -> DownloadFile
15. POST /files/upload + multipart/form-data -> UploadFile
16. DELETE /files/{id} -> DeleteFile
17. GET /search -> Search
18. GET /api/v1/users -> GetUsersV1
19. GET /api/v2/users -> GetUsersV2
20. OPTIONS * -> CorsPreFlight
21. PATCH /users/{id} -> PartialUpdateUser
22. HEAD /users/{id} -> CheckUser
```

---

### Задача 3.

**Описание:**
Создайте класс для работы с глубоко вложенными JSON-подобными структурами. Используйте null-conditional и null-coalescing операторы для безопасного доступа к данным любой глубины вложенности. Реализуйте методы: GetValue<T>(path), SetValue(path, value), DeleteValue(path), где path - строка типа 'user.address.city.name'.

**Требования:**
- Безопасный доступ к вложенным свойствам без NullReferenceException
- Поддерживать работу с массивами (path[0].property)
- Автоматическое создание промежуточных объектов при SetValue
- Удаление свойств при DeleteValue
- Работа с JSON и динамическими объектами
- Поддержка type casting при GetValue<T>
- Валидация путей и обработка ошибок

**Пример использования:**
```csharp
var navigator = new SafeNavigator();

var data = new
{
    user = new
    {
        name = "John",
        address = new
        {
            city = "New York",
            zip = "10001"
        }
    }
};

// Безопасный доступ к вложенным данным
string city = navigator.GetValue<string>(data, "user.address.city");
// Result: "New York"

// Получение с дефолтным значением
string country = navigator.GetValue<string>(data, "user.address.country", "USA");
// Result: "USA" (дефолт, т.к. country не существует)

// Установка значения с созданием промежуточных объектов
navigator.SetValue(data, "user.phone.mobile", "+1234567890");
// user.phone будет создана автоматически

// Удаление свойства
navigator.DeleteValue(data, "user.address.zip");
// После: address не содержит zip

// Работа с массивами
var users = new[]
{
    new { name = "John", age = 30 },
    new { name = "Jane", age = 25 }
};
string firstName = navigator.GetValue<string>(users, "[0].name");
// Result: "John"

// Поиск в массивах с условием
string targetUser = navigator.GetValue<string>(users, "[?age>26].name");
// Result: "John"
```

**Структура класса:**
```csharp
public class SafeNavigator
{
    public T GetValue<T>(object obj, string path, T defaultValue = default);
    public void SetValue(object obj, string path, object value);
    public bool DeleteValue(object obj, string path);
    public bool PathExists(object obj, string path);
    public List<(string Path, object Value)> GetAllValues(object obj);
}
```

---

## Билет 3.

### Задача 1: Генератор последовательностей с yield

**Описание:**
Реализуйте набор итераторов с использованием yield return: 1) Числа Фибоначчи до N-ного элемента, 2) Простые числа в диапазоне, 3) Перестановки массива элементов, 4) Комбинации без повторений из N по K. Все итераторы должны поддерживать ленивое вычисление и быть memory-efficient.

**Требования:**
- Использовать yield return для отложенного вычисления
- Не вычислять всю последовательность заранее
- Memory-efficient реализация
- Поддерживать отмену через CancellationToken
- Статистика: количество элементов, время вычисления

**Задача 1.1: Числа Фибоначчи**
```csharp
public IEnumerable<long> FibonacciSequence(int count)
{
    if (count < 1) yield break;
    
    long a = 0, b = 1;
    yield return a;
    
    for (int i = 1; i < count; i++)
    {
        yield return b;
        long temp = a + b;
        a = b;
        b = temp;
    }
}

// Использование
var fibs = FibonacciSequence(50);
foreach (var fib in fibs.Take(10))
{
    Console.WriteLine(fib);
}
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
```

**Задача 1.2: Простые числа**
```csharp
public IEnumerable<int> PrimeNumbers(int from, int to)
{
    for (int num = Math.Max(2, from); num <= to; num++)
    {
        bool isPrime = true;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            yield return num;
    }
}

// Использование
var primes = PrimeNumbers(1, 100);
var firstTen = primes.Take(10);
// 2, 3, 5, 7, 11, 13, 17, 19, 23, 29
```

**Задача 1.3: Перестановки**
```csharp
public IEnumerable<T[]> Permutations<T>(T[] array)
{
    if (array.Length == 1)
    {
        yield return array;
    }
    else
    {
        foreach (var perm in Permutations(array[1..]))
        {
            for (int i = 0; i <= perm.Length; i++)
            {
                var newArray = perm.ToList();
                newArray.Insert(i, array[0]);
                yield return newArray.ToArray();
            }
        }
    }
}

// Использование
var items = new[] { 1, 2, 3 };
foreach (var perm in Permutations(items))
{
    Console.WriteLine(string.Join(", ", perm));
}
// Output:
// 1, 2, 3
// 2, 1, 3
// 2, 3, 1
// 1, 3, 2
// 3, 1, 2
// 3, 2, 1
```

**Задача 1.4: Комбинации**
```csharp
public IEnumerable<T[]> Combinations<T>(T[] array, int k)
{
    if (k == 0)
    {
        yield return new T[] { };
    }
    else if (k == array.Length)
    {
        yield return array;
    }
    else
    {
        foreach (var comb in Combinations(array[1..], k - 1))
        {
            var result = new T[k];
            result[0] = array[0];
            Array.Copy(comb, 0, result, 1, k - 1);
            yield return result;
        }
        
        foreach (var comb in Combinations(array[1..], k))
        {
            yield return comb;
        }
    }
}

// Использование
var items = new[] { 1, 2, 3, 4 };
foreach (var comb in Combinations(items, 2))
{
    Console.WriteLine(string.Join(", ", comb));
}
// Output:
// 1, 2
// 1, 3
// 1, 4
// 2, 3
// 2, 4
// 3, 4
```

---

### Задача 2: Параллельная обработка с оптимизацией

**Описание:**
Дан большой массив чисел (10^7 элементов). Реализуйте три версии подсчета суммы квадратов четных чисел: 1) обычный foreach, 2) Parallel.ForEach, 3) PLINQ. Замерьте время выполнения каждого варианта. Добавьте возможность настройки степени параллелизма. Объясните, когда какой подход эффективнее.

**Требования:**
- Сгенерировать массив 10^7 случайных чисел
- Реализовать три версии алгоритма
- Измерить время выполнения в миллисекундах
- Измерить потребление памяти
- Изменять DegreeOfParallelism и анализировать результаты
- Вывести результаты в таблице

**Версия 1: Последовательный foreach**
```csharp
public static long SequentialSum(int[] numbers)
{
    long sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
            sum += (long)numbers[i] * numbers[i];
    }
    return sum;
}
```

**Версия 2: Parallel.ForEach**
```csharp
public static long ParallelSum(int[] numbers, int degreeOfParallelism = -1)
{
    long sum = 0;
    object lockObj = new object();
    
    var options = new ParallelOptions
    {
        MaxDegreeOfParallelism = degreeOfParallelism == -1 
            ? Environment.ProcessorCount 
            : degreeOfParallelism
    };
    
    Parallel.ForEach(numbers, options, number =>
    {
        if (number % 2 == 0)
        {
            lock (lockObj)
            {
                sum += (long)number * number;
            }
        }
    });
    
    return sum;
}
```

**Версия 3: PLINQ**
```csharp
public static long PLinqSum(int[] numbers, int degreeOfParallelism = -1)
{
    return numbers
        .AsParallel()
        .WithDegreeOfParallelism(degreeOfParallelism == -1 
            ? Environment.ProcessorCount 
            : degreeOfParallelism)
        .Where(n => n % 2 == 0)
        .AsEnumerable()
        .Sum(n => (long)n * n);
}
```

**Программа тестирования:**
```csharp
public static void Main()
{
    int[] numbers = new int[10_000_000];
    Random rand = new Random();
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = rand.Next();
    
    Console.WriteLine("Тестирование 3 подходов параллелизма\\n");
    
    // Тест 1: Последовательный
    var sw = Stopwatch.StartNew();
    long result1 = SequentialSum(numbers);
    sw.Stop();
    Console.WriteLine($"Sequential: {sw.ElapsedMilliseconds} ms - {result1}");
    
    // Тест 2: Parallel.ForEach
    sw.Restart();
    long result2 = ParallelSum(numbers);
    sw.Stop();
    Console.WriteLine($"Parallel.ForEach: {sw.ElapsedMilliseconds} ms - {result2}");
    
    // Тест 3: PLINQ
    sw.Restart();
    long result3 = PLinqSum(numbers);
    sw.Stop();
    Console.WriteLine($"PLINQ: {sw.ElapsedMilliseconds} ms - {result3}");
    
    // Тест с изменением степени параллелизма
    Console.WriteLine("\\nТест с разными DegreeOfParallelism:");
    for (int dop = 1; dop <= Environment.ProcessorCount; dop++)
    {
        sw.Restart();
        long result = ParallelSum(numbers, dop);
        sw.Stop();
        Console.WriteLine($"DOP={dop}: {sw.ElapsedMilliseconds} ms");
    }
}
```

**Ожидаемый результат:**
```
Тестирование 3 подходов параллелизма

Sequential: 145 ms
Parallel.ForEach: 52 ms (2.8x быстрее)
PLINQ: 38 ms (3.8x быстрее)

Тест с разными DegreeOfParallelism:
DOP=1: 135 ms
DOP=2: 82 ms
DOP=4: 45 ms
DOP=8: 40 ms
DOP=16: 42 ms

Вывод: оптимальный DOP = 8 (количество ядер)
```

---

### Задача 3: Обработчик вложенных циклов

**Описание:**
Создайте программу для поиска всех пифагоровых троек (a² + b² = c²) в диапазоне от 1 до N. Реализуйте три версии: 1) с тремя вложенными циклами (brute force), 2) с оптимизацией через два цикла и вычисление третьего числа, 3) с использованием формул Евклида. Сравните производительность для N = 1000.

**Требования:**
- Найти все комбинации (a, b, c) где a² + b² = c²
- Избегать дубликатов (например, (3,4,5) и (4,3,5))
- Измерить время выполнения для каждого подхода
- Визуализировать результаты

**Версия 1: Brute Force (три цикла)**
```csharp
public static List<(int, int, int)> PythagoreanTriplesBruteForce(int n)
{
    var result = new List<(int, int, int)>();
    
    for (int a = 1; a <= n; a++)
    {
        for (int b = a; b <= n; b++)  // b >= a чтобы избежать дубликатов
        {
            for (int c = b; c <= n; c++)
            {
                if (a * a + b * b == c * c)
                    result.Add((a, b, c));
            }
        }
    }
    
    return result;
}
// Временная сложность: O(n³)
```

**Версия 2: Оптимизированный подход (два цикла)**
```csharp
public static List<(int, int, int)> PythagoreanTriplesOptimized(int n)
{
    var result = new List<(int, int, int)>();
    
    for (int a = 1; a <= n; a++)
    {
        for (int b = a; b <= n; b++)
        {
            int c_squared = a * a + b * b;
            int c = (int)Math.Sqrt(c_squared);
            
            // Проверяем, является ли c точным квадратным корнем
            if (c * c == c_squared && c <= n)
                result.Add((a, b, c));
        }
    }
    
    return result;
}
// Временная сложность: O(n²)
```

**Версия 3: Формулы Евклида**
```csharp
public static List<(int, int, int)> PythagoreanTriplesEuclid(int n)
{
    var result = new List<(int, int, int)>();
    
    // Формула Евклида: для любых m > n > 0
    // a = m² - n²
    // b = 2mn
    // c = m² + n²
    
    for (int m = 2; m * m < n * 2; m++)
    {
        for (int n_var = 1; n_var < m; n_var++)
        {
            int a = m * m - n_var * n_var;
            int b = 2 * m * n_var;
            int c = m * m + n_var * n_var;
            
            if (c <= n)
            {
                // Сортируем a и b, чтобы a < b
                if (a > b)
                    (a, b) = (b, a);
                result.Add((a, b, c));
            }
        }
    }
    
    // Генерируем кратные тройки
    var primitives = new List<(int, int, int)>(result);
    foreach (var (a, b, c) in primitives)
    {
        int k = 2;
        while (k * c <= n)
        {
            result.Add((k * a, k * b, k * c));
            k++;
        }
    }
    
    return result.Distinct().OrderBy(t => t.Item3).ToList();
}
// Временная сложность: O(n)
```

**Программа тестирования:**
```csharp
public static void Main()
{
    int n = 1000;
    var sw = Stopwatch.StartNew();
    
    // Версия 1: Brute Force
    sw.Restart();
    var result1 = PythagoreanTriplesBruteForce(n);
    sw.Stop();
    Console.WriteLine($"Brute Force: {sw.ElapsedMilliseconds} ms, найдено {result1.Count} троек");
    
    // Версия 2: Оптимизированный
    sw.Restart();
    var result2 = PythagoreanTriplesOptimized(n);
    sw.Stop();
    Console.WriteLine($"Optimized: {sw.ElapsedMilliseconds} ms, найдено {result2.Count} троек");
    
    // Версия 3: Euclid
    sw.Restart();
    var result3 = PythagoreanTriplesEuclid(n);
    sw.Stop();
    Console.WriteLine($"Euclid: {sw.ElapsedMilliseconds} ms, найдено {result3.Count} троек");
    
    // Вывод первых 10 троек
    Console.WriteLine("\\nПервые 10 пифагоровых троек:");
    foreach (var (a, b, c) in result3.Take(10))
    {
        Console.WriteLine($"({a}, {b}, {c}) - проверка: {a}² + {b}² = {c}² => {a*a} + {b*b} = {c*c}");
    }
}
```

**Ожидаемый результат:**
```
Brute Force: 8450 ms, найдено 50 троек
Optimized: 120 ms, найдено 50 троек
Euclid: 8 ms, найдено 50 троек

Первые 10 пифагоровых троек:
(3, 4, 5) - проверка: 3² + 4² = 5² => 9 + 16 = 25
(5, 12, 13) - проверка: 5² + 12² = 13² => 25 + 144 = 169
(8, 15, 17) - проверка: 8² + 15² = 17² => 64 + 225 = 289
...

Ускорение Euclid vs Brute Force: 1056x
```

---

## Требования к выполнению всех практических задач

### 1. Качество кода

- **Читаемость:** Используйте осмысленные имена переменных и методов
- **Структура:** Разбейте код на небольшие методы (Single Responsibility Principle)
- **Комментарии:** Документируйте сложные алгоритмы и важные части
- **Стиль:** Следуйте C# соглашениям о стиле кодирования
- **XML-комментарии:** Добавляйте для публичного API

### 2. Функциональность

- Программа должна корректно работать на всех тестовых случаях
- Обработка граничных случаев (пустые данные, null, отрицательные значения)
- Валидация входных данных с информативными сообщениями об ошибках
- Обработка исключений с логированием

### 3. Производительность

- Анализ временной сложности O() для алгоритмов
- Анализ пространственной сложности
- Оптимизация горячих участков кода
- Избегание лишних копирований данных
- Правильное использование структур данных

### 4. Тестирование

```csharp
[TestClass]
public class AlgorithmTests
{
    [TestMethod]
    public void TestBinarySearch_Found()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int index = BinarySearch(array, 5);
        Assert.AreEqual(2, index);
    }
    
    [TestMethod]
    public void TestBinarySearch_NotFound()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int index = BinarySearch(array, 4);
        Assert.AreEqual(-1, index);
    }
    
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void TestBinarySearch_NullArray()
    {
        BinarySearch(null, 5);
    }
}
```

### 5. Документация

- Описание алгоритма на русском языке
- Сложность: O(f(n)) по времени и памяти
- Примеры входных/выходных данных
- Известные ограничения и особенности

### 6. Измеренияпроизводительности

```csharp
var sw = Stopwatch.StartNew();

// Выполнение алгоритма
var result = Algorithm(data);

sw.Stop();
Console.WriteLine($"Время: {sw.ElapsedMilliseconds} ms");
Console.WriteLine($"Результат: {result}");
```

---

## Критерии оценки

### Каждая задача оценивается по:

1. **Корректность (40 баллов)**
   - 40 - работает на всех тестах
   - 30 - работает на большинстве тестов
   - 20 - работает на базовых случаях
   - 10 - частичное решение
   - 0 - не работает

2. **Качество кода (30 баллов)**
   - 30 - отличная структура, чистый код
   - 25 - хорошая структура
   - 20 - приемлемая структура
   - 10 - плохая структура
   - 0 - нечитаемый код

3. **Оптимизация (20 баллов)**
   - 20 - оптимальная сложность
   - 15 - хорошая оптимизация
   - 10 - приемлемая оптимизация
   - 5 - есть явные неоптимальности
   - 0 - очень плохая оптимизация

4. **Тесты (10 баллов)**
   - 10 - полное покрытие edge cases
   - 8 - хорошее покрытие
   - 5 - базовые тесты
   - 2 - минимальные тесты
   - 0 - нет тестов

### Итоговая оценка

- 95-100 баллов: **5 (Отлично)**
- 85-94 балла: **4 (Хорошо)**
- 75-84 балла: **3 (Удовлетворительно)**
- менее 75 баллов: **2 (Неудовлетворительно)**

---

## Рекомендации по подготовке

1. **Изучите теорию** перед каждой задачей
2. **Напишите простое решение** перед оптимизацией
3. **Тестируйте часто** во время разработки
4. **Используйте Profiler** для поиска узких мест
5. **Проверьте граничные случаи**
6. **Документируйте код**

---

**Удачи на экзамене!**
