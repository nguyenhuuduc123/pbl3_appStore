using pbl3_appstore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pbl3_appstore.services
{
    public class AppStoreService
    {
        private static AppStoreService instance =  new AppStoreService();

        public static AppStoreService Instance { get {  return instance; } }

        public AppStoreService() { }


        public Person login(String password,string username)
        {
            Person? person = (from p in appStoreDbcontext._instance.persons
                             where p.email == username && p.password == password
                             select p).FirstOrDefault();
           




            return person!;
        }

        public List<Person> getAllPerson()
        {
            List<Person> persons = from p in appStoreDbcontext._instance.persons.ToList();
;        return persons;
        }
        public Person getPersonByEmail(string email)
        {
            Person? person = (from p in appStoreDbcontext._instance.persons
                             where p.email == email
                             select p).FirstOrDefault();
            return person!;
        }

        public Person getPersonByRole(string rolename)
        {
            Person? person = (from p in appStoreDbcontext._instance.persons
                              where p.role.name_role == rolename
                              select p).FirstOrDefault();

           return person!;
        }

        public string roleNamePersonLogin(string name,string password)
        {
            Person person = login(password, name);
            return person.role.name_role;
        }
        public List<Item> getItemByCategory(bool desending,Category c)
        {


            return new List<Item>();
        }
               
       
    }
}
