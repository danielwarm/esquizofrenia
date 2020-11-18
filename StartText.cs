using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartText : MonoBehaviour
{
    public string myMessage;

    public TextAnimator textAnimator;

    public AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
        textAnimator = FindObjectOfType<TextAnimator>();
        aSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        aSource.Play();
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        textAnimator.Show(myMessage);
    }
}
