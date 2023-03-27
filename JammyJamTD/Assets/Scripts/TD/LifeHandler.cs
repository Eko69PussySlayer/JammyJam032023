using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHandler : MonoBehaviour
{

    public int maxHealth = 100;

    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void Take_Damage(int amount)
    {
        currentHealth -= amount;
        Debug.Log(gameObject + " took " + amount + " damage and has " + currentHealth + " HP left.");

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
