using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public GameObject player;
    public int playerHealth = 100;
    public Text currentHealth;

    void Update ()
    {
        currentHealth.text = string.Format("Health: " + playerHealth);

        if (playerHealth <=0)
        {
            // If player loses all health, load the lose scene
            SceneManager.LoadScene(4);
        }
	}

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            // If player impacts the enemy, lose health
            playerHealth -= 20;
        }
    }
}
