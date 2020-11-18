﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderonTime : MonoBehaviour

{
    public Animator transition;

    public float Cinematic;

    public float transitionTime = 1f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
    
        yield return new WaitForSeconds(Cinematic);
        LoadNextlevel();
    }
    public void LoadNextlevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}