using UnityEngine;
using YG;

public class EndLevelController : MonoBehaviour
{
    [SerializeField] private EndLevelView _endMenuView;
    [SerializeField] private SceneLoader _sceneLoader;

    private void Start()
    {
        _endMenuView.OnClickedButtonNext += LoadNextScene;
        _endMenuView.OnClickedButtonRestart += RestartScene;
        _endMenuView.OnClickedButtonMainMenu += LoadMainMenuScene;
    }

    private void LoadNextScene()
    {
        _sceneLoader.LoadNextScene();
        //YG2.InterstitialAdvShow();
    }
    private void RestartScene()
    {
        _sceneLoader.LoadThisScene();
    }
    private void LoadMainMenuScene()
    {

    }
}
