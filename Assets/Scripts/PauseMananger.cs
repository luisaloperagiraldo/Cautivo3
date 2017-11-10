using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PauseMananger : MonoBehaviour {

    Canvas canvas;

	// Use this for initialization
	void Start () {

        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();

        }
            
	}

    public void Pause()
    {
        canvas.enabled = !canvas.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

    public void Returnmainmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");

    }
}
