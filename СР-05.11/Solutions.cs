using System;
using System.Security.Cryptography;
using System.Text;

namespace CSharpTasks
{
    // ===========================================
    // Задание 5: Создайте класс с приватным статическим полем и публичным статическим свойством для доступа к нему
    // ===========================================
    
    public class ApplicationConfig
    {
        // Приватное статическое поле
        private static string _applicationName = "MyApp";
        private static int _maxConnections = 100;
        
        // Публичные статические свойства для доступа
        public static string ApplicationName
        {
            get { return _applicationName; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                    _applicationName = value; 
            }
        }
        
        public static int MaxConnections
        {
            get { return _maxConnections; }
            set 
            { 
                if (value > 0)
                    _maxConnections = value; 
            }
        }
        
        public static void DisplayConfig()
        {
            Console.WriteLine($"Application: {ApplicationName}");
            Console.WriteLine($"Max Connections: {MaxConnections}");
        }
    }
    
    // ===========================================
    // Задание 9: Создайте класс с статическим readonly полем для хранения версии приложения
    // ===========================================
    
    public class AppVersion
    {
        // Статические readonly поля
        public static readonly string Version = "1.0.0";
        public static readonly DateTime ReleaseDate = new DateTime(2025, 11, 3);
        public static readonly string BuildNumber = "20251103.1";
        
        private static readonly string _companyName = "TechCorp";
        
        public static string CompanyName => _companyName;
        
        public static string GetFullVersionInfo()
        {
            return $"{_companyName} - Version {Version} (Build {BuildNumber}) - Released: {ReleaseDate:yyyy-MM-dd}";
        }
    }
    
    // ===========================================
    // Задание 31: Создайте статический класс XmlHelper для работы с XML
    // ===========================================
    
    public static class XmlHelper
    {
        // Экранирование специальных символов XML
        public static string EscapeXml(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
                
            return text
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&apos;");
        }
        
        // Создание простого XML элемента
        public static string CreateElement(string tagName, string content)
        {
            return $"<{tagName}>{EscapeXml(content)}</{tagName}>";
        }
        
        // Создание XML элемента с атрибутами
        public static string CreateElementWithAttributes(string tagName, string content, params (string key, string value)[] attributes)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<{tagName}");
            
            foreach (var attr in attributes)
            {
                sb.Append($" {attr.key}=\"{EscapeXml(attr.value)}\"");
            }
            
            sb.Append($">{EscapeXml(content)}</{tagName}>");
            return sb.ToString();
        }
        
        // Создание XML документа
        public static string CreateDocument(string rootElement, string content)
        {
            return $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<{rootElement}>\n{content}\n</{rootElement}>";
        }
        
        // Извлечение содержимого между тегами
        public static string ExtractContent(string xml, string tagName)
        {
            string openTag = $"<{tagName}>";
            string closeTag = $"</{tagName}>";
            
            int startIndex = xml.IndexOf(openTag);
            int endIndex = xml.IndexOf(closeTag);
            
            if (startIndex >= 0 && endIndex > startIndex)
            {
                startIndex += openTag.Length;
                return xml.Substring(startIndex, endIndex - startIndex);
            }
            
            return null;
        }
    }
    
    // ===========================================
    // Задание 33: Создайте статический класс SecurityHelper для криптографических операций
    // ===========================================
    
    public static class SecurityHelper
    {
        // Хеширование строки с использованием SHA256
        public static string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha256.ComputeHash(bytes);
                
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        
        // Хеширование с использованием MD5
        public static string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = md5.ComputeHash(bytes);
                
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
        
        // Генерация случайного ключа
        public static string GenerateRandomKey(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            byte[] randomBytes = new byte[length];
            
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            
            StringBuilder sb = new StringBuilder(length);
            foreach (byte b in randomBytes)
            {
                sb.Append(chars[b % chars.Length]);
            }
            
            return sb.ToString();
        }
        
        // Простое XOR шифрование (для демонстрации)
        public static string XorEncrypt(string input, string key)
        {
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(key))
                return input;
                
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] ^ key[i % key.Length]));
            }
            
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(result.ToString()));
        }
        
        // Простое XOR расшифрование
        public static string XorDecrypt(string encrypted, string key)
        {
            if (string.IsNullOrEmpty(encrypted) || string.IsNullOrEmpty(key))
                return encrypted;
                
            byte[] encryptedBytes = Convert.FromBase64String(encrypted);
            string encryptedString = Encoding.UTF8.GetString(encryptedBytes);
            
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < encryptedString.Length; i++)
            {
                result.Append((char)(encryptedString[i] ^ key[i % key.Length]));
            }
            
            return result.ToString();
        }
    }
    
    // ===========================================
    // Задание 83: Реализуйте Singleton с ленивой инициализацией через Lazy<T>
    // ===========================================
    
    public sealed class ConfigurationManager
    {
        // Ленивая инициализация через Lazy<T>
        private static readonly Lazy<ConfigurationManager> _instance = 
            new Lazy<ConfigurationManager>(() => new ConfigurationManager());
        
        // Словарь для хранения конфигурации
        private readonly Dictionary<string, string> _settings;
        
        // Приватный конструктор
        private ConfigurationManager()
        {
            _settings = new Dictionary<string, string>();
            LoadDefaultSettings();
            Console.WriteLine("ConfigurationManager инициализирован");
        }
        
        // Публичное свойство для доступа к единственному экземпляру
        public static ConfigurationManager Instance => _instance.Value;
        
        private void LoadDefaultSettings()
        {
            _settings["AppName"] = "MyApplication";
            _settings["Version"] = "1.0.0";
            _settings["Environment"] = "Production";
        }
        
        public void SetSetting(string key, string value)
        {
            _settings[key] = value;
        }
        
        public string GetSetting(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : null;
        }
        
        public void DisplayAllSettings()
        {
            Console.WriteLine("=== Configuration Settings ===");
            foreach (var kvp in _settings)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
    
    // ===========================================
    // ГЛАВНАЯ ПРОГРАММА - ДЕМОНСТРАЦИЯ
    // ===========================================
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрация решений 5 случайных задач ===\n");
            
            // Задание 5: Статические свойства
            Console.WriteLine("--- ЗАДАНИЕ 5: Статические свойства ---");
            ApplicationConfig.DisplayConfig();
            ApplicationConfig.ApplicationName = "SuperApp";
            ApplicationConfig.MaxConnections = 200;
            ApplicationConfig.DisplayConfig();
            Console.WriteLine();
            
            // Задание 9: Статические readonly поля
            Console.WriteLine("--- ЗАДАНИЕ 9: Версия приложения ---");
            Console.WriteLine(AppVersion.GetFullVersionInfo());
            Console.WriteLine($"Company: {AppVersion.CompanyName}");
            Console.WriteLine();
            
            // Задание 31: XmlHelper
            Console.WriteLine("--- ЗАДАНИЕ 31: XML Helper ---");
            string element = XmlHelper.CreateElement("name", "John & Jane");
            Console.WriteLine(element);
            
            string elementWithAttrs = XmlHelper.CreateElementWithAttributes(
                "book", 
                "C# Programming",
                ("id", "123"),
                ("author", "Smith & Jones")
            );
            Console.WriteLine(elementWithAttrs);
            
            string xmlDoc = XmlHelper.CreateDocument("users", 
                "  <user id=\"1\">Alice</user>\n  <user id=\"2\">Bob</user>");
            Console.WriteLine(xmlDoc);
            Console.WriteLine();
            
            // Задание 33: SecurityHelper
            Console.WriteLine("--- ЗАДАНИЕ 33: Security Helper ---");
            string password = "MySecurePassword123";
            string sha256Hash = SecurityHelper.ComputeSHA256Hash(password);
            string md5Hash = SecurityHelper.ComputeMD5Hash(password);
            Console.WriteLine($"SHA256: {sha256Hash}");
            Console.WriteLine($"MD5: {md5Hash}");
            
            string randomKey = SecurityHelper.GenerateRandomKey(16);
            Console.WriteLine($"Random Key: {randomKey}");
            
            string encrypted = SecurityHelper.XorEncrypt("Secret Message", "key123");
            string decrypted = SecurityHelper.XorDecrypt(encrypted, "key123");
            Console.WriteLine($"Encrypted: {encrypted}");
            Console.WriteLine($"Decrypted: {decrypted}");
            Console.WriteLine();
            
            // Задание 83: Singleton с Lazy<T>
            Console.WriteLine("--- ЗАДАНИЕ 83: Singleton (Lazy<T>) ---");
            var config1 = ConfigurationManager.Instance;
            config1.DisplayAllSettings();
            
            config1.SetSetting("DatabaseConnection", "Server=localhost;Database=mydb");
            
            var config2 = ConfigurationManager.Instance;
            Console.WriteLine($"\nПроверка что это один экземпляр: {ReferenceEquals(config1, config2)}");
            config2.DisplayAllSettings();
            
            Console.WriteLine("\n=== Все задания выполнены успешно! ===");
            Console.ReadKey();
        }
    }
}