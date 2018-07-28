using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooSeePCL
{
    public class DOG_REALM_TRAINING : RealmObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class RealmMethods
    {
        public string realmPractice(string nameParam)
        {
            var realm = Realm.GetInstance();

            // Use LINQ to query
            var puppies = realm.All<DOG_REALM_TRAINING>();//.Where(d => d.Age < 2);
            int count;
            count = puppies.Count(); // => 0 because no dogs have been added yet

            // Update and persist objects with a thread-safe transaction
            realm.Write(() =>
            {
                realm.Add(new DOG_REALM_TRAINING { Name = nameParam, Age = 1 });
            });

            // Queries are updated in realtime
            puppies.Count();

            var all = realm.All<DOG_REALM_TRAINING>();

            var oldDogs = from d in realm.All<DOG_REALM_TRAINING>() where d.Age < 8 select d;
            List<string> iList = new List<string>();
            foreach (var d in all)
            {
                var e = (d.Name);
                iList.Add(d.Name);
            }
            foreach (var v in iList)
            {
                var e = v; 
            }
             
            return "res";
        }
    }
}
