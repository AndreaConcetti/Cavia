using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyScript : MonoBehaviour
{
    private int contamorte;
    // Start is called before the first frame update
    void Awake()
    {
        contamorte = GameObject.Find("Avatar").GetComponent<PlayerScript>().contamorte;
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Reset");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
