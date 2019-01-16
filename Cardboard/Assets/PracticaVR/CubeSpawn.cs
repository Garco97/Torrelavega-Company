using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject cube;
    private GameObject tmp;
    private int contador = 0;
    private Vector3 _center;

    void Start()
    {
        _center = transform.position;
        InvokeRepeating("Spawn", 3f, 4f);
    }


    public void Spawn()
    {
        Vector3 pos = RandomCircle(_center, 10.0f);
        Quaternion rot = Quaternion.FromToRotation(Vector3.forward, _center - pos);
        contador++;
        tmp = Instantiate(cube, pos, rot);
        tmp.gameObject.name = "cubo" + contador;
    }




    private Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y;
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }
}
