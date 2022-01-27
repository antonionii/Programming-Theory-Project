using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject hero;

    [SerializeField] GameObject enemy;
    ObjectPooler objectPooler;

    [SerializeField] float spawnRate;


    // Start is called before the first frame update
    void Start()

    {
        objectPooler = ObjectPooler.Instance;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
