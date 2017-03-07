using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerQuali1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Car");
    }


    // Update is called once per frame
    void Update () {
		
	}
}
