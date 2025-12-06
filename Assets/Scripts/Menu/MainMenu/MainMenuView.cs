using System;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _changedLevelButton;
    [SerializeField] private Button _settingButton;
    [SerializeField] private Button _exitButton;

    public event Action OnPlayButtonClicked;
    public event Action OnChangedLevelButtonClicked;
    public event Action OnSettingButtonClicked;
    public event Action OnExitButtonClicked;

    private void Awake()
    {
        _playButton.onClick.AddListener(PlayButtonClicked);
        _playButton.onClick.AddListener(ChangedLevelButtonClicked);
        _playButton.onClick.AddListener(SettingButtonClicked);
        _playButton.onClick.AddListener(ExitButtonClicked);
    }

    private void PlayButtonClicked()
    {
        OnPlayButtonClicked?.Invoke();
    }
    private void ChangedLevelButtonClicked()
    {
        OnChangedLevelButtonClicked?.Invoke();
    }
    private void SettingButtonClicked()
    {
        OnSettingButtonClicked?.Invoke();
    }
    private void ExitButtonClicked()
    {
        OnExitButtonClicked?.Invoke();
    }

    private void OnDestroy()
    {
        _playButton.onClick.RemoveListener(PlayButtonClicked);
        _changedLevelButton.onClick.RemoveListener(ChangedLevelButtonClicked);
        _settingButton.onClick.RemoveListener(SettingButtonClicked);
        _exitButton.onClick.RemoveListener(ExitButtonClicked);
    }

}
