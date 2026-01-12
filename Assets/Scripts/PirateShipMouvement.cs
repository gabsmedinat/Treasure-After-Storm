using UnityEngine;

public class PirateShipMouvement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float verticalMovement;
    public float shipPosition;
    public float MAX_Y = 3.7f;
    public float MIN_Y = -3.5f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        verticalMovement = Input.GetAxisRaw("Vertical") * movementSpeed;
        rb.linearVelocity = new Vector2(0, verticalMovement);

        this.transform.rotation = new Quaternion(0, 0,0,1);

        shipPosition = this.transform.position.y;
        rb.position = new Vector2(0, shipPosition);
        if(shipPosition > MAX_Y)
        {
            rb.position = new Vector2(0, MAX_Y);
        }

        if (shipPosition < MIN_Y)
        {
            rb.position = new Vector2(0, MIN_Y);
        }

    }
}
