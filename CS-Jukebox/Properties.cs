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
        //Paths
        public static readonly string ConfigPath = @"\csgo\cfg\gamestate_integration_jukebox.cfg";
        public static readonly string ConfigName = @"\gamestate_integration_jukebox.cfg";
        public static readonly string PropertiesFilePath = @"\properties.json";
        public static readonly string MusicKitsPath = @"\kits";

        public static string GameDir = null;
        public static int MasterVolume;
        public static MusicKit SelectedKit
        {
            get { return selectedKit; }
            set { SetKit(value); }
        }

        public static List<MusicKit> MusicKits = null;

        private static string startDir;

        private static MusicKit selectedKit = null;
        private static string SelectedKitName = null;

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

        //Converts settings to json file then saves it
        public static void SaveProperties()
        {
            string dir = startDir + PropertiesFilePath;

            PropertiesFile propFile = new PropertiesFile();
            propFile.GameDir = GameDir;
            propFile.SelectedKitName = SelectedKitName;
            propFile.MasterVolume = MasterVolume;
            Console.WriteLine(propFile.GameDir);

            string jsonFile = JsonConvert.SerializeObject(propFile);

            Console.WriteLine("Saving json properties: ");
            Console.WriteLine(jsonFile);
            File.WriteAllText(dir, jsonFile);
        }

        //Reads properties file then deserializes it
        public static void LoadProperties()
        {
            startDir = Directory.GetCurrentDirectory();
            string dir = startDir + PropertiesFilePath;
            PropertiesFile propFile;

            try
            {
                string jsonFile = File.ReadAllText(dir);
                propFile = JsonConvert.DeserializeObject<PropertiesFile>(jsonFile);
                GameDir = propFile.GameDir;
                SelectedKitName = propFile.SelectedKitName;
                MasterVolume = propFile.MasterVolume;
            }
            catch (FileNotFoundException e)
            {
                propFile = new PropertiesFile();
            }
        }

        //Copies the config from local folder to CS:GO cfg folder
        public static void CreateConfig()
        {string configPath = Properties.GameDir + Properties.ConfigPath;
            string configSrc = startDir + Properties.ConfigName;

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
            string dir = startDir + MusicKitsPath;

            Directory.CreateDirectory(dir);

            foreach (MusicKit musicKit in MusicKits)
            {
                Console.WriteLine("Saving song: " + musicKit.Name);
                string kitDir = dir + @"\" + musicKit.Name + ".json";
                Console.WriteLine(kitDir);
                string jsonFile = JsonConvert.SerializeObject(musicKit);
                Console.WriteLine(jsonFile);
                File.WriteAllText(kitDir, jsonFile);
            }
        }

        public static void LoadKits()
        {
            string dir = startDir + MusicKitsPath;
            MusicKits = new List<MusicKit>();

            if (Directory.Exists(dir))
            {
                foreach (string filePath in Directory.GetFiles(dir))
                {
                    if (!filePath.EndsWith(".json")) continue;
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

            //Find a value for SelectedKit if applicable
            if (MusicKits.Count > 0)
            {
                foreach (MusicKit musicKit in MusicKits)
                {
                    if (musicKit.Name.Equals(SelectedKitName))
                    {
                        SelectedKit = musicKit;
                    }
                }

                if (SelectedKit == null)
                {
                    SelectedKit = MusicKits[0];
                }
            }
        }

        //Deletes the json file for a kit but not the kit itself
        public static void DeleteKitFile(string kitName)
        {
            string dir = startDir + MusicKitsPath;
            string kitDir = dir + @"\" + kitName + ".json";
            File.Delete(kitDir);
        }

        private static void SetKit(MusicKit newKit)
        {
            selectedKit = newKit;
            SelectedKitName = selectedKit.Name;
        }

        //Inner class for properties parameters
        private class PropertiesFile
        {
            public string GameDir;
            public string SelectedKitName;
            public int MasterVolume;
        }
    }
}
