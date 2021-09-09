using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSoundController : MonoBehaviour
{
    public static MenuSoundController Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name != "Menu" && SceneManager.GetActiveScene().name != "Credits")
        {
            Destroy(gameObject);
        }
    }
}
