using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliderenter : MonoBehaviour
{
    public GameObject texto;
    
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
            Debug.Log("sapo ps mijo");
            texto.SetActive(true);
       
        


    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("sapo ps mijo");
        texto.SetActive(false);
        

    }
}
