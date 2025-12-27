using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int _score;
    private int _currentLevelIndex;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            _currentLevelIndex = SaveManager.LoadLevelIndex();

        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void AddScore(int points)
    {
        _score += points;
        Debug.Log("Score: " + _score);
    }

    public void GetCurrentLevelIndex(int index)
    {
        _currentLevelIndex = Mathf.Max(1, index);
        SaveManager.SaveLevelIndex(_currentLevelIndex);
    }

    public int GetCurrentLevelIndex()
    {
        return _currentLevelIndex;
    }

    private void MarkLevelCompleted(int finishedLevelBuildIndex)
    {
        int unlockedLevelIndex = finishedLevelBuildIndex + 1;
        if (unlockedLevelIndex >= _currentLevelIndex)
        {
            return;
        }
        _currentLevelIndex = unlockedLevelIndex;

        SaveManager.SaveLevelIndex(_currentLevelIndex);
    }
}
