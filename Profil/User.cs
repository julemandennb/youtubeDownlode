using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Profil
{
    public class User
    {


        string path = "";

        public User()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        }

        public string GetSetpath { get { return path + "\\"; } set {

                path = value;
                Save();
            
            } }    



        public User GetUser()
        {
            User user = new User();

            if (File.Exists("UserProfilInfo.json"))
            {
                string text = File.ReadAllText("UserProfilInfo.json");
                user = JsonConvert.DeserializeObject<User>(text);
            }

            return user;
        }


        public void Save ()
        {
            System.IO.File.WriteAllText("UserProfilInfo.json", JsonConvert.SerializeObject(this));
        }



    }
}
