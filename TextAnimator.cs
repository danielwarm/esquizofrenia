using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimator : MonoBehaviour {

    private Text notificationText;

    [SerializeField]
    private float visibilityTime = 2f, timeElapsed = 0;

    private bool visibilityToggled = false;
	
	void Start () {
        notificationText = GetComponent<Text>();
	}
	
	void Update () {
		if(timeElapsed >= visibilityTime) {
            ToggleVisibility(false);
            visibilityToggled = false;
        } else if(visibilityToggled){
            timeElapsed += Time.deltaTime;
        }
	}

    public void Show(string message) {
        ToggleVisibility(true);
        notificationText.text = message;
        timeElapsed = 0;
        visibilityToggled = true;
    }

    private void ToggleVisibility(bool show) {
        Color color = notificationText.color;
        color.a = show ? 1 : 0;
        notificationText.color = color;
    }
}
