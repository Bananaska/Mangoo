using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Dropdown _languageDropdown;
    [SerializeField] private Button _closeButton;

    public event Action<float> OnSliderChanged;
    public event Action<int> OnLanguageChanged;
    public event Action OnMenuClose;

    private void Awake()
    {
        _slider.onValueChanged.AddListener(SliderVolumeChanged);
        _languageDropdown.onValueChanged.AddListener(LanguageChanged);
       _closeButton.onClick.AddListener(SettingsCloseButtonClicked);
    }

    public void SliderVolumeChanged(float value)
    {
        OnSliderChanged?.Invoke(value);
    }

    private void LanguageChanged(int index)
    {
        OnLanguageChanged.Invoke(index);

    }

    private void SettingsCloseButtonClicked()
    {
        OnMenuClose?.Invoke();

    }

   // private void Input

    private void OnDestroy()
    {
        _slider.onValueChanged.RemoveListener(SliderVolumeChanged);
        _languageDropdown.onValueChanged.RemoveListener(LanguageChanged);
        _closeButton.onClick.RemoveListener(SettingsCloseButtonClicked);
    }

}
