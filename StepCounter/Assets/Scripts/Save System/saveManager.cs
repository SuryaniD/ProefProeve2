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
        string path = new Application.persistentDataPath + "/player.save";

    }
}
