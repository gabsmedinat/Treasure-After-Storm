using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{
    public void PlayGame()
    {
        Invoke("LoadGame", 2f);
    }

    public void LoadGame() 
    {         
        SceneManager.LoadScene(2);
    }
}
