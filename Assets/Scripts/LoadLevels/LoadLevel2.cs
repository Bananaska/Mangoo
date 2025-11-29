using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    [SerializeField] private int sceneIndex = 1;


     void OnButtonNextCliked()
    {

        SceneManager.LoadScene(sceneIndex);

    }
}
