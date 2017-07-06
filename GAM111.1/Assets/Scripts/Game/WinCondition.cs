using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour {

    public void OnTriggerEnter(Collider col)
    {
        // On trigger, load the win scene
        SceneManager.LoadScene(5);
    }

}
