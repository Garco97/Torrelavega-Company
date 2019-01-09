using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionConBoton : MonoBehaviour {

    public Material materialActivo, materialInactivo;
    public float recogidaTiempo = 1f;
    public int caidaTiempo = 500;
    private Rigidbody gameObjectsRigidBody;

    private float tiempo;
    private bool sujeto = false;

    // Use this for initialization
    void Start()
    {
        gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
        gameObjectsRigidBody.mass = 1;

        tiempo = Mathf.Infinity;
        GetComponent<Renderer>().material = materialInactivo;
    }


    // Update is called once per frame
    void Update()
    {

        if (Time.time - tiempo > recogidaTiempo)
        {
            sujeto = true;
            interaccion();

        }
        if (sujeto == true)
        {
            caidaTiempo--;
            if (caidaTiempo == 0) { 
                sujeto = false;
                this.dejarCaer();
                caidaTiempo = 500;
            }
        }
    }

    private void dejarCaer()
    {
        this.transform.parent = null;
        gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
        gameObjectsRigidBody.mass = 1;

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
        Destroy(gameObjectsRigidBody);

        this.transform.SetParent(Camera.main.transform);
        this.transform.localPosition = gameObject.transform.position;
        this.transform.localRotation = Quaternion.identity ;
        Debug.Log("Interaccion");
    }

}
