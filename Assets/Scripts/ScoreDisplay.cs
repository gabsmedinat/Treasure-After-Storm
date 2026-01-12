

using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text display;


    void Update()
    {
        if (ScoreManager.instance != null && display != null)
        {
            display.text = ScoreManager.instance.score.ToString();
        }
    }
}
