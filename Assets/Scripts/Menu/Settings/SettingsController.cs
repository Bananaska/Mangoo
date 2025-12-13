using Lessons.Plugins.Lesson_Localization;
using UnityEngine;
using UnityEngine.Rendering;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private SettingsView _settingsView;

    private void Awake()
    {
        int index = LanguageManager.Language == SystemLanguage.Russian ? 0 : 1;
        _settingsView.SliderVolumeChanged(index);
        _settingsView.OnSliderChanged += VolumeChanged;
        _settingsView.OnMenuClose += CloseClicked;
        _settingsView.OnLanguageChanged += LanguageChanged;

    }

    private void VolumeChanged(float newVolume)
    {
        SoundManager.Instance.VolumeChange(newVolume);
    }

    private void CloseClicked()
    {
        _settingsView.gameObject.SetActive(false);
    }

    private void LanguageChanged(int languageChange)
    {
        SystemLanguage language = languageChange == 0? SystemLanguage.Russian : SystemLanguage.English;
    }
    private void OnDestroy()
    {
        _settingsView.OnSliderChanged -= VolumeChanged;
    }
}
