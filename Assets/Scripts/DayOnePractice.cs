using UnityEngine;

public class DayOnePractice : MonoBehaviour
{
    private void Start()
     {
    //  largest 
        // int[] scores = { 25, 70, 15, 90, 45 };

        // int highestScore = scores[0];
        //  for (int i =1; i<scores.Length; i++)
        //  {
        //         if (scores[i] < highestScore)
        //         {
        //             highestScore = scores[i];

        //         }
        //         Debug.Log(highestScore);
        //  }
// smallest  
    int[] enemyHealth = { 60, 25, 90, 10, 45 };
      int lowesthealth = enemyHealth[0];

       for (int i =1; i< enemyHealth.Length; i++)
         {
                if (enemyHealth[i] < lowesthealth)
                {
                    lowesthealth = enemyHealth[i];

                }
         }
                Debug.Log(lowesthealth);
    }
}