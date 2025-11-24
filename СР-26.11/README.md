# C# Потоки (Threads)

## Краткое описание Потоков в C#

**Многопоточность (Multithreading)** — это способность программы выполнять несколько операций одновременно в отдельных потоках выполнения. В C# доступны несколько подходов к работе с потоками:

### Основные подходы к многопоточности:

1. **Thread** — классический способ создания потоков низкого уровня
2. **Task** — высокоуровневый способ представления асинхронной работы (рекомендуется)
3. **Async/Await** — современный синтаксис для асинхронного программирования
4. **Parallel** — параллельное выполнение циклов и методов
5. **PLINQ** — параллельный LINQ для обработки данных

### Ключевые концепции:

- **Синхронизация** — предотвращение race condition через lock, Mutex, Semaphore
- **CancellationToken** — корректная отмена операций
- **ThreadPool** — пул переиспользуемых потоков для эффективности
- **Потокобезопасные коллекции** — ConcurrentDictionary, ConcurrentQueue, BlockingCollection
- **Интеракции потоков** — EventWaitHandle, ManualResetEvent, AutoResetEvent

### Когда использовать:

| Подход | Когда использовать |
|--------|-------------------|
| Thread | Редко, только для специальных случаев |
| Task | Для асинхронных операций (рекомендуется) |
| Async/Await | Для выстраивания асинхронных операций |
| Parallel | Для параллельной обработки данных |
| PLINQ | Для параллельных LINQ запросов |

---

### Категория 1: Thread Basics (Основы Thread)

**Задание 1 (Beginner):** Создайте новый поток, который выведет на консоль сообщение 'Привет из потока'

**Задание 2 (Beginner):** Запустите два потока последовательно и дождитесь завершения обоих с помощью Join()

**Задание 3 (Beginner):** Получите ID текущего потока и выведите его на консоль

**Задание 4 (Intermediate):** Создайте параллельное выполнение трех операций, каждая займет разное время

**Задание 5 (Beginner):** Передайте параметр в метод нового потока через конструктор ParameterizedThreadStart

**Задание 6 (Intermediate):** Установите приоритет потока (ThreadPriority) и посмотрите, как это влияет на выполнение

**Задание 7 (Beginner):** Остановите поток с помощью задержки Thread.Sleep(1000)

**Задание 8 (Intermediate):** Создайте фоновый поток (IsBackground = true) и основной поток

**Задание 9 (Beginner):** Вывести имя текущего потока на консоль

**Задание 10 (Intermediate):** Создайте несколько потоков и синхронизируйте вывод результатов

### Категория 2: Task Basics (Основы Task)

**Задание 11 (Beginner):** Создайте и запустите простую Task с помощью Task.Run()

**Задание 12 (Beginner):** Ожидайте завершение Task используя Task.Wait()

**Задание 13 (Intermediate):** Создайте Task, которая возвращает результат (Task<T>)

**Задание 14 (Beginner):** Запустите несколько Task и ожидайте все с помощью Task.WaitAll()

**Задание 15 (Intermediate):** Используйте Task.WhenAll() для асинхронного ожидания нескольких задач

**Задание 16 (Intermediate):** Используйте ContinueWith() для цепочки задач

**Задание 17 (Beginner):** Ожидайте любую из нескольких задач с помощью Task.WaitAny()

**Задание 18 (Intermediate):** Используйте Task.WhenAny() для асинхронного ожидания первого результата

**Задание 19 (Intermediate):** Создайте Task, которая выбрасывает исключение и обработайте его

**Задание 20 (Intermediate):** Используйте TaskScheduler для управления выполнением Task

### Категория 3: Async/Await

**Задание 21 (Beginner):** Создайте асинхронный метод с async/await

**Задание 22 (Beginner):** Используйте await для ожидания асинхронного метода

**Задание 23 (Intermediate):** Создайте асинхронный метод, возвращающий результат (async Task<T>)

**Задание 24 (Beginner):** Используйте Task.Delay() для асинхронной задержки

**Задание 25 (Intermediate):** Обработайте исключение в асинхронном методе

**Задание 26 (Intermediate):** Используйте ConfigureAwait(false) для освобождения контекста

**Задание 27 (Intermediate):** Создайте цепочку асинхронных операций

**Задание 28 (Intermediate):** Используйте async void только для обработчиков событий

**Задание 29 (Intermediate):** Преобразуйте синхронный метод в асинхронный

**Задание 30 (Advanced):** Используйте Task.FromResult() для возврата готового результата

### Категория 4: Lock Synchronization (Lock Синхронизация)

**Задание 31 (Intermediate):** Используйте lock для защиты общей переменной от race condition

**Задание 32 (Intermediate):** Создайте критическую секцию с lock для счетчика

**Задание 33 (Intermediate):** Демонстрируйте deadlock при использовании вложенных lock

**Задание 34 (Advanced):** Избегайте deadlock при использовании нескольких lock

**Задание 35 (Intermediate):** Используйте lock с разными объектами для защиты разных данных

**Задание 36 (Intermediate):** Создайте потокобезопасный класс Counter с lock

**Задание 37 (Advanced):** Используйте ReaderWriterLockSlim для оптимизированного доступа

**Задание 38 (Intermediate):** Сравните производительность lock с другими методами синхронизации

**Задание 39 (Intermediate):** Используйте lock для синхронизации доступа к коллекции

**Задание 40 (Advanced):** Реализуйте паттерн "Читатели-писатели" с lock

### Категория 5: Mutex/Semaphore

**Задание 41 (Intermediate):** Используйте Mutex для синхронизации между потоками

**Задание 42 (Intermediate):** Используйте WaitOne() для получения Mutex

**Задание 43 (Intermediate):** Используйте Semaphore для ограничения количества потоков

**Задание 44 (Intermediate):** Реализуйте пул ограниченного количества ресурсов с Semaphore

**Задание 45 (Intermediate):** Используйте SemaphoreSlim для асинхронного ограничения

**Задание 46 (Intermediate):** Обработайте AbandonedMutexException при завершении потока

**Задание 47 (Advanced):** Используйте NamedMutex для синхронизации между процессами

**Задание 48 (Intermediate):** Сравните производительность Mutex и lock

**Задание 49 (Intermediate):** Используйте CountdownEvent для синхронизации

**Задание 50 (Intermediate):** Используйте ManualResetEvent для управления сигналами

### Категория 6: CancellationToken (Отмена операций)

**Задание 51 (Intermediate):** Используйте CancellationToken для отмены потока

**Задание 52 (Intermediate):** Создайте CancellationTokenSource и отмените операцию

**Задание 53 (Intermediate):** Используйте ThrowIfCancellationRequested() для проверки отмены

**Задание 54 (Intermediate):** Используйте timeout для автоматической отмены операции

**Задание 55 (Intermediate):** Обработайте OperationCanceledException при отмене

**Задание 56 (Intermediate):** Используйте register() для выполнения действия при отмене

**Задание 57 (Advanced):** Используйте CancellationToken в Task.Delay и других операциях

**Задание 58 (Advanced):** Реализуйте graceful shutdown приложения с CancellationToken

### Категория 7: ThreadPool

**Задание 59 (Intermediate):** Используйте ThreadPool.QueueUserWorkItem для выполнения работы

**Задание 60 (Intermediate):** Получите информацию о размере ThreadPool

**Задание 61 (Intermediate):** Установите минимальное и максимальное количество потоков в пуле

**Задание 62 (Intermediate):** Используйте RegisterWaitForSingleObject для асинхронного ожидания

**Задание 63 (Intermediate):** Сравните использование ThreadPool vs Task

**Задание 64 (Intermediate):** Используйте GetAvailableThreads для мониторинга пула

**Задание 65 (Advanced):** Реализуйте собственный пул потоков с Queue

**Задание 66 (Intermediate):** Используйте IOCompletionPort для асинхронного I/O

### Категория 8: Parallel

**Задание 67 (Intermediate):** Используйте Parallel.For для параллельного цикла

**Задание 68 (Intermediate):** Используйте Parallel.ForEach для параллельной итерации

**Задание 69 (Intermediate):** Используйте Parallel.Invoke для параллельного вызова методов

**Задание 70 (Intermediate):** Установите количество потоков в Parallel.For с ParallelOptions

**Задание 71 (Intermediate):** Используйте CancellationToken в Parallel.For

**Задание 72 (Advanced):** Используйте Partitioner для оптимизации Parallel.ForEach

**Задание 73 (Intermediate):** Обработайте OperationCanceledException в Parallel операциях

**Задание 74 (Advanced):** Реализуйте divide-and-conquer алгоритм с Parallel.Invoke

**Задание 75 (Intermediate):** Сравните производительность Parallel vs обычные циклы

**Задание 76 (Advanced):** Используйте ParallelOptions для настройки поведения

### Категория 9: PLINQ

**Задание 77 (Intermediate):** Используйте AsParallel() для параллельного LINQ запроса

**Задание 78 (Intermediate):** Используйте WithDegreeOfParallelism() для ограничения потоков

**Задание 79 (Intermediate):** Используйте WithCancellation() для отмены PLINQ запроса

**Задание 80 (Intermediate):** Используйте ParallelEnumerable для параллельной обработки

**Задание 81 (Advanced):** Сравните производительность PLINQ vs обычный LINQ

**Задание 82 (Intermediate):** Используйте ToList() для материализации результатов PLINQ

### Категория 10: Thread-Safe Collections

**Задание 83 (Intermediate):** Используйте ConcurrentDictionary вместо Dictionary

**Задание 84 (Intermediate):** Используйте ConcurrentQueue для очереди между потоками

**Задание 85 (Intermediate):** Используйте ConcurrentBag для накопления результатов

**Задание 86 (Intermediate):** Используйте BlockingCollection для producer-consumer паттерна

**Задание 87 (Advanced):** Реализуйте producer-consumer с BlockingCollection

**Задание 88 (Intermediate):** Используйте ConcurrentStack для параллельной работы со стеком

**Задание 89 (Advanced):** Сравните производительность потокобезопасных коллекций

**Задание 90 (Intermediate):** Используйте TryAdd и TryRemove в ConcurrentDictionary

### Категория 11: Interlocked Operations

**Задание 91 (Intermediate):** Используйте Interlocked.Increment для атомарного увеличения

**Задание 92 (Intermediate):** Используйте Interlocked.CompareExchange для условной замены

**Задание 93 (Intermediate):** Сравните Interlocked операции с lock

**Задание 94 (Advanced):** Реализуйте spinlock с Interlocked операциями

**Задание 95 (Intermediate):** Используйте Interlocked.Read для чтения значения

**Задание 96 (Intermediate):** Используйте Interlocked.Exchange для обмена значениями

### Категория 12: EventWaitHandle

**Задание 97 (Intermediate):** Используйте AutoResetEvent для сигнализации между потоками

**Задание 98 (Intermediate):** Используйте ManualResetEvent для управления группой потоков

**Задание 99 (Advanced):** Используйте WaitHandle.WaitAll для ожидания нескольких событий

**Задание 100 (Advanced):** Реализуйте паттерн "Producer-Consumer" с EventWaitHandle

---

### ✅ Решение Задания #10: Thread Basics (Intermediate)
**Текст:** Создайте несколько потоков и синхронизируйте вывод результатов

```csharp
using System;
using System.Threading;

class Program
{
    private static object lockObject = new object(); // объект для синхронизации

    static void Main()
    {
        // Создание трех потоков
        Thread thread1 = new Thread(() => PrintMessage("Поток 1"));
        Thread thread2 = new Thread(() => PrintMessage("Поток 2"));
        Thread thread3 = new Thread(() => PrintMessage("Поток 3"));

        // Запуск потоков
        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Ожидание завершения всех потоков
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершены");
    }

    static void PrintMessage(string message)
    {
        // Синхронизация доступа для предотвращения перемешивания вывода
        lock (lockObject)
        {
            Console.WriteLine($"[ID: {Thread.CurrentThread.ManagedThreadId}] {message}");
            Thread.Sleep(100);
        }
    }
}

// Вывод:
// [ID: 3] Поток 1
// [ID: 4] Поток 2
// [ID: 5] Поток 3
// Все потоки завершены
```

**Описание:** Использование lock для синхронизации вывода из разных потоков предотвращает перемешивание текста. Join() ожидает завершения каждого потока перед продолжением основного потока.

---

### ✅ Решение Задания #14: Task Basics (Beginner)
**Текст:** Запустите несколько Task и ожидайте все с помощью Task.WaitAll()

```csharp
using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Создание и запуск нескольких Task
        Task task1 = Task.Run(() => DoWork(1, 1000));
        Task task2 = Task.Run(() => DoWork(2, 2000));
        Task task3 = Task.Run(() => DoWork(3, 1500));
        Task task4 = Task.Run(() => DoWork(4, 500));

        // Способ 1: Использование Task.WaitAll() - синхронное ожидание
        Console.WriteLine("Ожидание всех задач с помощью WaitAll...");
        Task.WaitAll(task1, task2, task3, task4);
        Console.WriteLine("Все задачи завершены!");

        // Способ 2: Создание массива задач
        Task[] tasks = new Task[]
        {
            Task.Run(() => DoWork(5, 800)),
            Task.Run(() => DoWork(6, 1200))
        };

        Task.WaitAll(tasks);
        Console.WriteLine("Все задачи из массива завершены!");
    }

    static void DoWork(int taskNumber, int delayMs)
    {
        System.Threading.Thread.Sleep(delayMs);
        Console.WriteLine($"Задача {taskNumber} завершена (задержка {delayMs}ms)");
    }
}

// Вывод:
// Ожидание всех задач с помощью WaitAll...
// Задача 4 завершена (задержка 500ms)
// Задача 1 завершена (задержка 1000ms)
// Задача 3 завершена (задержка 1500ms)
// Задача 2 завершена (задержка 2000ms)
// Все задачи завершены!
// Задача 5 завершена (задержка 800ms)
// Задача 6 завершена (задержка 1200ms)
// Все задачи из массива завершены!
```

**Описание:** Task.WaitAll() блокирует текущий поток до завершения всех переданных задач. Это полезно, когда нужно убедиться, что все операции завершены перед продолжением.

---

### ✅ Решение Задания #21: Async/Await (Beginner)
**Текст:** Создайте асинхронный метод с async/await

```csharp
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine($"Главный поток: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        
        // Вызов асинхронного метода с await
        await DoWorkAsync();
        
        Console.WriteLine("Работа завершена");
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine($"Начало асинхронной работы на потоке: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        
        // Асинхронная задержка (не блокирует поток)
        await Task.Delay(2000);
        
        Console.WriteLine($"После Task.Delay на потоке: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        
        // Вызов другого асинхронного метода
        string result = await FetchDataAsync();
        Console.WriteLine($"Результат: {result}");
    }

    static async Task<string> FetchDataAsync()
    {
        Console.WriteLine($"Получение данных на потоке: {System.Threading.Thread.CurrentThread.ManagedThreadId}");
        
        await Task.Delay(1000); // Имитация асинхронной операции
        
        return "Данные успешно получены!";
    }
}

// Вывод:
// Главный поток: 1
// Начало асинхронной работы на потоке: 1
// После Task.Delay на потоке: 1 (возможно другой, но часто тот же)
// Получение данных на потоке: 1
// Результат: Данные успешно получены!
// Работа завершена
```

**Описание:** Асинхронный метод с async/await позволяет освободить поток во время ожидания. await приостанавливает выполнение метода, пока задача не завершится, затем продолжает выполнение без блокировки потока.

---

### ✅ Решение Задания #32: Lock Synchronization (Intermediate)
**Текст:** Создайте критическую секцию с lock для счетчика

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static int counter = 0;
    private static object lockObject = new object();

    static void Main()
    {
        // БЕЗ СИНХРОНИЗАЦИИ - неправильный результат
        Console.WriteLine("=== БЕЗ СИНХРОНИЗАЦИИ (НЕПРАВИЛЬНО) ===");
        counter = 0;
        RunWithoutLock();
        Console.WriteLine($"Результат без синхронизации: {counter} (должно быть 10000)");

        // С СИНХРОНИЗАЦИЕЙ - правильный результат
        Console.WriteLine("\n=== С СИНХРОНИЗАЦИЕЙ (ПРАВИЛЬНО) ===");
        counter = 0;
        RunWithLock();
        Console.WriteLine($"Результат с синхронизацией: {counter}");
    }

    static void RunWithoutLock()
    {
        Task[] tasks = new Task[10];
        for (int i = 0; i < 10; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    counter++; // Race condition!
                }
            });
        }
        Task.WaitAll(tasks);
    }

    static void RunWithLock()
    {
        Task[] tasks = new Task[10];
        for (int i = 0; i < 10; i++)
        {
            tasks[i] = Task.Run(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    lock (lockObject)
                    {
                        counter++; // Потокобезопасно!
                    }
                }
            });
        }
        Task.WaitAll(tasks);
    }
}

// Вывод (примерный):
// === БЕЗ СИНХРОНИЗАЦИИ (НЕПРАВИЛЬНО) ===
// Результат без синхронизации: 7234 (неправильно, должно быть 10000)
//
// === С СИНХРОНИЗАЦИЕЙ (ПРАВИЛЬНО) ===
// Результат с синхронизацией: 10000
```

**Описание:** Lock создает критическую секцию, в которой только один поток может выполняться одновременно. Без lock происходит race condition, и счетчик не считается правильно.

---

### ✅ Решение Задания #41: Mutex/Semaphore (Intermediate)
**Текст:** Используйте Mutex для синхронизации между потоками

```csharp
using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    // Mutex для синхронизации доступа к общему ресурсу
    private static Mutex mutex = new Mutex();
    private static int sharedResource = 0;

    static void Main()
    {
        Console.WriteLine("=== Пример 1: Базовое использование Mutex ===");
        
        // Создание нескольких потоков
        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++)
        {
            int taskNumber = i + 1;
            tasks[i] = Task.Run(() => AccessSharedResource(taskNumber));
        }

        Task.WaitAll(tasks);
        Console.WriteLine($"\nИтоговое значение sharedResource: {sharedResource}");

        // Пример 2: Использование TryWaitOne с timeout
        Console.WriteLine("\n=== Пример 2: TryWaitOne с timeout ===");
        
        if (mutex.WaitOne(1000)) // Ждем максимум 1 секунду
        {
            try
            {
                Console.WriteLine("Получена блокировка Mutex");
                System.Threading.Thread.Sleep(500);
            }
            finally
            {
                mutex.ReleaseMutex();
                Console.WriteLine("Блокировка Mutex освобождена");
            }
        }
        else
        {
            Console.WriteLine("Не удалось получить блокировку за отведенное время");
        }
    }

    static void AccessSharedResource(int taskNumber)
    {
        // Попытка получить Mutex
        Console.WriteLine($"Задача {taskNumber}: попытка получить Mutex...");
        
        mutex.WaitOne(); // Ждем, пока Mutex будет доступен
        
        try
        {
            Console.WriteLine($"Задача {taskNumber}: получила Mutex");
            
            // Критическая секция
            sharedResource++;
            Console.WriteLine($"Задача {taskNumber}: увеличила sharedResource до {sharedResource}");
            
            System.Threading.Thread.Sleep(200); // Имитация работы
        }
        finally
        {
            mutex.ReleaseMutex();
            Console.WriteLine($"Задача {taskNumber}: освободила Mutex");
        }
    }
}

// Вывод (примерный):
// === Пример 1: Базовое использование Mutex ===
// Задача 1: попытка получить Mutex...
// Задача 1: получила Mutex
// Задача 2: попытка получить Mutex...
// Задача 3: попытка получить Mutex...
// Задача 4: попытка получить Mutex...
// Задача 5: попытка получить Mutex...
// Задача 1: увеличила sharedResource до 1
// Задача 1: освободила Mutex
// Задача 2: получила Mutex
// Задача 2: увеличила sharedResource до 2
// Задача 2: освободила Mutex
// ...
//
// Итоговое значение sharedResource: 5
//
// === Пример 2: TryWaitOne с timeout ===
// Получена блокировка Mutex
// Блокировка Mutex освобождена
```

**Описание:** Mutex (взаимное исключение) используется для защиты критических секций. WaitOne() блокирует поток до получения блокировки, а ReleaseMutex() освобождает ее для других потоков. Это похоже на lock, но Mutex может быть именованным и использоваться между процессами.

---

## РЕКОМЕНДАЦИИ ДЛЯ ПРАКТИКИ

### Для начинающих:
1. Начните с заданий **Thread Basics** и **Task Basics** (1-20)
2. Изучите простые примеры async/await (21-30)
3. Практикуйтесь с lock для синхронизации (31-40)

### Для продвинутых:
1. Переходите к Mutex/Semaphore (41-50)
2. Изучите CancellationToken для корректной отмены (51-58)
3. Практикуйте Parallel и PLINQ (67-82)

### Лучшие практики:
- **Используйте Task вместо Thread** — Task более эффективен благодаря пулу потоков
- **Используйте async/await** — современный, читаемый и безопасный подход
- **Всегда используйте CancellationToken** — для корректной отмены операций
- **Предпочитайте потокобезопасные коллекции** — ConcurrentDictionary, BlockingCollection
- **Избегайте deadlock** — не держите несколько блокировок одновременно
- **Тестируйте многопоточный код** — используйте инструменты отладки
- **Документируйте потокобезопасность** — указывайте, какие методы потокобезопасны

### Производительность:
- Task создает меньше операционных потоков благодаря ThreadPool
- async/await не создает новый поток, освобождает существующий
- Parallel хорош для CPU-bound операций
- async хорош для I/O-bound операций

## ЧАСТЫЕ ОШИБКИ

1. **Использование Thread вместо Task** — неэффективно
2. **async void** вне обработчиков событий — трудно обрабатывать исключения
3. **Забывать об отмене** — может привести к ресурсам утечкам
4. **Вложенные lock** — риск deadlock
5. **Игнорировать потокобезопасность коллекций** — race condition

---
