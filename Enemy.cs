using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
   

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    { 
    	if(health <= 0){
    		Destroy(this.gameObject);

    	}
        
    } 
    public void TakeDamage(int damage){
    	health -= damage;
    	Debug.Log ("damage TAKEN");

    }
}
