using System;
using UnityEngine;

public class LoadMenuController : MonoBehaviour
{
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private LoadMenuView _loadMenuView;
    [SerializeField] private int _menuIndex;

    private void Awake()
    {
        _loadMenuView.OnButtonTabletClicked += LoadMenu;
    }


    private void LoadMenu()
    {

        _sceneLoader.LoadNextScene();

    }
}
