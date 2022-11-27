using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //Screen object variables
    public GameObject startUI;
    public GameObject loginUI;
    public GameObject registerUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            UnityEngine.Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //Functions to change the login screen UI

    public void StartScreen() //Back button, switch to start screen
    {
        startUI.SetActive(true);
        loginUI.SetActive(false);
        registerUI.SetActive(false);
    }

    public void LoginScreen() //Back button, switch to login screen
    {
        startUI.SetActive(false);
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }
    public void RegisterScreen() // Regester button, swich to register screen
    {
        startUI.SetActive(false);
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }
}
