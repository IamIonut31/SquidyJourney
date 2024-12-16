using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveGame(Score score)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/game7.sex";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(score);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadGame ()
    {
        string path = Application.persistentDataPath + "/game7.sex";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }

    public static void SaveSkins(ShopManager shopmanager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/skins7.sex";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerSkins data = new PlayerSkins(shopmanager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerSkins LoadSkins()
    {
        string path = Application.persistentDataPath + "/skins7.sex";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSkins data = formatter.Deserialize(stream) as PlayerSkins;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
    public static void SaveLevels(LevelManager levelmanager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/levels7.sex";
        FileStream stream = new FileStream(path, FileMode.Create);

        LevelData data = new LevelData(levelmanager);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static LevelData LoadLevels()
    {
        string path = Application.persistentDataPath + "/levels7.sex";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LevelData data = formatter.Deserialize(stream) as LevelData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
