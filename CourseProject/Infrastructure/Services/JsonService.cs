using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JsonService
{
    private readonly string _dataDirectory;

    public JsonService(string dataDirectory)
    {
        _dataDirectory = dataDirectory;
        if (!Directory.Exists(_dataDirectory))
            Directory.CreateDirectory(_dataDirectory);
    }

    public bool Exists(string fileName)
    {
        var filePath = GetFilePath(fileName);
        return File.Exists(filePath);
    }

    public T Read<T>(string fileName) where T : class
    {
        var filePath = GetFilePath(fileName); 
        if (!File.Exists(filePath)) return null;

        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }

    public void Write<T>(string fileName, T data)
    {
        var filePath = GetFilePath(fileName);
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public void Delete(string fileName)
    {
        var filePath = GetFilePath(fileName);
        if (File.Exists(filePath))
            File.Delete(filePath);
    }

    private string GetFilePath(string fileName) 
    { 
        return Path.Combine(_dataDirectory, fileName);
    }
}
