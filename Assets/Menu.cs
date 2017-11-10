using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour {

    public void BotonStart ()
    {
        SceneManager.LoadScene("ThirdFloor_Cautivo");
    }
	
    public void BotonExit()
    {
        Application.Quit();
    }
}
