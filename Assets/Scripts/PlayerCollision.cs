using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
   
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Invoke("LevelRestart", 2f);
        }
    }
    void LevelRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
