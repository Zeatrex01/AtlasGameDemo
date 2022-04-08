using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tuskodlari : MonoBehaviour
{
    public void nasıloynanırbutonu()
    {

        if (bilgipaneli != null)
        {
            bool acık = bilgipaneli.activeSelf;
            bilgipaneli.SetActive(!acık);
        }


    }
    public void oynabutonu()
    {
        SceneManager.LoadScene(1);
    }

    public void çıkbutonu()
    {
        Application.Quit();
    }

    public GameObject bilgipaneli;
    
}



