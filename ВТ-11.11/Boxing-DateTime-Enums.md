# C# Задания: упаковка/распаковка, DateTime/TimeSpan, вариантность, перечисления (100 заданий + Решения)

## Обзор

Этот файл содержит 100 практических заданий по современным темам C# с примерами по boxing/unboxing, различным видам упаковки, работе с DateTime/TimeSpan, ковариантности/контрвариантности и продвинутыми сценариями использования перечислений. В конце приведены решения 5 случайных задач.

---
## 📚 Структура материала

### Раздел 1: Упаковка и распаковка (задания 1-20)
1. ...
5. Реализуйте коллекцию ArrayList с примерами упаковки различных типов значений
9. Реализуйте метод, который принимает params object[] и обрабатывает упакованные значения
...

### Раздел 2: Виды упаковки (задания 21-40)
...
31. Создайте пример упаковки при работе с динамическими типами (dynamic)
33. Создайте пример упаковки при использовании String.Format с типами значений
...

### Раздел 3: Работа со структурами DateTime и TimeSpan (41-60)
...

### Раздел 4: Ковариантность и контрвариантность (61-80)
...

### Раздел 5: Перечисления (81-100)
...
83. Создайте флаговое перечисление [Flags] FilePermissions с операциями OR, AND
...

---

# ✅ Решения 5 случайных заданий

## 5. Реализуйте коллекцию ArrayList с примерами упаковки различных типов значений

```csharp
using System;
using System.Collections;

class BoxingDemo
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(100);        // int -> boxing
        list.Add(true);       // bool -> boxing
        list.Add(3.14);       // double -> boxing
        list.Add("hello");   // string (reference type, no boxing)
        
        // Демонстрация
        foreach (object o in list)
        {
            Console.WriteLine($"В коллекции: {o} ({o.GetType().Name})");
        }

        // Распаковка
        int unboxedInt = (int)list[0];
        bool unboxedBool = (bool)list[1];
        double unboxedDouble = (double)list[2];

        Console.WriteLine($"unboxedInt: {unboxedInt}, unboxedBool: {unboxedBool}, unboxedDouble: {unboxedDouble}");
    }
}
```

## 9. Реализуйте метод, который принимает params object[] и обрабатывает упакованные значения

```csharp
using System;

class ObjectParamsDemo
{
    static void PrintParams(params object[] items)
    {
        foreach (object item in items)
        {
            switch (item)
            {
                case int i:
                    Console.WriteLine($"int: {i}");
                    break;
                case double d:
                    Console.WriteLine($"double: {d}");
                    break;
                case bool b:
                    Console.WriteLine($"bool: {b}");
                    break;
                case string s:
                    Console.WriteLine($"string: '{s}'");
                    break;
                default:
                    Console.WriteLine($"object: {item}");
                    break;
            }
        }
    }
}

// Использование
ObjectParamsDemo.PrintParams(5, 3.14, true, "abc", new DateTime(2025, 1, 1));
```

## 31. Создайте пример упаковки при работе с динамическими типами (dynamic)

```csharp
using System;

class DynamicBoxingDemo
{
    public static void Main()
    {
        int value = 123;
        dynamic d = value; // boxing, поскольку dynamic хранит как object
        Console.WriteLine(d);
        Console.WriteLine(d.GetType()); // System.Int32

        // Повторное присваивание
        d = "hello";
        Console.WriteLine(d);
        Console.WriteLine(d.GetType()); // System.String
    }
}
```

## 33. Создайте пример упаковки при использовании String.Format с типами значений

```csharp
using System;

class StringFormatBoxingDemo
{
    public static void Main()
    {
        int x = 42;
        double y = 3.14;
        // boxing происходит у int и double
        string result = String.Format("Ответ: {0}, PI: {1}", x, y);
        Console.WriteLine(result);
    }
}
```

## 83. Создайте флаговое перечисление [Flags] FilePermissions с операциями OR, AND

```csharp
using System;

[Flags]
enum FilePermissions
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    Delete = 8
}

class EnumFlagsDemo
{
    static void Main()
    {
        FilePermissions perm = FilePermissions.Read | FilePermissions.Write;
        Console.WriteLine($"Read+Write: {perm}"); // Read, Write

        // Проверка наличия прав
        bool canWrite = (perm & FilePermissions.Write) != 0;
        Console.WriteLine($"Can write: {canWrite}");

        // Добавить Execute
        perm |= FilePermissions.Execute;
        Console.WriteLine($"With execute: {perm}"); // Read, Write, Execute

        // Убрать Write
        perm &= ~FilePermissions.Write;
        Console.WriteLine($"No write: {perm}"); // Read, Execute
    }
}
```

---

## 📋 Рекомендации и ссылки
- Старайтесь всегда выбирать типизированные коллекции для избежания boxing/unboxing (например, List<int>).
- Всегда проверяйте тип перед распаковкой object.
- Для работы с enum-флагами используйте логические операции по битам.
- Для современных проектов используйте generic-коллекции, enum-флаги и возможности .NET 6+.
- Подробнее:
    - [Boxing и Unboxing в C# (Microsoft Docs)](https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/types/boxing-and-unboxing)
    - [Официальная документация по DateTime](https://learn.microsoft.com/ru-ru/dotnet/api/system.datetime)
    - [Официальная документация по TimeSpan](https://learn.microsoft.com/ru-ru/dotnet/api/system.timespan)
    - [Вариантность и ковариантность дженериков](https://learn.microsoft.com/ru-ru/dotnet/standard/generics/covariance-and-contravariance)
    - [Перечисления](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/enum)

**Успехов в практике C#!**