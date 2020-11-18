using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject pauseLoadAndSave;

    public GameObject[] PositionButton;

    public GameObject ButtonMenu; 

    public GameObject ShowEventMenu;

    public GameObject ShowEventLoadAndSave;

    private bool ActiveEvent = false;

    // Update is called once per frame
    void Update()
    {  

        if(Input.GetKeyDown(KeyCode.P))
        {
            
            if(GameIsPaused)
            {
                Resume();
                ActiveEvent = false;
            }
            else
            {
                Pause();
                ActiveEvent = true;

                if(ActiveEvent == true)
                {
                    ShowEventMenu.SetActive(true);
                    ShowEventLoadAndSave.SetActive(false);
                }

                if(ActiveEvent == false)
                {
                    ShowEventMenu.SetActive(false);
                }
            }
        }
    }

    public void SelectButton()
    {
        for(byte i = 0; i < 3; i--)
        {
            if(GameIsPaused == true)
            {
                int contador = 0; 
                if(Input.GetKeyDown(KeyCode.W))
                {
                    EventSystem.current.SetSelectedGameObject(PositionButton[0]);
                    contador++;
                }
                else if(Input.GetKeyDown(KeyCode.S))
                {
                    EventSystem.current.SetSelectedGameObject(PositionButton[1]);
                    
                    if(PositionButton[2] == null)
                    {
                        EventSystem.current.SetSelectedGameObject(PositionButton[0]);
                        contador--;
                    }
                    else
                    {
                        contador++;
                    }
                }
                else if(contador == 1)
                {
                    EventSystem.current.SetSelectedGameObject(PositionButton[2]);
                    if(PositionButton[2] == null)
                    {
                        EventSystem.current.SetSelectedGameObject(PositionButton[0]);
                        contador--;
                    }
                    else
                    {
                        contador++;
                    }
                }
                else if(contador == 2)
                {
                    EventSystem.current.SetSelectedGameObject(PositionButton[3]);
                }
                else
                {
                    EventSystem.current.SetSelectedGameObject(PositionButton[4]);
                }
                return;
            }
            
        }
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        pauseLoadAndSave.SetActive(false);

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseLoadAndSave.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void LoadAndSave()
    {   
        EventSystem.current.SetSelectedGameObject(pauseLoadAndSave);
        pauseMenuUI.SetActive(false);
        pauseLoadAndSave.SetActive(true);

        ShowEventMenu.SetActive(false);
        ShowEventLoadAndSave.SetActive(true);
    }

    public void LoadMenu()
    {
        EventSystem.current.SetSelectedGameObject(ButtonMenu);
        Time.timeScale = 1f;
        SceneManager.LoadScene("test scene");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Menu....");
        Application.Quit();
    }
}
