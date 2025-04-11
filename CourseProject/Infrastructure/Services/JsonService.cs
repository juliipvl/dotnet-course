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
            catch (IOException ex)
            {
                Console.WriteLine($"Error occurs when trying to create directory: {_dataDirectory}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong");
            }
        }

        public bool Exists(string fileName)
        {
            try
            {
                var filePath = GetFilePath(fileName);
                return File.Exists(filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error occurs when checking existence of file: {fileName}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong");
                return false;
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
            catch (IOException ex)
            {
                Console.WriteLine($"Error occurs when reading file: {fileName}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong");
                return null;
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
            catch (IOException ex)
            {
                Console.WriteLine($"Error occurs when writing to file: {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong");
            }
        }

        private string GetFilePath(string fileName)
        {
            return Path.Combine(_dataDirectory, fileName);
        }
    }

}