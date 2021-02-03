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
        private PlatformerCharacter2D PC;
        public Rigidbody2D RD;

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
            PC = player.GetComponent<PlatformerCharacter2D>();
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

        }
        void FixedUpdate()
        {
            if (Death == true)
            {
                transform.position = spawnPoint;
                SceneManager.LoadScene(0);
                Death = false;
                Buffs();

            }

        }
        void Buffs()
        {
            if (playerDeath1 == true)
            {
                PC.m_JumpForce = 700;
            }
            if (playerDeath2 == true)
            {
            RD.gravityScale = 1.5f;
            }
            if (playerDeath3 == true)
            {

            }
            if (playerDeath4 == true)
            {

            }
            if (playerDeath5 == true)
            {

            }
            if (playerDeath6 == true)
            {

            }
            if (playerDeath7 == true)
            {

            }
            if (playerDeath8 == true)
            {

            }
            if (playerDeath9 == true)
            {

            }
            if (playerDeath10 == true)
            {

            }

        }
    }
