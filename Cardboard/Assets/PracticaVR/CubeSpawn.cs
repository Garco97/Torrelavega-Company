using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public Cube cube = new Cube();
    private float timer = 0;
    private float spawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            timer = 0;
            Spawn();
        }
    }

    public void Spawn()
    {


        Vector3 spawnPointIndex = new Vector3(10, 20, 10);

        Instantiate<Cube>(cube, spawnPointIndex, Quaternion.identity);
    }
}
