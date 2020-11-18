using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class careventa : MonoBehaviour
{
    public AudioSource bb;
    public GameObject rea;
    public GameObject reb;
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        bb.Play();
        rea.SetActive(false);
        reb.SetActive(true);
        car.SetActive(false);

    }

    
        
}
