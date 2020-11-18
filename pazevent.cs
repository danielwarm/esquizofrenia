using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pazevent : MonoBehaviour
{

    public GameObject triangle;
    public GameObject texto;
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(espera());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator espera()
    {
        yield return new WaitForSeconds(tiempo);
        triangle.SetActive(true);
        texto.SetActive(true);
        
    }
}
