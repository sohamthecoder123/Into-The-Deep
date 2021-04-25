using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{

    void Start ()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
