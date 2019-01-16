using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject cubeSpawn;
    public void Start()
    {
        cubeSpawn.transform.position = new Vector3(Camera.main.transform.position.x, 43.11f, Camera.main.transform.position.z);


    }

}
