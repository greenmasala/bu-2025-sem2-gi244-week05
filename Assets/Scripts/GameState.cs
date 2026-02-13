using UnityEngine;

public class GameState : MonoBehaviour
{
    public int HitCount = 0;
    void OnTriggerEnter(Collider other)
    {
        //name.StartWith("--") : as the code says... checks if the gameobjects name starts with a certain string
        if (other.gameObject.CompareTag("Enemy"))
        {
            HitCount++;
        }

        if (HitCount >= 10)
        {
            Time.timeScale = 0;
        }
    }
}
