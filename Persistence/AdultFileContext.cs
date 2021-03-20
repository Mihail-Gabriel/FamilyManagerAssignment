using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Models;

namespace FileData
{
    public class AdultFileContext : FileContext
    {
        public IList<Adult> Adults { get; private set; }

        private readonly string adultsFile = "adults.json";
        public AdultFileContext()
        {
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }
        
        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
        public void AddAdult(Adult adult)
        {
            Boolean flag = true;
            foreach (Adult element in Adults)
            {
                if (element.Id == adult.Id)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                Adults.Add(adult);
                SaveChanges();
            }
        }

        public void RemoveAdults(IList<Adult> adult)
        {
            for (int i = 0; i < adult.Count; i++)
            {
                Adults.Remove(adult[i]);
                Console.WriteLine(adult[i]);
            }
            SaveChanges();
        }

        public IList<Adult> SearchByName(string Name)
        {
            IList<Adult> helper = new List<Adult>();

            foreach (Adult adult in Adults)
            {
                if (adult.FirstName.Equals(Name))
                {
                    helper.Add(adult);
                    return helper;
                }
            }

            return null;
        }

        public IList<Adult> SearchByLastName(string Name)
        {
            IList<Adult> helper = new List<Adult>();
            foreach (Adult adult in Adults)
            {
                if (adult.LastName.Equals(Name))
                {
                    helper.Add(adult);
                    return helper;
                }
            }
            return null;
        }
        
        public override void SaveChanges()
        {
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }
    }
}