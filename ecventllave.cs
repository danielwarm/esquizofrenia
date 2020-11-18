using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ecventllave : MonoBehaviour
{

    public GameObject cubo;
    public GameObject llave;
    public AudioSource tin;

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
        tin.Play();
        cubo.SetActive(true);
        llave.SetActive(false);
    }

}
