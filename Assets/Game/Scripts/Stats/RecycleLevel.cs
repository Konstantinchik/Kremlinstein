using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecycleLevel : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    private void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level001");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
