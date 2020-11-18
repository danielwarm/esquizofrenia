using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carevent : MonoBehaviour
{

    public AudioSource bb;
    public GameObject cama;
    public GameObject camb;
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
        camb.SetActive(true);
        cama.SetActive(false);
        StartCoroutine(espera());

    }

    IEnumerator espera()
    {
        yield return new WaitForSeconds(4);
        cama.SetActive(true);
        camb.SetActive(false);
        car.SetActive(false);
    }
}
