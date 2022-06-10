
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    
    void  OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "rock")
        {
            Destroy(gameObject);
        }
    }
}
