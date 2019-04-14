using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    //public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Object");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
