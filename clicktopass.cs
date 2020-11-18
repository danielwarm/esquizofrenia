using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class clicktopass : MonoBehaviour
{
    public GameObject texto;
    public GameObject textob;
    public AudioSource siui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            siui.Play();
            textob.SetActive(true);
            texto.SetActive(false);
        }
    }
}
