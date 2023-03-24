using pbl3_appstore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl3_appstore.services
{
    public class AppStoreService
    {
        private static AppStoreService instance =  new AppStoreService();

        public static AppStoreService Instance { get {  return instance; } }

        public AppStoreService() { }

        public Person createPerson(DateTime birday)
        {

            return new Person() {
                date_of_birth = new DateTime(),
                address = "phu trung",
                email  = "duclatao@gmail.com"
            };
        }
        
       
    }
}
