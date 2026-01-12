using UnityEngine;
using System.Collections;

public class WaterlevelHandler : MonoBehaviour
{
    private ScoreManager scoreManager;
    private GameObject eau;

    private float WATER_MAX = -1.8f;
    private float WATER_MIN = -7.0f;

    [Header("Game Settings")]
    [SerializeField] private int maxScorePossible =1500;
    [SerializeField] private float smoothSpeed = 1.2f; 

    private bool Closing = false;

    void Start()
    {
        scoreManager = ScoreManager.instance;
        eau = GameObject.Find("Eau");

        if (eau != null)
        {
            eau.transform.position = new Vector3(eau.transform.position.x, WATER_MAX, eau.transform.position.z);
        }
    }

    void Update()
    {
        if (eau == null || scoreManager == null) return;

        float t = Mathf.InverseLerp(0, maxScorePossible, scoreManager.score);
        float targetY = Mathf.Lerp(WATER_MAX, WATER_MIN, t);

        float currentY = eau.transform.position.y;

        float newY = Mathf.MoveTowards(currentY, targetY, smoothSpeed * Time.deltaTime);

        eau.transform.position = new Vector3(eau.transform.position.x, newY, eau.transform.position.z);

        if (newY <= WATER_MIN + 1f && !Closing)
        {
            Closing = true;
            StartCoroutine(WaitAndClose());
        }

    }

    public void CloseGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif

    }

    IEnumerator WaitAndClose()
    {
        yield return new WaitForSeconds(30f);
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}