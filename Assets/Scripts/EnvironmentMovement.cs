

using UnityEngine;

public class EnvironmentMovement : MonoBehaviour
{
    [Header("Speed Settings")]
    public float targetSpeed = 0.5f;      // Set to 2 for the SkyBackGround and set to 2.5 for the OceanBackground
    public float acceleration = 0.02f;   

    public float currentSpeed = 0f;     // Starts at zero

    [SerializeField]
    private Renderer bgRenderer;

    void Update()
    {
        currentSpeed = Mathf.MoveTowards(currentSpeed, targetSpeed, acceleration * Time.deltaTime);
        bgRenderer.material.mainTextureOffset += new Vector2(currentSpeed * Time.deltaTime, 0);
    }
}