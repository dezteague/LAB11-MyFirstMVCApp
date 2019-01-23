using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class TimePerson
    {
        public string Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string BirthYear { get; set; }
        public string DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();
            //read in the file
            //use File.ReadAllLines (returns an array)

            //iterate through the array and set values appropriately to a new TimePerson object

            //CVS, every item is separated by a comma (delimited)

            //create the full list of people from the csv file

            //then do link query with lambda expression to filter

            TimePerson tp = new TimePerson();
            tp.Name = "Dez";
            tp.Honor = "Cool";
            tp.Category = "foodie";
            people.Add(tp);

            //List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();

            return people;
        }
    
    }
}
