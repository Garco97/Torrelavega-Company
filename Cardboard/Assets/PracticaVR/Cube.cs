using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform[] spawnPoints;
    private  bool first = false;
    public Cube()
    {
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

            this.transform.parent = null;
            if (!collision.gameObject.name.Equals("Terrain"))
            {
                Vector3 aux2 = gameObject.transform.position;
                gameObject.transform.position = collision.gameObject.transform.position;
                collision.gameObject.transform.position = aux2;
                transform.SetParent(Camera.main.transform);
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ |
                 RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                 RigidbodyConstraints.FreezePositionY;

            }
            else
            {
                Destroy(this);
            }
        }


}
