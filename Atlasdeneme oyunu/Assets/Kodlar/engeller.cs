using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class engeller : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "dikenli engel")
        {
            SceneManager.LoadScene("Atlas adventure", LoadSceneMode.Single);
            //Debug.Log("yüklendi");
        }
       
    }
}
    

