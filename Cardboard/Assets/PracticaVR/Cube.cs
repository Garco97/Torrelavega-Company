using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform[] spawnPoints;
    private  bool first = false;
    private static int vidas = 3;
    public Material material;
    public Material material2;
    public Material material3;


    public Cube()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        float color = Random.Range(0, 1000);
        if (color % 3 == 0)
        { 
        GetComponent<Renderer>().material = material;
        }else if(color % 3 == 1)
        {
            GetComponent<Renderer>().material = material2;

        }
        else if(color % 3 == 2)
        {
            GetComponent<Renderer>().material = material3;

        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        gameObject.GetComponent<AudioSource>().enabled = false;
        if (!first)
        {
            first = true;
            gameObject.transform.parent = null;
            if (!collision.gameObject.name.Equals("Terrain"))
            {
                transform.SetParent(GameObject.Find("torre").transform);
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ |
                 RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                 RigidbodyConstraints.FreezePositionY;
                GameObject.Find("torre").transform.position = new Vector3(GameObject.Find("torre").transform.position.x,
                                               GameObject.Find("torre").transform.position.y - 0.9f, GameObject.Find("torre").transform.position.z);

            }
            else
            {
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
                        GameObject.Find("youdieCanvas").GetComponent<Canvas>().enabled = true;
                        break;
                }
                Destroy(gameObject);
            }
        }
    }


}
