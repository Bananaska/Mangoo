using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private bool _loadToFirstScene = true;

    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex += 1;

        if(nextIndex >= SceneManager.sceneCountInBuildSettings)
        {
            nextIndex = 0;
        }
        SceneManager.LoadScene(nextIndex);
        
        
    }
    public void LoadThisScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;      
        SceneManager.LoadScene(currentIndex);
    }
}
