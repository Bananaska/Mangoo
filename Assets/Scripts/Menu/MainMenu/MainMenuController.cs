using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private MainMenuView _mainMenu;
    [SerializeField] private LevelsMenuView _levelsMenuView;
    [SerializeField] private SettingsView _settingsView;

    private void Awake()
    {
        _mainMenu.OnPlayButtonClicked += PlayGame;
        _mainMenu.OnChangedLevelButtonClicked += OpenLevelsPanel;
        _mainMenu.OnSettingButtonClicked += OpenSettings;
        _mainMenu.OnExitButtonClicked += ExitGame;
    }

    private void PlayGame()
    {
        int nextSceneIndex = GameManager.Instance.GetCurrentLevelIndex() +1;
        SceneLoader.Instance.LoadSceneByIndex(nextSceneIndex);

    }
    private void OpenLevelsPanel()
    {
        _levelsMenuView.gameObject.SetActive(true);
    }
    private void OpenSettings()
    {
        _settingsView.gameObject.SetActive(true);
    }

    private void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Aplication.Quit
#endif
    }
}
