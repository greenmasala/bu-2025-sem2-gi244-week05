using UnityEditor.UI;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int attackPoint = 5;

    void OnTriggerEnter(Collider other)
    {
        HealthV1 health = other.GetComponent<HealthV1>(); //step over: when breakpoint is activated to go through each line of code
        health.TakeDamage(attackPoint); //step into: go to the function thats called here
        Destroy(gameObject);

        Debug.Log("Hit: " + other.gameObject.name); //breakpoints (the redcircle next to this code, only works after attach to unity): stops unity when this code is executed and gives info in vs on what happened
    }
}
