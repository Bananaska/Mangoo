using System;
using UnityEngine;
using UnityEngine.UI;

public class LoadMenuView : MonoBehaviour
{
    [SerializeField] private Button _button;

    public event Action OnButtonTabletClicked;

    private void Awake()
    {
        _button.onClick.AddListener(ButtonTabletClicked);

    }

    private void ButtonTabletClicked()
    {
        OnButtonTabletClicked?.Invoke();

    }

}
