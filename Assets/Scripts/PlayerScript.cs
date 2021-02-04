using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




    public class PlayerScript : MonoBehaviour
    {
        public GameObject evviva;
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
        public SpriteRenderer SR;
        public Sprite attacco;
        public Sprite difesa;
        public Sprite bianco;
        public Sprite biancoRossi;
        public int contamorte;
        private int randomNumber;
        private Platformer2DUserControl PC2;
        private int randomNumber2;
        private int randomNumber3;
        private int randomNumber4;
        private int randomNumber5;
        private int randomNumber6;
        public GameObject annebbiata;
        public GameObject negativo;
        public GameObject effetto;
        public GameObject resetgod;
       

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
            PC2 = player.GetComponent<Platformer2DUserControl>();
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
            contamorte = 0;
        }

        // Update is called once per frame
        void Update()
    {
        if(contamorte == 10)
        {
            evviva.SetActive(true);
        }
        if (Death == true)
        {
           
            {
                transform.position = spawnPoint;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                contamorte = contamorte + 1;
                Death = false;
                Buffs();
                Debuffs();
            }
        }
        if (randomNumber == 1)
         {
            PC2.enabled = false;
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
        }
        else if (randomNumber != 1)
         {
            PC2.enabled = true;
            
        }
         if(randomNumber3 == 1)
        {
            annebbiata.SetActive(true);
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
        }
        else if(randomNumber3 != 1)
        {
            annebbiata.SetActive(false);
            

        }
        if (randomNumber4 == 1)
        {
            PC2.enabled = false;
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
        }
        else if (randomNumber4 != 1)
        {
            PC2.enabled = true;
            
        }
        if (randomNumber6 == 1)
        {
            PC2.enabled = false;
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
        }
        else if (randomNumber6 != 1)
        {
            PC2.enabled = true;
            
        }

    }
        void FixedUpdate()
        {
        
        
        if (randomNumber2 == 1)
        {
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
            PC.m_Rigidbody2D.AddForce(new Vector2(0f, 20f));
        }
        if (randomNumber5 == 1)
        {
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
            PC.m_Rigidbody2D.AddForce(new Vector2(0f, 20f));
        }
       
        if (randomNumber6 == 1)
        {
            effetto.SetActive(true);
            StartCoroutine(DisattivaEffetto());
            PC.m_Rigidbody2D.AddForce(new Vector2(0f, 20f));
        }
        

    }
        void Buffs()
        {
            if (playerDeath1 == true)
            {
                PC.m_JumpForce = 700;
                if(playerDeath8 == true)
                {
                PC.m_JumpForce = 700000;
                }
            
            }
            if (playerDeath2 == true)
            {
                RD.gravityScale = 1.5f;
            }
            if (playerDeath3 == true)
            {
                SR.sprite = attacco;
            }
            if (playerDeath4 == true)
            {
                SR.sprite = difesa;
            }
            if (playerDeath5 == true)
            {
            
            }
            if (playerDeath6 == true)
            {
               
            }
            if (playerDeath7 == true)
            {
                PC.m_MaxSpeed = 15;
            }
            if (playerDeath8 == true)
            {
                RD.mass = 1000;
                PC.m_JumpForce = 500000;
                if(playerDeath1 == true)
                {
                PC.m_JumpForce = 700000;
                }
             
            }
            if (playerDeath9 == true)
            {
                
            }
            if (playerDeath10 == true)
            {
            
            }

        }
        void Debuffs()
        {
          if (contamorte == 1)
          {
            SR.sprite = bianco;
          }

          if (contamorte == 2)
          {
            StartCoroutine(DisattivaAvatar());           
          }
          if (contamorte == 3)
          {
            SR.sprite = biancoRossi;
          }
          if (contamorte == 4)
          {
            StartCoroutine(DisattivaAvatar2());
          }
          if (contamorte == 5)
          {
            StartCoroutine(AnnebbiaVisuale());
          }
          if (contamorte == 6)
          {
            StartCoroutine(DisattivaAvatar3());
          }
          if (contamorte == 7)
          {
            StartCoroutine(DisattivaAvatar4());
          }
          if (contamorte == 8)
          {
            negativo.SetActive(true);
          }
          if (contamorte == 9)
          {
            StartCoroutine(DisattivaAvatar5());
          }
          
          
        }
    IEnumerator DisattivaAvatar()
    {
        yield return new WaitForSeconds(1);
        randomNumber = (int)Random.RandomRange(1, 100.9999f);        
        StartCoroutine(DisattivaAvatar());
        
    }
    IEnumerator DisattivaAvatar2()
    {
        yield return new WaitForSeconds(1);
        randomNumber2 = (int)Random.RandomRange(1, 100.9999f);
        StartCoroutine(DisattivaAvatar2());
    }
    IEnumerator AnnebbiaVisuale()
    {
        yield return new WaitForSeconds(1);
        randomNumber3 = (int)Random.RandomRange(1, 10.9999f);
        StartCoroutine(AnnebbiaVisuale());
    }
    IEnumerator DisattivaAvatar3()
    {
        yield return new WaitForSeconds(1);
        randomNumber4 = (int)Random.RandomRange(1, 50.9999f);
        StartCoroutine(DisattivaAvatar3());

    }
    IEnumerator DisattivaAvatar4()
    {
        yield return new WaitForSeconds(1);
        randomNumber5 = (int)Random.RandomRange(1, 50.9999f);
        StartCoroutine(DisattivaAvatar4());

    }
    IEnumerator DisattivaAvatar5()
    {
        yield return new WaitForSeconds(1);
        randomNumber6 = (int)Random.RandomRange(1, 25.9999f);
        StartCoroutine(DisattivaAvatar5());

    }
    IEnumerator DisattivaEffetto()
    {
        yield return new WaitForSeconds(1);
        effetto.SetActive(false);
        

    }
}
