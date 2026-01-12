using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private int seedValue;
    private ScoreManager scoreManager;
    private LifeSystem lifeSystem;

    private void Start()
    {
        scoreManager = ScoreManager.instance;
        lifeSystem = LifeSystem.instance;
    }


    private void OnCollisionEnter2D(Collision2D collision) 
    {
       
        if(collision.gameObject.tag == "Trash")
        {
            Debug.Log("Dechet");
            lifeSystem.TakeTrash(1);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Seed") 
        {
            scoreManager.UpdateCoins(seedValue);
            Debug.Log("Grain !");
            Destroy(collision.gameObject);
        }

    }
}
