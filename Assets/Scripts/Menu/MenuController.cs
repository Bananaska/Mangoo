using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private MenuView _menuView;
    [SerializeField] private SettingsView _settingsView;
    [SerializeField] private Button _toggleMenuButton;

    private bool _isMenuActive;

    void Start()
    {
        _menuView.OnClickedButtonPlay += ToggleMenu;
        //_menuView.OnClickedButtonSettings += ToggleMenu;
        //_menuView.OnClickedButtonExit += ToggleMenu;
        _toggleMenuButton.onClick.AddListener(ToggleMenu);
    }

    private void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
        Time.timeScale = 1;
    }

    private void ToggleMenu()
    {
        _isMenuActive = !_isMenuActive;
        _menuView.gameObject.SetActive( _isMenuActive );
        Time.timeScale = _isMenuActive ? 0f : 1f;
    }
}
