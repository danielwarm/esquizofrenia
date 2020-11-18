using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changequality : MonoBehaviour
{
    public AudioSource audio;
    public Button button;
    public int quality;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        audio.Play();
        QualitySettings.SetQualityLevel(quality);

    }

}