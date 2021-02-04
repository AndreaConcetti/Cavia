using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivazioneConPlayerScript : MonoBehaviour
{
    private NemiciScriptPadre NSP;
    public GameObject nemico;

    // Start is called before the first frame update
    void Start()
    {
        NSP = nemico.GetComponent<NemiciScriptPadre>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            NSP.speed = 2;
        }
        
    }
}
