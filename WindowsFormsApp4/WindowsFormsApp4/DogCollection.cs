using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

public class DogCollection
{
    private List<Dog> dogs = new List<Dog>();

    public void Add(Dog dog)
    {
        dogs.Add(dog);
    }

    public List<Dog> GetAll()
    {
        return new List<Dog>(dogs);
    }

    public List<Dog> GetByGender(string gender)
    {
        return dogs.Where(d => d.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void SortById()
    {
        dogs.Sort();
    }

    public void SaveToFile(string path)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fs = null;
        try
        {
            fs = new FileStream(path, FileMode.Create);
            formatter.Serialize(fs, dogs);
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
    }

    public void LoadFromFile(string path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException("Файл не знайдено");

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fs = null;
        try
        {
            fs = new FileStream(path, FileMode.Open);
            dogs = (List<Dog>)formatter.Deserialize(fs);
        }
        finally
        {
            if (fs != null)
                fs.Close();
        }
    }
}
