
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    GameObject[] enemies;
    public string enemiesLeft;
    

    // Update is called once per frame
    void Update(){
    enemies = GameObject.FindGameObjectsWithTag("enemy");
    enemiesLeft = enemies.Length.ToString();
 if (enemiesLeft == "0")
     {
        Debug.Log("Wygrana");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

     }
    }
    void kille(){
     
    }
     
        
    
}
