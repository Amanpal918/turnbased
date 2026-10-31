using UnityEngine;


public class DayThreePractice : MonoBehaviour
  {
//     private void Start()
//     {
//         int[] enemyHealth = { 60, 0, 25, -10, 90, 0 };

//         int aliveEnemies = CountAliveEnemies(enemyHealth);
//         Debug.Log(aliveEnemies); // Expected: 3
//     }

//     private int CountAliveEnemies(int[] healthValues)
//     {
//         // int aliveEnemies = healthValues[0];
//          int count =0;
//         for(int i = 0; i< healthValues.Length; i++)
//         {

//             if (healthValues[i] > 0)
//             {
//                  count ++;
//             }
//         }
        
//         return  count ;
//     }

// double a number .....
    // private void Start()
    // {
    //     int answer = DoubleNumber(6);
    //     Debug.Log(answer); // Expected: 12
    // }

    // private int DoubleNumber(int number)
    // {
    //     return number *2;
    // }

// sum of all numbers
// private void Start()
// {
//     int[] coins = { 10, 20, 5, 15 };

//     int totalCoins = CalculateSum(coins);
//     Debug.Log(totalCoins); // Expected: 35
// }

// private int CalculateSum(int[] values)
// {
//     int total = 0;
//     for(int i =0; i <values.Length; i++)
//     {
//          total = total + values[i];
//     }
//      return total ;
// }

// count zero in the array 






// limit function 

 private void Start()
    {
        int[] scores = { 10, 50, 80, 40, 90 };

        int result = CountAboveLimit(scores, 40);
        Debug.Log(result); // Expected: 3
    }

    private int CountAboveLimit(int[] values, int limit)
    {
       int count =0;
        for(int i =0;i < values.Length; i++)
        {
          if (values[i]>limit )
          {
            count++;
          }
        }

        return count; // Placeholder: replace with your final count.
    }

}