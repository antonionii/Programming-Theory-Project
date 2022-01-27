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

    [SerializeField] int power = 10;

    public float upForce = 80f;
    public float sideForce = .1f;

    private void Start()


    {
        Enemy = GameObject.Find("Enemy");
        hero = GameObject.Find("hero");

        enemyRb = GameObject.Find("Enemy").GetComponent<Rigidbody>();
        heroRb = GameObject.Find("hero").GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (heroRb != null)
        {




            Vector3 lookDirection2 = (heroRb.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection2 * speed);

            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }

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

