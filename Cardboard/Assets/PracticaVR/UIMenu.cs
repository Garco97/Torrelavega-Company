using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour {
    public GameObject menu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void EsconderMenu()
    {
        menu.gameObject.SetActive(false);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
