using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravityModifier;
    public float jumpforce = 10f;
    private Rigidbody PlayerRB;
    public bool isOnGround = true;
    public bool gameoverT = false;
    private Animator playerAni;
    public ParticleSystem explosionpartical;
    public ParticleSystem dirtRuning;
    public AudioClip jumpSound;
    public AudioClip hitSound;
    public AudioSource playerAudio;


    void Start()
    {
        playerAni = GetComponent<Animator>();
        PlayerRB = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameoverT)
        {
            PlayerRB.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
            playerAni.SetTrigger("Jump_trig");
            dirtRuning.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtRuning.Play();
        }
        else if (collision.gameObject.CompareTag("obstcale"))
        {
            Debug.Log("GameOver");
            gameoverT = true;
            playerAni.SetBool("Death_b", true);
            playerAni.SetInteger("DeathType_int",1);
            explosionpartical.Play();
            dirtRuning.Stop();
            playerAudio.PlayOneShot(hitSound, 1.0f);
        }

    }
}
