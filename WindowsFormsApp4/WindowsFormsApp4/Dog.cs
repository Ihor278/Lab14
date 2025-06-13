using System;

[Serializable]
public class Dog : IComparable<Dog>, ICloneable
{
    private string id;
    private string breed;
    private string gender;
    private decimal price;
    private int age;

    public string Id
    {
        get { return id; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("ID не може бути порожнім");
            id = value;
        }
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value ?? "Unknown"; }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            if (value != "Male" && value != "Female")
                throw new ArgumentException("Стать повинна бути 'Male' або 'Female'");
            gender = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Ціна не може бути від’ємною");
            price = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Вік не може бути від’ємним");
            age = value;
        }
    }

    public Dog()
    {
        Id = "Unknown";
        Breed = "Unknown";
        Gender = "Male";
        Price = 0;
        Age = 0;
    }

    public Dog(string id, string breed, string gender, decimal price, int age)
    {
        Id = id;
        Breed = breed;
        Gender = gender;
        Price = price;
        Age = age;

        ApplyPriceIncreaseForFemale2YearOld();
    }

    private void ApplyPriceIncreaseForFemale2YearOld()
    {
        if (Gender == "Female" && Age == 2)
        {
            Price = Price * 1.25m;
        }
    }

    public int CompareTo(Dog other)
    {
        return this.Id.CompareTo(other.Id);
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return string.Format("{0} | {1} | {2} | {3:C} | {4} років", Id, Breed, Gender, Price, Age);
    }
}
