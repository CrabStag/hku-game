using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSmash : MonoBehaviour
{
	private Rigidbody2D m_Rigidbody2D;
    private bool attackIngedrukt = false;
    private float timeBtwAttack = 0;
    public float startTimeBtwAttack; 

    public Transform attackPos;
    //public Layermask whatIsEnemies;
    public float attackRange;
    public int damage; 
    
    void Update()
    {
        if(timeBtwAttack <=0) {
        	//then you can attack
        	if(Input.GetKey(KeyCode.X)) {
 				timeBtwAttack = startTimeBtwAttack;
 				// do attack here...
 				Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange);
 				for (int i = 0; i < enemiesToDamage.Length; i++) {
 					enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);

 				}
        	}

        	

        } else {
        	timeBtwAttack -= Time.deltaTime;
        }
    }
    void OnDrawGizmosSelected(){
    	Gizmos.color = Color.red;
    	Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
