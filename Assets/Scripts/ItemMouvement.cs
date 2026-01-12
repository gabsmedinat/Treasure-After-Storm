using UnityEngine;


public class ItemMouvement : MonoBehaviour
{
    [Header("Speed Settings")]
    public float targetSpeed = 3f;      // Set to 2 for the SkyBackGround and set to 2.5 for the OceanBackground
    public float acceleration = 0.02f;
    public float itemSpeed = 0f;
    Rigidbody2D itemRB;
    public EnvironmentMovement backgroundScript;

    void Start()
    {
        GameObject oceanObject = GameObject.FindWithTag("Ocean");

        if (oceanObject != null)
        {
            backgroundScript = oceanObject.GetComponent<EnvironmentMovement>();
        }
        else
        {
            Debug.LogError("Script introuvable !");
        }
        itemRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        itemSpeed = backgroundScript.currentSpeed;
        itemRB.linearVelocity = new Vector2(-itemSpeed*36, 0);
    }
}
