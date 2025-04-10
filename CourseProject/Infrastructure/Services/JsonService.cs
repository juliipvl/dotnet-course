using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class JsonService
    {
        private readonly string _dataDirectory;

        public JsonService(string dataDirectory)
        {
            _dataDirectory = dataDirectory;
            try
            {
                if (!Directory.Exists(_dataDirectory))
                    Directory.CreateDirectory(_dataDirectory);
            }
            catch (Exception ex)
            {
                throw new IOException($"Помилка під час створення директорії: {_dataDirectory}", ex);
            }
        }

        public bool Exists(string fileName)
        {
            try
            {
                var filePath = GetFilePath(fileName);
                return File.Exists(filePath);
            }
            catch (Exception ex)
            {
                throw new IOException($"Помилка перевірки існування файлу: {fileName}", ex);
            }
        }

        public T Read<T>(string fileName) where T : class
        {
            try
            {
                var filePath = GetFilePath(fileName);
                if (!File.Exists(filePath)) return null;

                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                throw new IOException($"Помилка зчитування файлу: {fileName}", ex);
            }
        }

        public void Write<T>(string fileName, T data)
        {
            try
            {
                var filePath = GetFilePath(fileName);
                var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new IOException($"Помилка запису файлу: {fileName}", ex);
            }
        }

        public void Delete(string fileName)
        {
            try
            {
                var filePath = GetFilePath(fileName);
                if (File.Exists(filePath))
                    File.Delete(filePath);
            }
            catch (Exception ex)
            {
                throw new IOException($"Помилка видалення файлу: {fileName}", ex);
            }
        }

        private string GetFilePath(string fileName)
        {
            return Path.Combine(_dataDirectory, fileName);
        }
    }

}