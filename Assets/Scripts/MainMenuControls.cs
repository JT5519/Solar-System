using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuControls : MonoBehaviour
{
    public void onPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void onQuit()
    {
        Application.Quit();
    }
    public void onBack()
    {
        SceneManager.LoadScene(0);
    }
      
}
