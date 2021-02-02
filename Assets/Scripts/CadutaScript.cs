using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadutaScript : MonoBehaviour
{
    private PlayerScript PS;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        PS = player.GetComponent<PlayerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PS.Death = true;
            PS.playerDeath1 = true;
        }
    }
}
