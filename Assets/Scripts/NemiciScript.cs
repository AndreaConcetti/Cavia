using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemiciScript : MonoBehaviour
{
    public GameObject player;
    private PlayerScript PS;
    private NemiciScriptPadre NSP;
    public GameObject nemico1;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        PS = player.GetComponent<PlayerScript>();
        NSP = nemico1.GetComponent<NemiciScriptPadre>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (PS.playerDeath4 != true)
        {
            if (other.tag == "Player")
            {
                PS.Death = true;
                NSP.speed = 0;
                PS.playerDeath3 = true;
                counter = counter + 1;
                if (counter == 2)
                {
                    PS.playerDeath4 = true;
                }
            }

        }
    }
}
