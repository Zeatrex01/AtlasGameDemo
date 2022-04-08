using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nasiloynanir : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bilgipaneli;
    public void nasıloynanırbutonu()
    {

      if(bilgipaneli !=null)
        {
            bool acık = bilgipaneli.activeSelf;
            bilgipaneli.SetActive(!acık);
        }
        
        
    }
}
