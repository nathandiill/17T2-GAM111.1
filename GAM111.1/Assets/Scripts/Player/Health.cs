using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public GameObject player;
    public int playerHealth = 100;
    public Text currentHealth;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        currentHealth.text = string.Format("Health: " + playerHealth);

        if (playerHealth <=0)
        {
            SceneManager.LoadScene(4);
        }
	}

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 20;
        }
    }
}
