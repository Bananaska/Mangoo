using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private MainMenuView _mainMenu;
    [SerializeField] private LevelsMenuView _levelsMenuView;
    [SerializeField] private SettingsView _settingsView;

    private void Awake()
    {
        //_mainMenu.OnPlayButtonClicked+=
    }

    private void PlayGame()
    {

    }
    private void OpenLevelsPanel()
    {

    }
    private void OpenSettings()
    {

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
