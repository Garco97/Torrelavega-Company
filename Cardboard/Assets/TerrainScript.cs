using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
    private Rigidbody gameObjectsRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectsRigidBody = gameObject.AddComponent<Rigidbody>();
        gameObjectsRigidBody.mass = 1;
        gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.Discrete;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
