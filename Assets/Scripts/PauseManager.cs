using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuiManager : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
            PauseMenu.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;

        }

    }

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
