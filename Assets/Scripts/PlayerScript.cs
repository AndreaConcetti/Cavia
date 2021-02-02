using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject player;
    public bool Death;
    public bool playerDeath1;
    public bool playerDeath2;
    public bool playerDeath3;
    public bool playerDeath4;
    public bool playerDeath5;
    public bool playerDeath6;
    public bool playerDeath7;
    public bool playerDeath8;
    public bool playerDeath9;
    public bool playerDeath10;
    public Vector3 spawnPoint;
    // Start is called before the first frame update


    void Awake()
    {
        
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }


    void Start()
    {
        Death = false;
        playerDeath1 = false;
        playerDeath2 = false;
        playerDeath3 = false;
        playerDeath4 = false;
        playerDeath5 = false;
        playerDeath6 = false;
        playerDeath7 = false;
        playerDeath8 = false;
        playerDeath9 = false;
        playerDeath10 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Death == true)
        {
            transform.position = spawnPoint;
            SceneManager.LoadScene(0);

        }
    }

}