using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    

    public Player_control controls;
    public Rigidbody2D playerRB;
    public Animator animator;
    public Transform cek_dasar;
    public LayerMask layer_dasar;
    public float panjang_raycast;
    [Space]
    float direction = 0;
    public float speed;
    public float tinggi_lompat;
    bool hadapkanan=true;
    bool sentuh_dasar;
    [SerializeField] int banyak_lompat = 0;
    //[SerializeField]bool jump2;
    [Space]
    public ParticleSystem dust;
    [Space]
    public Player_manager player_manager;
    
    private void Awake()
    {

        controls = new Player_control();
        controls.Enable();

        controls.Move.Move.performed += context =>
        {
            direction = context.ReadValue<float>();

            if (direction == 1)
            {
                Audio_manager.Instance.Play_Step("jalan");
            }
            else if (direction == -1)
            {
                Audio_manager.Instance.Play_Step("jalan");
            }
            else
            {
                Audio_manager.Instance.Step_source.Stop();
            }

        };

        controls.Move.Jump.performed += context =>
        {
            jump();
        };

        controls.Move.Pause.performed += context =>
        {
            player_manager.game_pause();
        };

    }

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (sentuh_dasar == false)
        {
            Audio_manager.Instance.Step_source.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            banyak_lompat = 0;
        }
    }

    void FixedUpdate()
    {
        RaycastHit2D hit_dasar = Physics2D.Raycast(cek_dasar.position, Vector2.down, panjang_raycast, layer_dasar);
        //sentuh_dasar = Physics2D.OverlapCircle(cek_dasar.position, 0.1f, layer_dasar);
        sentuh_dasar=hit_dasar;
        animator.SetBool("Sentuh_dasar", hit_dasar);

        

        jalan();
        dust_on_off();

        if (hadapkanan && direction < 0 || !hadapkanan && direction > 0)
            flip();
    }

    void jalan()
    {
        playerRB.velocity = new Vector2(direction * speed * Time.deltaTime, playerRB.velocity.y);
        animator.SetFloat("Jalan", Mathf.Abs(direction));

    }
    void flip()
    {
        hadapkanan = !hadapkanan;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        mumcul_dust();
        
    }
    void jump()
    {
        //playerRB.velocity = new Vector2(playerRB.velocity.x, tinggi_lompat);
        //mumcul_dust();

        if (banyak_lompat <= 1)
        {
            banyak_lompat++;
            playerRB.velocity = new Vector2(playerRB.velocity.x, tinggi_lompat);
            mumcul_dust();
            Audio_manager.Instance.Play_SFX("jump");
        }
    }

    void mumcul_dust()
    {
        dust.Play();
    }

    void dust_on_off()
    {
        if (direction < 0)
        {
            mumcul_dust();
        }
        if (direction > 0)
        {
            mumcul_dust();
        }
    }
}
