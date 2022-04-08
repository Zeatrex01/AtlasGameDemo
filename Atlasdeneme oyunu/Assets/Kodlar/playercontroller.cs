using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playercontroller : MonoBehaviour
{
    //private float zamanlayıcı = 3f;
    public float karakterhızı = 3;
    private float turbo = 5;
    private float yavaşla = -2;
    public float sağvesolhızı = 3;
    public GameObject oyuncuu;
    public GameObject kazandınpaneli;

    private void Start()
    {
        oyuncuu.GetComponent<Animator>().Play("idle");
        karakterhızı = 0;
        StartCoroutine(zamanlayıcı());
    }
    IEnumerator zamanlayıcı()
    {
        yield return new WaitForSeconds(3.0f);
        oyuncuu.GetComponent<Animator>().Play("run");
        karakterhızı = 3;
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector3.forward * Time.deltaTime * karakterhızı,Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * sağvesolhızı);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * sağvesolhızı * -1);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * turbo,Space.World );
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * yavaşla, Space.World);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag== "dikenli engel")
        {
            SceneManager.LoadScene("Atlas adventure", LoadSceneMode.Single);
            Debug.Log("Çarptın!");
        }
        if (collision.gameObject.tag == "Boşluk")
        {
            SceneManager.LoadScene("Atlas adventure", LoadSceneMode.Single);
           // Debug.Log("öldün");
        }
        if (collision.gameObject.tag == "bitiş")
        {
            oyuncuu.GetComponent<Animator>().Play("victory");
            karakterhızı = 0;
            kazandınpaneli.SetActive(true);
            oyuncuu.transform.Rotate(0, 180, 0);
        }
       
    }
    public void anamenü()
    {
        SceneManager.LoadScene(0);
    }
}
