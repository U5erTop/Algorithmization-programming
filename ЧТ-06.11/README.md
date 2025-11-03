### Раздел 1: Рассмотрение структур

Введение в основы структур: объявление, инициализация, использование полей и методов.

**Задания 1-25:**

1. Создайте простую структуру Point с полями X и Y типа double
2. Реализуйте структуру Rectangle с полями для ширины, высоты и методом расчета площади
3. Создайте структуру Color с полями R, G, B типа byte и методом для получения hex кода
4. Реализуйте структуру Date с полями Day, Month, Year и методом ToString
5. Создайте структуру Money с полями Amount и Currency, и методом для форматирования
6. Реализуйте структуру Temperature с полем Celsius и свойством для преобразования в Fahrenheit
7. Создайте структуру Vector3D с полями X, Y, Z и методами для векторных операций
8. Реализуйте структуру Size с полями Width и Height и методом для вычисления периметра
9. Создайте структуру Coordinate с двумя полями и методом расстояния до другой координаты
10. Реализуйте структуру PhoneNumber с полями для кода страны и номера
11. Создайте структуру Rating с полем от 1 до 5 и методом валидации
12. Реализуйте структуру Time с полями Hours, Minutes, Seconds и методом ToString
13. Создайте структуру Interval с начальным и конечным значением и методом длины
14. Реализуйте структуру ComplexNumber с действительной и мнимой частями
15. Создайте структуру Dimensions с методом для вычисления объема
16. Реализуйте структуру Pixel с координатами и цветом
17. Создайте структуру Angle с полем в градусах и методом преобразования в радианы
18. Реализуйте структуру Speed с полями значения и единицы измерения
19. Создайте структуру Weight с полем килограмм и методом конвертации в фунты
20. Реализуйте структуру Duration с полями дней, часов, минут, секунд
21. Создайте структуру Position с координатами и методом определения квадранта
22. Реализуйте структуру Fraction с числителем и знаменателем и методом упрощения
23. Создайте структуру Version с полями Major, Minor, Build
24. Реализуйте структуру DataSize с размером в байтах и методом форматирования (KB, MB, GB)
25. Создайте структуру GameScore с именем игрока и количеством очков

---

### Раздел 2: Конструкторы в структурах

Изучение конструкторов, инициализации полей, валидации данных и перегрузки конструкторов.

**Задания 26-50:**

26. Создайте структуру Point с несколькими конструкторами (без параметров, с двумя параметрами)
27. Реализуйте структуру Rectangle с конструктором для инициализации всех полей
28. Создайте структуру Color с конструктором для создания цвета из строки hex кода
29. Реализуйте структуру Person с конструктором с параметрами (Имя, Возраст, Город)
30. Создайте структуру Date с конструктором проверки корректности даты
31. Реализуйте структуру Money с конструктором и валидацией значения
32. Создайте структуру Vector с конструктором и методом инициализации компонент
33. Реализуйте структуру Time с конструктором и проверкой времени
34. Создайте структуру Book с конструктором (Название, Автор, Год, ISBN)
35. Реализуйте структуру Circle с конструктором центра и радиуса
36. Создайте структуру Product с конструктором (ID, Название, Цена, Количество)
37. Реализуйте структуру Triangle с конструктором трех сторон
38. Создайте структуру Student с конструктором заполнения данных студента
39. Реализуйте структуру Address с конструктором полного адреса
40. Создайте структуру BankAccount с конструктором номера счета и начального баланса
41. Реализуйте структуру Car с конструктором марка, модель, год выпуска
42. Создайте структуру PhoneNumber с конструктором парсинга строки
43. Реализуйте структуру Matrix с конструктором размерности матрицы
44. Создайте структуру Employee с конструктором ФИО, должность, зарплата
45. Реализуйте структуру Email с конструктором и валидацией
46. Создайте структуру Appointment с конструктором дата, время, описание
47. Реализуйте структуру Recipe с конструктором названия и ингредиентов
48. Создайте структуру SocialProfile с конструктором имя пользователя и платформа
49. Реализуйте структуру Measurement с конструктором значение и единица
50. Создайте структуру Password с конструктором и валидацией по сложности

---

### Раздел 3: Наследование в структурах

Реализация интерфейсов в структурах, сравнение, форматирование и стандартные интерфейсы.

**Задания 51-75:**

51. Создайте структуру Shape с методом Area, затем Point как производная структура
52. Реализуйте иерархию структур: Vehicle -> Car, Bicycle
53. Создайте структуру Animal с полем Name, затем Dog с методом Bark
54. Реализуйте интерфейс IComparable для структуры Point
55. Создайте структуру Number с интерфейсом IEquatable<Number>
56. Реализуйте структуру Employee наследующую интерфейс ICloneable
57. Создайте структуру Shape с интерфейсом IDrawable
58. Реализуйте структуру Person с интерфейсом IValidatable
59. Создайте структуру Document с интерфейсом ISaveable
60. Реализуйте структуру Container с интерфейсом IEnumerable
61. Создайте структуру Stream с интерфейсом IDisposable
62. Реализуйте сравнение структур через IComparable
63. Создайте структуру Money с интерфейсом IFormattable
64. Реализуйте структуру Event с интерфейсом для событий
65. Создайте структуру Logger с интерфейсом для логирования
66. Реализуйте структуру Collection с интерфейсом ICollection
67. Создайте структуру Observer с интерфейсом IObserver
68. Реализуйте структуру Service с интерфейсом IDisposable и финализатором
69. Создайте структуру Validator с интерфейсом для валидации
70. Реализуйте структуру Handler с интерфейсом обработчика событий
71. Создайте структуру Cache с интерфейсом ICacheable
72. Реализуйте структуру Parser с интерфейсом IParser
73. Создайте структуру Comparer с интерфейсом IComparer
74. Реализуйте структуру Serializable с интерфейсом ISerializable
75. Создайте структуру AsyncTask с интерфейсом для асинхронных операций

---

### Раздел 4: Вложенные структуры и классы

Работа с вложенными типами для создания сложных структур данных и улучшения инкапсуляции.

**Задания 76-100:**

76. Создайте структуру Company с вложенной структурой Employee
77. Реализуйте структуру Tree с вложенным классом Node
78. Создайте структуру Graph с вложенными классами Vertex и Edge
79. Реализуйте структуру Library с вложенной структурой Book
80. Создайте структуру Dictionary с вложенной структурой Entry
81. Реализуйте структуру LinkedList с вложенным классом Node
82. Создайте структуру Database с вложенными классами Table и Column
83. Реализуйте структуру Window с вложенными классами Button и TextField
84. Создайте структуру Game с вложенными структурами Player и Level
85. Реализуйте структуру API с вложенными классами Request и Response
86. Создайте структуру Project с вложенными классами Task и Milestone
87. Реализуйте структуру Menu с вложенными классами Item и Submenu
88. Создайте структуру Document с вложенными классами Section и Paragraph
89. Реализуйте структуру Network с вложенными структурами Host и Port
90. Создайте структуру Transaction с вложенной структурой Detail
91. Реализуйте структуру Form с вложенным классом Field
92. Создайте структуру Report с вложенными классами Header и Body
93. Реализуйте структуру Shopping с вложенной структурой CartItem
94. Создайте структуру School с вложенными классами Class и Student
95. Реализуйте структуру Hospital с вложенными структурами Doctor и Patient
96. Создайте структуру Queue с вложенным классом Node
97. Реализуйте структуру Stack с вложенным классом Element
98. Создайте структуру Container с вложенным интерфейсом IElement
99. Реализуйте структуру Blog с вложенными классами Post и Comment
100. Создайте структуру Repository с вложенной структурой Entity

---

### **Задание 5**: Создайте структуру Money с полями Amount и Currency, и методом для форматирования

```csharp
public struct Money
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    
    public Money(decimal amount, string currency = "USD")
    {
        Amount = amount;
        Currency = currency;
    }
    
    public override string ToString()
    {
        return $"{Amount:F2} {Currency}";
    }
    
    public string FormatDetailed()
    {
        return $"Amount: {Amount:C}, Currency: {Currency}";
    }
    
    public string FormatShort()
    {
        var currencySymbols = new Dictionary<string, string>
        {
            { "USD", "$" },
            { "EUR", "€" },
            { "GBP", "£" },
            { "RUB", "₽" },
            { "JPY", "¥" }
        };
        
        string symbol = currencySymbols.ContainsKey(Currency) ? currencySymbols[Currency] : Currency;
        return $"{symbol}{Amount:F2}";
    }
    
    public Money Add(Money other)
    {
        if (this.Currency != other.Currency)
            throw new InvalidOperationException("Cannot add different currencies");
        return new Money(this.Amount + other.Amount, this.Currency);
    }
    
    public Money Subtract(Money other)
    {
        if (this.Currency != other.Currency)
            throw new InvalidOperationException("Cannot subtract different currencies");
        return new Money(this.Amount - other.Amount, this.Currency);
    }
}
```

**Использование:**
```csharp
Money price = new Money(99.99m, "USD");
Console.WriteLine(price.ToString());           // Output: 99.99 USD
Console.WriteLine(price.FormatShort());        // Output: $99.99
Console.WriteLine(price.FormatDetailed());     // Output: Amount: $99.99, Currency: USD

Money total = price.Add(new Money(50.01m, "USD"));
Console.WriteLine(total.FormatShort());        // Output: $150.00
```

---

### **Задание 9**: Создайте структуру Coordinate с двумя полями и методом расстояния до другой координаты

```csharp
public struct Coordinate
{
    public double X { get; set; }
    public double Y { get; set; }
    
    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public double DistanceTo(Coordinate other)
    {
        double deltaX = this.X - other.X;
        double deltaY = this.Y - other.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
    
    public double ManhattanDistanceTo(Coordinate other)
    {
        return Math.Abs(this.X - other.X) + Math.Abs(this.Y - other.Y);
    }
    
    public Coordinate Translate(double dx, double dy)
    {
        return new Coordinate(this.X + dx, this.Y + dy);
    }
    
    public override string ToString()
    {
        return $"({X:F2}, {Y:F2})";
    }
    
    public override bool Equals(object obj)
    {
        if (!(obj is Coordinate))
            return false;
        
        Coordinate other = (Coordinate)obj;
        return this.X == other.X && this.Y == other.Y;
    }
    
    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}
```

**Использование:**
```csharp
Coordinate point1 = new Coordinate(0, 0);
Coordinate point2 = new Coordinate(3, 4);

Console.WriteLine($"Distance: {point1.DistanceTo(point2)}");           // Output: 5
Console.WriteLine($"Manhattan: {point1.ManhattanDistanceTo(point2)}"); // Output: 7

Coordinate point3 = point1.Translate(1, 1);
Console.WriteLine(point3.ToString());                                  // Output: (1.00, 1.00)
```

---

### **Задание 31**: Реализуйте структуру Money с конструктором и валидацией значения

```csharp
public struct ValidatedMoney : IEquatable<ValidatedMoney>, IComparable<ValidatedMoney>
{
    private decimal _amount;
    private string _currency;
    
    public decimal Amount
    {
        get { return _amount; }
        set 
        { 
            if (value < 0)
                throw new ArgumentException("Amount cannot be negative");
            _amount = value;
        }
    }
    
    public string Currency
    {
        get { return _currency; }
        set 
        { 
            if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
                throw new ArgumentException("Currency must be 3-letter code (ISO 4217)");
            _currency = value.ToUpper();
        }
    }
    
    public ValidatedMoney(decimal amount, string currency = "USD")
    {
        _amount = 0;
        _currency = "USD";
        
        Amount = amount;
        Currency = currency;
    }
    
    public static bool TryCreate(decimal amount, string currency, out ValidatedMoney result)
    {
        result = default;
        try
        {
            result = new ValidatedMoney(amount, currency);
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public override string ToString() => $"{_amount:F2} {_currency}";
    
    public bool Equals(ValidatedMoney other) => 
        _amount == other._amount && _currency == other._currency;
    
    public override bool Equals(object obj) => 
        obj is ValidatedMoney other && Equals(other);
    
    public override int GetHashCode() => 
        _amount.GetHashCode() ^ _currency.GetHashCode();
    
    public int CompareTo(ValidatedMoney other)
    {
        if (_currency != other._currency)
            throw new InvalidOperationException("Cannot compare different currencies");
        return _amount.CompareTo(other._amount);
    }
    
    public static bool operator ==(ValidatedMoney left, ValidatedMoney right) => 
        left.Equals(right);
    
    public static bool operator !=(ValidatedMoney left, ValidatedMoney right) => 
        !left.Equals(right);
    
    public static bool operator <(ValidatedMoney left, ValidatedMoney right) => 
        left.CompareTo(right) < 0;
    
    public static bool operator >(ValidatedMoney left, ValidatedMoney right) => 
        left.CompareTo(right) > 0;
}
```

**Использование:**
```csharp
// Валидный случай
if (ValidatedMoney.TryCreate(99.99m, "USD", out var money1))
{
    Console.WriteLine(money1); // Output: 99.99 USD
}

// Невалидный случай
if (!ValidatedMoney.TryCreate(-50m, "EUR", out var money2))
{
    Console.WriteLine("Ошибка: сумма не может быть отрицательной");
}

var price1 = new ValidatedMoney(100m, "USD");
var price2 = new ValidatedMoney(150m, "USD");
Console.WriteLine(price1 < price2); // Output: True
```

---

### **Задание 33**: Реализуйте структуру Time с конструктором и проверкой времени

```csharp
public struct TimeOfDay
{
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }
    
    public TimeOfDay(int hours, int minutes = 0, int seconds = 0)
    {
        ValidateTime(hours, minutes, seconds);
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
    
    private static void ValidateTime(int hours, int minutes, int seconds)
    {
        if (hours < 0 || hours > 23)
            throw new ArgumentOutOfRangeException(nameof(hours), "Hours must be between 0 and 23");
        if (minutes < 0 || minutes > 59)
            throw new ArgumentOutOfRangeException(nameof(minutes), "Minutes must be between 0 and 59");
        if (seconds < 0 || seconds > 59)
            throw new ArgumentOutOfRangeException(nameof(seconds), "Seconds must be between 0 and 59");
    }
    
    public static TimeOfDay Parse(string timeString)
    {
        var parts = timeString.Split(':');
        if (parts.Length < 2 || parts.Length > 3)
            throw new FormatException("Invalid time format. Use HH:MM or HH:MM:SS");
        
        if (!int.TryParse(parts[0], out int hours) ||
            !int.TryParse(parts[1], out int minutes))
            throw new FormatException("Invalid time format");
        
        int seconds = 0;
        if (parts.Length == 3)
        {
            if (!int.TryParse(parts[2], out seconds))
                throw new FormatException("Invalid seconds format");
        }
        
        return new TimeOfDay(hours, minutes, seconds);
    }
    
    public override string ToString()
    {
        return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    }
    
    public string ToShortString()
    {
        return $"{Hours:D2}:{Minutes:D2}";
    }
    
    public int TotalSeconds()
    {
        return Hours * 3600 + Minutes * 60 + Seconds;
    }
    
    public TimeOfDay AddMinutes(int minutes)
    {
        int totalSeconds = TotalSeconds() + (minutes * 60);
        totalSeconds = totalSeconds % 86400; // Wrap around 24 hours
        
        int newHours = totalSeconds / 3600;
        int newMinutes = (totalSeconds % 3600) / 60;
        int newSeconds = totalSeconds % 60;
        
        return new TimeOfDay(newHours, newMinutes, newSeconds);
    }
    
    public bool IsAM()
    {
        return Hours < 12;
    }
    
    public string To12HourFormat()
    {
        int displayHours = Hours == 0 ? 12 : (Hours > 12 ? Hours - 12 : Hours);
        string period = Hours < 12 ? "AM" : "PM";
        return $"{displayHours:D2}:{Minutes:D2}:{Seconds:D2} {period}";
    }
}
```

**Использование:**
```csharp
// Создание времени
var time1 = new TimeOfDay(14, 30, 45);
Console.WriteLine(time1.ToString());              // Output: 14:30:45
Console.WriteLine(time1.To12HourFormat());        // Output: 02:30:45 PM

// Парсинг из строки
var time2 = TimeOfDay.Parse("09:15:30");
Console.WriteLine(time2.TotalSeconds());          // Output: 33330

// Добавление времени
var time3 = time2.AddMinutes(45);
Console.WriteLine(time3.ToString());              // Output: 10:00:30
```

---

### **Задание 83**: Реализуйте структуру Window с вложенными классами Button и TextField

```csharp
public class Window
{
    public string Title { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    
    private List<Button> buttons = new List<Button>();
    private List<TextField> textFields = new List<TextField>();
    
    public Window(string title, int width = 800, int height = 600)
    {
        Title = title;
        Width = width;
        Height = height;
    }
    
    // Вложенный класс Button
    public class Button
    {
        public string Text { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public event EventHandler Click;
        
        public Button(string text, int x, int y, int width = 100, int height = 30)
        {
            Text = text;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
        
        public void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
        
        public override string ToString()
        {
            return $"Button: {Text} at ({X}, {Y}) [{Width}x{Height}]";
        }
    }
    
    // Вложенный класс TextField
    public class TextField
    {
        private string _text = "";
        
        public string Text
        {
            get { return _text; }
            set { _text = value ?? ""; }
        }
        
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsReadOnly { get; set; }
        
        public TextField(string initialText, int x, int y, int width = 200, int height = 25)
        {
            Text = initialText;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            IsReadOnly = false;
        }
        
        public void Clear()
        {
            if (!IsReadOnly)
                _text = "";
        }
        
        public void AppendText(string text)
        {
            if (!IsReadOnly)
                _text += text;
        }
        
        public override string ToString()
        {
            return $"TextField: '{Text}' at ({X}, {Y}) [{Width}x{Height}]" +
                   (IsReadOnly ? " [ReadOnly]" : "");
        }
    }
    
    public Button AddButton(string text, int x, int y)
    {
        Button button = new Button(text, x, y);
        buttons.Add(button);
        return button;
    }
    
    public TextField AddTextField(string initialText, int x, int y)
    {
        TextField field = new TextField(initialText, x, y);
        textFields.Add(field);
        return field;
    }
    
    public void DisplayControls()
    {
        Console.WriteLine($"=== {Title} ({Width}x{Height}) ===");
        Console.WriteLine("Buttons:");
        foreach (var button in buttons)
            Console.WriteLine($"  {button}");
        
        Console.WriteLine("Text Fields:");
        foreach (var field in textFields)
            Console.WriteLine($"  {field}");
    }
    
    public Button GetButton(string text)
    {
        return buttons.FirstOrDefault(b => b.Text == text);
    }
    
    public TextField GetTextField(int index)
    {
        return index >= 0 && index < textFields.Count ? textFields[index] : null;
    }
}
```

**Использование:**
```csharp
// Создание окна
Window mainWindow = new Window("My Application", 1024, 768);

// Добавление кнопок
var submitBtn = mainWindow.AddButton("Submit", 50, 100);
var cancelBtn = mainWindow.AddButton("Cancel", 150, 100);

// Добавление текстовых полей
var nameField = mainWindow.AddTextField("Enter name", 50, 50);
var emailField = mainWindow.AddTextField("Enter email", 50, 75);

// Использование событий кнопок
submitBtn.Click += (sender, e) => 
{
    Console.WriteLine($"Submit clicked! Name: {nameField.Text}");
};

// Отображение всех элементов
mainWindow.DisplayControls();

// Обработка событий
submitBtn.OnClick();

// Работа с полями
nameField.AppendText(" - Updated");
Console.WriteLine(nameField.Text); // Output: Enter name - Updated
```

---

## 📋 Рекомендации по выполнению

### Рассмотрение структур
- Используйте значимые типы (structs) для небольших объектов, которые часто копируются
- Переопределяйте методы `ToString()`, `Equals()` и `GetHashCode()`
- Обратите внимание на разницу между типами значений и ссылочными типами

### Конструкторы
- Всегда добавляйте валидацию параметров
- Используйте перегрузку конструкторов для гибкости
- Предусмотрите методы `Parse()` и `TryParse()` для парсинга строк

### Наследование в структурах
- Структуры не могут наследоваться от других структур (только реализуют интерфейсы)
- Реализуйте стандартные интерфейсы: `IEquatable<T>`, `IComparable<T>`, `IFormattable`
- Переопределяйте операторы сравнения (`==`, `!=`, `<`, `>` и т.д.)

### Вложенные типы
- Используйте для группировки связанных типов
- Контролируйте доступность (private, protected, public, internal)
- Помните, что вложенные типы могут быть статическими

---
