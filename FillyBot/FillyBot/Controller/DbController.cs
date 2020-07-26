using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using FillyBot.Models;

namespace FillyBot.Controller
{
    public class DbController
    {
        Model db;
        string jsonData;
        //string path = "CaptionDatabase.json";
        string dbPath = "";
        readonly string dbName = "Obj.json";
        string fullPath = "";
        string dblocation = "";

        public DbController()
        {
            try
            {
                //initiaze root path of database (get My documents path of host machine)
                string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string targetDatabaseLocation = "DatabaseLocation.txt";
                //directory path for db
                string dbPath = $@"{rootPath}\Filly Bot\Data";
                //if db folder does not exist, create 
                if (!Directory.Exists(dbPath))
                {

                    Model emptyModel = new Model();
                    Directory.CreateDirectory(dbPath);
                    jsonData = JsonConvert.SerializeObject(emptyModel, Formatting.Indented);
                    using (StreamWriter writer = new StreamWriter(dbPath + "/" + dbName))
                    {
                        writer.Write(jsonData);
                    }


                }
                if (!File.Exists(targetDatabaseLocation))
                {
                    using (StreamWriter writer = new StreamWriter(targetDatabaseLocation))
                    {
                        writer.Write(dbPath);
                    }

                }
                //get location of targeted db
                using (var reader = new StreamReader(targetDatabaseLocation))
                {
                    dblocation = reader.ReadToEnd();
                }

                //read data from database
                using (var reader = new StreamReader($@"{dblocation}\{dbName}"))
                {
                    jsonData = reader.ReadToEnd();
                }

                db = JsonConvert.DeserializeObject<Model>(jsonData);


            }
            catch (Exception ex)
            {
                return;
            }
        }
      

        private void SaveData(Model model)
        {
            try
            {
                //save data to db
                jsonData = JsonConvert.SerializeObject(model, Formatting.Indented);
                using (StreamWriter writer = new StreamWriter($@"{dblocation}\{dbName}"))
                {
                    writer.Write(jsonData);
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("An error occured during saving, try again");
            }
        }


        //Get Profile info
        public List<Profile> GetProfiles()
        {
            List<Profile> profiles = null;
            if (db.Profiles != null) { profiles = db.Profiles; }

            return profiles;
        }


        //Save Profile
        public void SaveProfile(Profile profile)
        {
            if (db.Profiles == null) { db.Profiles = new List<Profile>(); }
            db.Profiles.Add(profile);
            SaveData(db);
        }
        
        //update profile
        public void UpdateProfile(Profile profile)
        {
            if (db.Profiles != null)
            {
                foreach (var prof in db.Profiles)
                {
                    if (profile.id == prof.id)
                    {

                        prof.firstName = profile.firstName;
                        prof.lastName = profile.lastName;
                        prof.address = profile.address;
                        prof.code = profile.code;
                        prof.city = profile.city;
                        prof.state = profile.state;
                        prof.cardType = profile.cardType;
                        prof.cardNumber = profile.cardNumber;
                        prof.month = profile.month;
                        prof.year = profile.year;
                        prof.cvc = profile.cvc;
                        prof.shipping_address = profile.shipping_address;
                        prof.shipping_city = profile.shipping_city;
                        prof.shipping_code = profile.shipping_code;
                        prof.shipping_firstName = profile.shipping_firstName;
                        prof.shipping_lastName = profile.shipping_lastName;
                        prof.shipping_state = profile.shipping_state;
                        SaveData(db);
                        break;
                    }
                }

            }
        }
        //Remove profile
        public void RemoveProfile(int id)
        {
            if (db.Profiles != null)
            {
                foreach(var profile in db.Profiles)
                {
                    if (profile.id == id)
                    {
                        db.Profiles.Remove(profile);
                        SaveData(db);
                        break;
                    }
                }
               
            }
        }
        //Get Tasks
        public List<Models.Task> GetTasks()
        {
            List<FillyBot.Models.Task> tasks = null;
            if (db.Tasks != null) { tasks = db.Tasks; }

            return tasks;
        }

        //Add Task
        public void NewTask(Models.Task task)
        {
            if (db.Tasks == null) { db.Tasks = new List<Models.Task>(); }
            db.Tasks.Add(task);
            SaveData(db);

        }
        //Remove Task
        public void RemoveTask(string id)
        {
            if (db.Tasks != null)
            {
                foreach (var task in db.Tasks)
                {
                    if (task.id == id)
                    {
                        db.Tasks.Remove(task);
                        SaveData(db);
                        break;
                    }
                }

            }
        }


        //Get Stores
        public List<Store> GetStores()
        {
            List<Store> stores = null;
            if (db.Stores != null) { stores = db.Stores; }

            return stores;
        }


        //Add Store
        public void NewStore(Store store)
        {
            if (db.Stores == null) { db.Stores = new List<Store>(); }
            db.Stores.Add(store);
            SaveData(db);
        }


        //Remove Store
        public void RemoveStore(int index)
        {
            db.Stores.RemoveAt(index);
            SaveData(db);
        }

    }
}
