using System;
using UnityEngine;
using UnityEngine.UI;

public class LevelsMenuView : MonoBehaviour
{
    [SerializeField] private Button[] _buttons;
    [SerializeField] private Button _buttonClose;

    public event Action<int> OnButtonLevelClick;
    public event Action OnButtonClose;

    private void Awake()
    {
        foreach (var button in _buttons)
        {
            button.onClick.RemoveAllListeners();
        }

        for (int i = 0; i < _buttons.Length; i++)
        {
            int index = i ;
            _buttons[i].onClick.AddListener(() => OnButtonLevelClick?.Invoke(index));
        }

        _buttonClose.onClick.AddListener(CloseLevelsPanel);
    }

    private void CloseLevelsPanel()
    {
        Debug.Log("Close Button");
        OnButtonClose?.Invoke();
    }
    public void SetActiveLevelsButton(int currentLevel)
    {
        int currentActivIndex = currentLevel; //-1;

        for(int i=0; i <= currentActivIndex; i++)
        {
            _buttons[i].interactable = i <= currentActivIndex;
        }
    }

    private void OnDestroy()
    {
        _buttonClose.onClick.RemoveListener(CloseLevelsPanel);
        //_buttonClose.onClick.RemoveListener(SetActiveLevelsButton);

    }
}
