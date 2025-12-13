using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private int _score;
    private int _currentLevelIndex;

    private void Awake()
    {
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

    public void SetCurrentLevelIndex(int index)
    {
        _currentLevelIndex = Mathf.Max(1, index);
        SaveManager.SaveLevelIndex(_currentLevelIndex);
    }

    public int GetCurrentLevelIndex()
    {
        return _currentLevelIndex;
    }
}
