using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControls : MonoBehaviour
{
    public float speed = 300.0f;
    private Rigidbody enemyRb;
    private Rigidbody heroRb;
    GameObject Enemy;
    GameObject hero;


    private void Start()


    {

    }

    private void Update()
    {


    }






    void OnTriggerEnter(Collider other)
    {
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal

        if (other.gameObject != GameObject.Find("Plane"))
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }


}

