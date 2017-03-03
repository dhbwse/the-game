using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour, IPointerClickHandler
{

    private bool isPause = false;
    private Rect butRect;
    private float ctrlWidth = 160;
    private float ctrlHeight = 30;
   

    // Use this for initialization
    void Awake () {
        butRect = new Rect((Screen.width - ctrlWidth)/2, 0, ctrlWidth, ctrlHeight);
	}

    private void OnGUI()
    {
        if (isPause)
        {
            butRect.y = (Screen.height - ctrlHeight) / 2;
            if(GUI.Button (butRect, "Weiter"))
            {
                ToggleTimeScale();
            }

            butRect.y += ctrlHeight+20;
            if (GUI.Button(butRect, "Scene wechseln"))
            {
                ToggleTimeScale();
                SceneManager.LoadScene("Car");
            }
        }
    }

    public void OnPointerClick(PointerEventData data)
    {
        ToggleTimeScale();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void ToggleTimeScale()
    {
        if (!isPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        isPause = !isPause;
    }
}

