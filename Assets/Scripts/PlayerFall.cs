using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        if(player.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
