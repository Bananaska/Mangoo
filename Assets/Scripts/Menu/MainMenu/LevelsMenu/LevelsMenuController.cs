using UnityEngine;

public class LevelsMenuController : MonoBehaviour
{
    [SerializeField] private LevelsMenuView _levelsView;

    private void Awake()
    {
        int aviableLevel = GameManager.Instance.GetCurrentLevelIndex();
        _levelsView.SetActiveLevelsButton(aviableLevel);

        _levelsView.OnButtonLevelClick += LaunchLevel;
        _levelsView.OnButtonClose += CloseView;
    }

    private void CloseView()
    {
        Debug.Log("View close");
        _levelsView.gameObject.SetActive(false);
    }

    private void LaunchLevel(int levelIndex)
    {
        int loadLevelIndex = levelIndex += 2;
        Debug.Log("сцена загружена");
        Debug.Log(loadLevelIndex);

        SceneLoader.Instance.LoadSceneByIndex(loadLevelIndex);
    }
}
