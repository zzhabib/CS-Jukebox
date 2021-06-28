using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CS_Jukebox
{
    static class Properties
    {
        public static string GameDir = null;

        public static readonly string ConfigPath = @"\csgo\cfg\gamestate_integration_jukebox.cfg";
        public static readonly string ConfigName = @"\gamestate_integration_jukebox.cfg";
        public static readonly string PropertiesFilePath = @"\properties.json";

        //Converts settings to json file then saves it
        public static void Save()
        {
            string dir = Directory.GetCurrentDirectory() + PropertiesFilePath;

            PropertiesFile propFile = new PropertiesFile();
            propFile.GameDir = GameDir;
            Console.WriteLine(propFile.GameDir);

            string jsonFile = JsonConvert.SerializeObject(propFile);

            Console.WriteLine("Saving json properties: ");
            Console.WriteLine(jsonFile);
            File.WriteAllText(dir, jsonFile);
        }

        //Reads properties file then deserializes it
        public static void Load()
        {
            string dir = Directory.GetCurrentDirectory() + PropertiesFilePath;
            PropertiesFile propFile;

            try
            {
                string jsonFile = File.ReadAllText(dir);
                propFile = JsonConvert.DeserializeObject<PropertiesFile>(jsonFile);
                GameDir = propFile.GameDir;
            }
            catch (FileNotFoundException e)
            {
                propFile = new PropertiesFile();
            }
        }

        //Copies the config from local folder to CS:GO cfg folder
        public static void CreateConfig()
        {
            string configPath = Properties.GameDir + Properties.ConfigPath;
            string root = Directory.GetCurrentDirectory();
            string configSrc = root + Properties.ConfigName;

            if (File.Exists(configPath))
            {
                File.Delete(configPath);
                File.Copy(configSrc, configPath);
            }
            else
            {
                File.Copy(configSrc, configPath);
            }
        }

        //Inner class for properties parameters
        private class PropertiesFile
        {
            
            public string GameDir;
        }
    }
}
