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
        //offset = transform.position - player.transform.position;
        offset = transform.position;
    }

    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
        offset = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, player.transform.position.y + 1, transform.position.z), Time.deltaTime * speed);
        transform.position = offset;
    }
}
