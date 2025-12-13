using System;
using UnityEngine;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Button _buttonPlay;
    [SerializeField] private Button _buttonSettings;
    [SerializeField] private Button _buttonExit;

    public event Action OnClickedButtonPlay;
    public event Action OnClickedButtonSettings;
    public event Action OnClickedButtonExit;

    private void Start()
    {
        _buttonPlay.onClick.AddListener(PlayButtonClicked);
        _buttonSettings.onClick.AddListener(SettingsButtonClicked);
        _buttonExit.onClick.AddListener(ExitButtonClicked);
    }
    private void PlayButtonClicked()
    {
        OnClickedButtonPlay?.Invoke();
    }
    private void SettingsButtonClicked()
    {
        OnClickedButtonSettings?.Invoke();
    }
    private void ExitButtonClicked()
    {
        OnClickedButtonExit?.Invoke();
    }
    private void OnDestroy()
    {
        _buttonPlay.onClick.RemoveListener(PlayButtonClicked);
        _buttonSettings.onClick.RemoveListener(SettingsButtonClicked);
        _buttonExit.onClick.RemoveListener(ExitButtonClicked);
    }
}
