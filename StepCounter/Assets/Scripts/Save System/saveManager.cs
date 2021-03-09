using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveManager
{
    public static void save()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        //creates path where the file is saved
        string path = new Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        TrophySystem data = new TrophySystem();

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void load()
    {
        string path = new Application.persistentDataPath + "/player.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

           TrophySystem data = formatter.Deserialize(stream) as TrophySystem;
            stream.Close();
            return data;
        } else
        {
            return null;
        }

    }
}
