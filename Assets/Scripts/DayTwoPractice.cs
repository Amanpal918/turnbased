using UnityEngine;

public class DayTwoPractice : MonoBehaviour
{
    // private void Start()
    // {
    //     int remainingHealth = CalculateRemainingHealth(100, 30);
    //     Debug.Log(remainingHealth);
    // }

    // private int CalculateRemainingHealth(int health, int damage)
    // {
    //     return health - damage;
    // }

    // private void Start ()
    // { 
    //     int totalmoney = CalculateTotalCoins(40, 15);
    //     Debug.Log(totalmoney); 

    // }

    //  private int CalculateTotalCoins(int currentCoins ,int collectedCoins )
    //  {
    //     return currentCoins + collectedCoins;
    //  }

    private void Start()
    {
        int[] enemyHealth = { 60, 25, 90, 10, 45 };

        int lowestHealth = FindLowestHealth(enemyHealth);
        Debug.Log(lowestHealth); // Expected: 10
    }

    private int FindLowestHealth(int[] healthValues)
    { 
         int lowestHealth = healthValues[0];
        for(int i =1; i< healthValues.Length; i++)
        {
            if (  healthValues[i] < lowestHealth)
            {
                lowestHealth = healthValues[i];
              
            }
        }
         return lowestHealth ;
    }
}
