
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonkeyCollision : MonoBehaviour
{
    
    void  OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "banana")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
