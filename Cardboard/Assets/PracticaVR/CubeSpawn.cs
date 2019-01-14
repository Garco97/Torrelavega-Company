using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject cube;
    private GameObject tmp;
    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 10f, 4f);
    }

    public void Update()
    {

    }

    public void Spawn()
    {
        contador++;
        tmp = Instantiate(cube, gameObject.transform.position, Quaternion.identity);
        tmp.gameObject.name = "cubo" + contador;
    }
}
