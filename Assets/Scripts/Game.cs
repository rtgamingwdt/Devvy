using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static PlayerData data;

    // Start is called before the first frame update
    void Start()
    {
        string saveFile = Application.persistentDataPath + "/data.json";
        
        if (File.Exists(saveFile))
        {
            // Read the entire file and save its contents.
            string fileContents = File.ReadAllText(saveFile);
            Game.data = JsonUtility.FromJson<PlayerData>(fileContents);
        }
        else
        {
            using (StreamWriter sw = File.CreateText(saveFile))
            {
                string defaultData = Application.dataPath + "/Resources/data.json";
                string defaultContent = File.ReadAllText(defaultData);
                sw.Write(defaultContent);
            }
        }
    }

    public static PlayerData getData() {
        return data;
    }

    // Update is called once per frame
    void Update() { }
}
