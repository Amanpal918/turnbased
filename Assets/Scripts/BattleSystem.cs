using UnityEngine;
using System.Collections;

public enum BattleState {START, PLAYERTURN, ENEMYTURN, WIN,LOST}
public class BattleSystem : MonoBehaviour
{ 
    public BattleState state;
    public Unit heroUnit;
    public Unit enemyUnit;

     void Start()
     {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
     }

     IEnumerator SetupBattle()
     {
        Debug.Log("Arena initializing...");
        // Wait 1 second to simulate characters loading in
         yield return new WaitForSeconds(1f);
         state = BattleState.PLAYERTURN;
         PlayerTurn();
     }
    void PlayerTurn()
    {
        Debug.Log("its your turn.");
    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
        return;
         StartCoroutine(PlayerAttack());
    }
    IEnumerator PlayerAttack()
    {
     Debug.Log(heroUnit.baseStats.unitName + " strikes!");
    bool isDead = enemyUnit.TakeDamage(heroUnit.baseStats.attackPower);
    
    // Wait a second for visual pacing
    yield return new WaitForSeconds(1f);
    
    // The decision happens here, STILL INSIDE PlayerAttack()
    if (isDead == true)
    {
        Debug.Log("Enemy is dead!");
        state = BattleState.WIN; 
    }
    else 
    {
        state = BattleState.ENEMYTURN; 
        StartCoroutine(EnemyTurn());
    }
    }
    
    IEnumerator EnemyTurn()
    {
        Debug.Log(enemyUnit.baseStats.unitName + " retaliates!");
        heroUnit.TakeDamage(enemyUnit.baseStats.attackPower);
        
        yield return new WaitForSeconds(1f);
        
        // Loop back to the player
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }
}
