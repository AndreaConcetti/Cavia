using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivazioneConPlayer2 : MonoBehaviour
{
    private PallaRotolanteScript PRS;
    public GameObject palla;
    private Rigidbody2D RD;
    // Start is called before the first frame update
    void Start()
    {
        PRS = palla.GetComponent<PallaRotolanteScript>();
        RD = palla.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PRS.speed = 7.5f;
            RD.gravityScale = 1;
        }

    }
}
