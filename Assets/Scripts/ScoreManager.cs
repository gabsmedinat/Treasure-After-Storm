//using UnityEngine;
//using TMPro;

//public class ScoreManager : MonoBehaviour
//{
//    public static ScoreManager instance;
//    [SerializeField] private TMP_Text scoreDisplay;

//    public int score;

//    private void Awake() {

//        if (instance == null)
//        {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    private void OnGUI()
//    {
//        scoreDisplay.text = score.ToString();
//    }

//    public void updateScore(int amount)
//    {
//        score += amount;
//    }
//}


using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateCoins(int amount)
    {
        score += amount;
    }
}