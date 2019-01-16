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
    private static int score = 0;
    public GameObject particlesAll;
    


    public Cube()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        int color = Random.Range(0, 1000);
        switch (color % 3)
        {
            case 0:
                GetComponent<Renderer>().material = material;
                break;
            case 1:
                GetComponent<Renderer>().material = material2;
                break;
            case 2:
                GetComponent<Renderer>().material = material3;
                break;
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
                Explode(collision.gameObject.transform.position);
                transform.SetParent(GameObject.Find("torre").transform);
                gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ |
                 RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ |
                 RigidbodyConstraints.FreezePositionY;
                GameObject.Find("torre").transform.position = new Vector3(GameObject.Find("torre").transform.position.x,
                                         GameObject.Find("torre").transform.position.y - 0.9f, GameObject.Find("torre").transform.position.z);

                score = score + 1;
                print(Camera.main.transform.GetChild(1).GetChild(3).GetChild(0).name);
                Camera.main.transform.GetChild(1).GetChild(3).GetChild(0).gameObject.GetComponent<TextMesh>().text = score.ToString();
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

                        var Cubo = GameObject.FindGameObjectsWithTag("Cubo");
                        foreach( GameObject item  in Cubo){
                            Destroy(item);
                        }
                        Camera.main.transform.GetChild(3).gameObject.SetActive(true);


                        Destroy(GameObject.Find("CubeSpawn"));
                        Application.Quit();

                        break;
                }
                Destroy(gameObject);
            }
        }
    }


    private void Explode(Vector3 position)
    {
        GameObject particles = Instantiate(particlesAll, position, Quaternion.identity);
        particles.GetComponent<ParticleSystem>().Play();
    }

     void OnDestroy()
    {
        Explode(gameObject.transform.position);
       
    }

}
