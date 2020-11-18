using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;


public class DAMAGE : MonoBehaviour {

    float time = 0f;

    public Image overlayImage;

    private float r;
    private float g;
    private float b;
    private float a;

    private void Start()
    {
        r = overlayImage.color.r;
        g = overlayImage.color.g;
        b = overlayImage.color.b;
        a = overlayImage.color.a;
    }

    private void OnTriggerEnter(Collider other)
    {
        time = 5f;
    }

    private void Update()
    {
        if(time == 5f)
        {
            if(Input.GetKey(KeyCode.W))
            {
                a += 0.09f;
            }
        }


        a -= 0.01f;

        a = Mathf.Clamp(a, 0, 1f);
        AdjustColor();
        
    }


    private void AdjustColor()
    {
        Color C = new Color(r, g, b, a);
        overlayImage.color = C; 
    }
}
