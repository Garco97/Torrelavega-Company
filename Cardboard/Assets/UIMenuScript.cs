using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuScript : MonoBehaviour
{

    public GameObject torre;
    public GameObject vidas;
    public GameObject cubeSpawn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void EsconderMenu()
    {
        gameObject.SetActive(false);
        torre.SetActive(true);
        vidas.SetActive(true);
        cubeSpawn.SetActive(true);
    }
    public void Salir()
    {
        Application.Quit();
    }
}