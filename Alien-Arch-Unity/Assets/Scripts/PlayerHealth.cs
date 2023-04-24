using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    // This will be starting health for the player
    public int startingHealth;
    
    // This will be the current health of the player 
    // this will change as the game progresses
    int currentHealth;
    private void Awake()
    {
        // Initialise players current health to be equal to the starting health at the beginning of game
        currentHealth = startingHealth;
    }
    //Not built into unity
    // must be called by user
    // function to change player health
    //and add condition if player health is low enough to kill
    public void ChangeHealth(int changeAmount)
    {
        currentHealth = currentHealth + changeAmount;

        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
    }
    public void Kill()
    {
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
