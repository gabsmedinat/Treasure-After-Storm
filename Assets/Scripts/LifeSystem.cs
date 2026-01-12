using UnityEngine.SceneManagement;
using UnityEngine;

public class LifeSystem : MonoBehaviour
{
    public static LifeSystem instance;

    public GameObject[] lifes;
    public int life;

    private void Awake()
    {

        if (!instance)
        {
            instance = this;
        }
    }


    void Update()
    {
        if(life < 1) {
            Destroy(lifes[0]);
            GameOver();
        }
        else if (life < 2) {
            Destroy(lifes[1]);
        }
        else if (life < 3) {
            Destroy(lifes[2]);
        }
        else if (life < 4) {
            Destroy(lifes[3]);
        }
        else if (life < 5) {
            Destroy(lifes[4]);
        }
    }

    public void TakeTrash(int val)
    {
        life -= val;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(3);
    }
}
