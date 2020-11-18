using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour {

    
    public Vector3 openPosition, closedPosition;

    
    public float animationTime;

    
    public bool isOpen = false, isLocked = false, opensUnlockableObject;

    
    public MovementType movementType;

    
    public string myMessage;

    
    public InteractiveObject myUnlockableObject;

    public InteractiveObject interactiveObject;

    public TextAnimator textAnimator;

    public enum MovementType { Slide, Rotate };
    public Hashtable iTweenArgs;
    public AudioSource aSource;

    void Start() {
        textAnimator = FindObjectOfType<TextAnimator>();
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);

        aSource = GetComponent<AudioSource>();
    }

    public void PerformAction() {
        if (!isLocked) {
            if (aSource) {
                aSource.Play();
            }

            if (Input.GetKeyDown(KeyCode.E)) {
                if (isOpen) {
                    iTweenArgs["position"] = closedPosition;
                    iTweenArgs["rotation"] = closedPosition;
                } else {
                    iTweenArgs["position"] = openPosition;
                    iTweenArgs["rotation"] = openPosition;
                }

                isOpen = !isOpen;
                ToggleMyUnlockableObject(isOpen);

                switch (movementType) {
                    case MovementType.Slide:
                        iTween.MoveTo(gameObject, iTweenArgs);
                        break;
                    case MovementType.Rotate:
                        iTween.RotateTo(gameObject, iTweenArgs);
                        break;
                }
            }
        } else {
            textAnimator.Show(myMessage);
        }
    }

    private void ToggleMyUnlockableObject(bool shouldLock) {
        if (myUnlockableObject) {
            myUnlockableObject.ToggleIsLocked(false);
            if (opensUnlockableObject) {
                myUnlockableObject.PerformAction();
                myUnlockableObject.ToggleIsLocked(true);
            } 
        }
    }

    public void ToggleIsLocked(bool newIsLocked) {
        isLocked = newIsLocked;
    }

    
    
}
