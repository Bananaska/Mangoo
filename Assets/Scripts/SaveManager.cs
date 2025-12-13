using UnityEngine;

public class SaveManager
{
    private const string LevelSaveKey = "LastComleteLevel";

    public static void SaveLevelIndex(int levelIndex)
    {
        int safeIndex = Mathf.Max(1, levelIndex);
        PlayerPrefs.SetInt(LevelSaveKey, safeIndex);
        PlayerPrefs.Save();
    }

    public static int LoadLevelIndex()
    {
        return PlayerPrefs.GetInt(LevelSaveKey, 1);
    }
}
