using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{

    public Material materialActivo, materialInactivo;
    public float recogidaTiempo = 1f;
    public int caidaTiempo = 500;
    public Rigidbody gameObjectsRigidBody;

    private float tiempo;
    private bool sujeto = false;

    // Use this for initialization
    void Start()
    {

        transform.SetParent(Camera.main.transform);
        transform.localPosition = new Vector3(gameObject.transform.position.x, -1, gameObject.transform.position.z);
        transform.localRotation = Quaternion.identity;
        tiempo = Mathf.Infinity;
        GetComponent<Renderer>().material = materialInactivo;
    }


    // Update is called once per frame
    void Update()
    {

        if (Time.time - tiempo > recogidaTiempo)
        {
            //sujeto = true;
            //interaccion();

        }
        if (sujeto == true)
        {
            caidaTiempo--;
            if (caidaTiempo == 0)
            {
                sujeto = false;

                caidaTiempo = 500;
            }
        }
    }






    public void activa(bool activado)
    {

        if (activado)
        {

            GetComponent<Renderer>().material = materialActivo;
            Debug.Log("Activado");

            tiempo = Time.time;

        }

        else
        {
            GetComponent<Renderer>().material = materialInactivo;
            Debug.Log("Desactivado");

            tiempo = Mathf.Infinity;

        }

    }


    public void interaccion()
    {




        Debug.Log("Interaccion");
    }

}
