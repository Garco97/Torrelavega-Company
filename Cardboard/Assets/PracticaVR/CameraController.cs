using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    public float speed = 1f;

    void Start()
    {
        offset = transform.position;
    }

    void LateUpdate()
    {
        //offset = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, player.transform.position.y + 0.1f, transform.position.z), Time.deltaTime * speed);
        transform.position = offset;
    }
}
