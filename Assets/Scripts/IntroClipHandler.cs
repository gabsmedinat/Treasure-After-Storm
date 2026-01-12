using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroHandler : MonoBehaviour
{
    private VideoPlayer vPlayer;

    void Start()
    {
        vPlayer = GetComponent<VideoPlayer>();
        vPlayer.loopPointReached += GetMenu;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(1);
        }
    }

    void GetMenu(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);   // Pour modifier la transition
    }
}