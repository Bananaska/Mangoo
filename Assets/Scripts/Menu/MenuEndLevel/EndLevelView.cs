using System;
using UnityEngine;
using UnityEngine.UI;

public class EndLevelView : MonoBehaviour
{
    [SerializeField] private Button _next;
    [SerializeField] private Button _restart;
    [SerializeField] private Button _mainMenu;

    public event Action OnClickedButtonNext;
    public event Action OnClickedButtonRestart;
    public event Action OnClickedButtonMainMenu;

    private void Start()
    {
        _next.onClick.AddListener(ClickedButtonNext);
        _restart.onClick.AddListener(ClickedButtonRestart);
        _mainMenu.onClick.AddListener(ClickedButtonMainMenu);
    }
    private void ClickedButtonNext()
    {
        OnClickedButtonNext?.Invoke();
    }
    private void ClickedButtonRestart()
    {
        OnClickedButtonRestart?.Invoke();
    }
    private void ClickedButtonMainMenu()
    {
        OnClickedButtonMainMenu?.Invoke();
    }

   

    private void OnDestroy()
    {
        _next.onClick.RemoveListener(ClickedButtonNext);
        _restart.onClick.RemoveListener(ClickedButtonRestart);
        _mainMenu.onClick.RemoveListener(ClickedButtonMainMenu);
    }
}
