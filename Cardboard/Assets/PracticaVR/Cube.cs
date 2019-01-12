using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform[] spawnPoints;
    private  bool first = false;
    private static int vidas = 3;
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

        gameObject.transform.parent = null;
            if (!collision.gameObject.name.Equals("Terrain"))
            {
            transform.SetParent(GameObject.Find("Base").transform);
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ |
                 RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                 RigidbodyConstraints.FreezePositionY;

            }
            else
            {
            print("algo");
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ |
                 RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                 RigidbodyConstraints.FreezePositionY;
            switch (vidas)
                {
                    case 3:
                        vidas = 2;
                        GameObject.Find("life3").GetComponent<Canvas>().enabled = false;
                        break;
                    case 2:
                        vidas = 1;
                        GameObject.Find("life2").GetComponent<Canvas>().enabled = false;
                        break;
                    case 1:
                        vidas = 0;
                        GameObject.Find("life1").GetComponent<Canvas>().enabled = false;
                        break;
                    case 0:
                        break;
                }
        }
    }


}
