using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveData
{
   public static void saveScore(int score)
    {
        if(score > loadScore())
        {
            string path = Application.persistentDataPath + "/PlayerScore.sc";

            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create);

            bf.Serialize(stream, score);
            stream.Close();
        }
       
    }
    public static int loadScore()
    {
        string path = Application.persistentDataPath + "/PlayerScore.sc";

        if(File.Exists(path)) 
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            int score = (int)bf.Deserialize(stream);
            stream.Close();
            return score;
        }
        else
        {
            Debug.LogError("File not found in path");
            return -999;
        }
    }
}
