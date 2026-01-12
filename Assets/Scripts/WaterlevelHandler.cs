using UnityEngine;
using System.Collections;

public class WaterlevelHandler : MonoBehaviour
{
    private ScoreManager scoreManager;
    private GameObject eau;

    private float WATER_MAX = -1.8f;
    private float WATER_MIN = -7.0f;

    [SerializeField] private int maxScorePossible = 5000;
    [SerializeField] private float smoothSpeed = 0.8f;

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
        float newY = Mathf.Lerp(currentY, targetY, Time.deltaTime * smoothSpeed);

        eau.transform.position = new Vector3(eau.transform.position.x, newY, eau.transform.position.z);

        if (newY <= WATER_MIN + 0.05f && !Closing)
        {
            Closing = true;
            StartCoroutine(WaitAndClose());
        }
    }

    IEnumerator WaitAndClose()
    {
        yield return new WaitForSeconds(5.0f);
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}