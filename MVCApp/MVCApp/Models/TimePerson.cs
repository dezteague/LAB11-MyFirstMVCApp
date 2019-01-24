using System;
using System.Collections.Generic;
//system io allows use of collection
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();
            
            //read in the file
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");

            //use File.ReadAllLines (returns an array)
            var personData = File.ReadAllLines(path).Skip(1);

            //iterate through the array and set values appropriately to a new TimePerson object
            //CVS, every item is separated by a comma (delimited)

            foreach (var item in personData)
            {
                //set the year range
                if (startYear >= 1927 && endYear <= 2016)
                {
                    string[] field = item.Split(',');
                    TimePerson tp = new TimePerson();
                    tp.Year =(field[0]==""?0:Convert.ToInt32(field[0]));
                    tp.Honor = field[1];
                    tp.Name = field[2];
                    tp.Country = field[3];
                    tp.BirthYear = (field[4]=="" ?0:Convert.ToInt32(field[4]));
                    tp.DeathYear = (field[5] == "" ?0: Convert.ToInt32(field[5]));
                    tp.Title = field[6];
                    tp.Category = field[7];
                    tp.Context = field[8];
                    people.Add(tp);
                }
            }
            //create the full list of people from the csv file

            //then do link query with lambda expression to filter
            List<TimePerson> listofPeople = people.Where(p => (p.Year >= startYear) && (p.Year <= endYear)).ToList();

            return listofPeople;
        }
    
    }
}
