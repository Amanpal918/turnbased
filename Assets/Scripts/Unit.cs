using UnityEngine;

public class Unit : MonoBehaviour
{
     public UnitStats baseStats;
     public int currentHealth;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = baseStats.maxHealth;
        Debug.Log(baseStats.unitName + " spawned into the arena with " + currentHealth + " HP.");
    
    }

    // Update is called once per frame
    public bool TakeDamage(int damage )
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0);
        Debug.Log(baseStats.unitName + " took " + damage + " damage! Current HP: " + currentHealth);
        if (currentHealth == 0)
            return true;  // The unit is dead
        else
            return false; // The unit is still alive
    }
}
