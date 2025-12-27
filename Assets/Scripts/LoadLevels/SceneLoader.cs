using UnityEngine;
using UnityEngine.SceneManagement;
using YG;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance { get; private set; }

    [SerializeField] private bool _loopToFirstScene = true;

    private void Awake()
    {
        Instance = this;

        if (Instance != null)
        {

            Debug.Log("Инстанс тут");
           // Instance = this;
        }
        //else
        //{
        //    Destroy(gameObject);
       // }
        DontDestroyOnLoad(gameObject);

    }
    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = currentIndex += 1;

        if(nextIndex >= SceneManager.sceneCountInBuildSettings)
        {
            if (_loopToFirstScene)
            {
                Debug.Log("Опасненько");
                return;
            }
            nextIndex = 0;
        }
        SceneManager.LoadScene(nextIndex);  
    }
    public void LoadSceneByIndex(int sceneIndex)
    {
        if (sceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            sceneIndex = 0;
        }
        SceneManager.LoadScene(sceneIndex);
    }
    public void LoadThisScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;      
        SceneManager.LoadScene(currentIndex);
    }
}
