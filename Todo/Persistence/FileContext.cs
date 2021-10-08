using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace FileData {
public class FileContext : IFileContext
{
   // public IList<Family> Families { get; private set; }
    public IList<Adult> Adults { get; private set; }

    private readonly string AdultFile = "adults.json";
    
    public FileContext()
    {
        Adults = File.Exists(AdultFile) ? ReadData<Adult>(AdultFile) : new List<Adult>();
    }

    private IList<T> ReadData<T>(string s)
    {
        using (var jsonReader = File.OpenText(AdultFile))
        {
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }
    }

    public void SaveChanges()
    {
        // storing families
        string jsonAdult = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        using (StreamWriter outputFile = new StreamWriter(AdultFile, false))
        {
            outputFile.Write(jsonAdult);
        }
    }
    
    public List<Adult> GetAdults()
    {
        List<Adult> adults = new List<Adult>(Adults);
        return adults;
    }
    
    public void AddAdult(Adult adult)
    {
        Adults.Add(adult);
        SaveChanges();
    }
    
}
}