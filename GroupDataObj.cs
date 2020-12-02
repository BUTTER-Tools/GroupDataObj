using System.Collections.Generic;
using System;

namespace GroupDataObj
{
    public class GroupData
    {

        public List<Person> People { get; set; }
        public Dictionary<ulong, Tuple<string, int>> TurnTracker {get;set;}
        
        public GroupData()
        {
            People = new List<Person>();
        }

    }

    public class Person
    {
        public string id { get; set; }
        public List<string> text { get; set; }

        public Person(string identifier, List<string> text_data)
        {
            id = identifier;
            text = text_data;
        }

    }

}
