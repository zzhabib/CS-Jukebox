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
        public static List<MusicKit> MusicKits = null;
        public static MusicKit SelectedKit = null;

        public static readonly string ConfigPath = @"\csgo\cfg\gamestate_integration_jukebox.cfg";
        public static readonly string ConfigName = @"\gamestate_integration_jukebox.cfg";
        public static readonly string PropertiesFilePath = @"\properties.json";

        public static readonly string MusicKitsPath = @"\kits";

        //Converts settings to json file then saves it
        public static void SaveProperties()
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

        //Calls all load methods
        public static void Load()
        {
            LoadProperties();
            LoadKits();
        }

        //Calls all save methods
        public static void Save()
        {
            SaveProperties();
            SaveKits();
        }

        //Reads properties file then deserializes it
        public static void LoadProperties()
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

        public static void SaveKits()
        {
            string dir = Directory.GetCurrentDirectory() + MusicKitsPath;

            Directory.CreateDirectory(dir);
            
            foreach (MusicKit musicKit in MusicKits)
            {
                string kitDir = dir + @"\" + musicKit.Name + ".json";
                string jsonFile = JsonConvert.SerializeObject(musicKit);
                File.WriteAllText(kitDir, jsonFile);
            }
        }

        public static void LoadKits()
        {
            string dir = Directory.GetCurrentDirectory() + MusicKitsPath;
            MusicKits = new List<MusicKit>();

            if (Directory.Exists(dir))
            {
                foreach (string fileName in Directory.GetFiles(dir))
                {
                    if (!fileName.EndsWith(".json")) continue;
                    string filePath = dir + @"\" + fileName;
                    string jsonFile = "";

                    try
                    {
                        jsonFile = File.ReadAllText(filePath);
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception when trying to load music kits.");
                        Console.WriteLine(e.StackTrace);
                    }
                    finally
                    {
                        MusicKit musicKit = JsonConvert.DeserializeObject<MusicKit>(jsonFile);
                        MusicKits.Add(musicKit);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(dir);
            }
        }

        //Inner class for properties parameters
        private class PropertiesFile
        {
            public string GameDir;
            public MusicKit selectedKit;
        }
    }
}
