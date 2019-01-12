using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject cube;
    private GameObject tmp;
    private float timer = 0;
    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3f, 2f);
        InvokeRepeating("Avanza", 3f, 2f);
    }

    public void Update()
    {

    }

    public void Spawn()
    {
        contador++;
       tmp = Instantiate(cube, gameObject.transform.position, Quaternion.identity);
        tmp.gameObject.name="cubo" + contador;
    }
    public void Avanza()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }
}
