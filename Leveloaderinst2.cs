using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leveloaderinst2 : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;

    public int levelIndex;

    // Start is called before the first frame update
    void Start()
    {
        LoadNextlevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNextlevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

}
