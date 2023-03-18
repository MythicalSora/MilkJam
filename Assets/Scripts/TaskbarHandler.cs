using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskbarHandler : MonoBehaviour
{
    // Update is called once per frame
    public void ChangeActiveScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
