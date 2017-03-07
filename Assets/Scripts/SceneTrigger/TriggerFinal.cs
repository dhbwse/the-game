using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinal : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other) { 
        SceneManager.LoadScene("testscene");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
