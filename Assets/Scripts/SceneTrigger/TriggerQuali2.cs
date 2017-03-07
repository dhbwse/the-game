using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerQuali2 : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other) { 
        SceneManager.LoadScene("mainMenu");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
