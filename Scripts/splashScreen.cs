using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashScreen : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject mainMenu;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            startScreen.gameObject.SetActive(false);
            mainMenu.gameObject.SetActive(true);
        }

    }
}
