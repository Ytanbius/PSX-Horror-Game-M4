using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private GameObject bala;
    public GameObject pick;
    public int Bullets = 0;
    public HUDManager hudBullet;

    private float horizontalInput;
    private float verticalInput;
    private bool isRunning;
    private bool movLock;

    public float speed = 2.0f;
    private float initialSpeed;

    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        initialSpeed = speed;
    }

    void Update()
    {
        MovLock();
        MyInput();
        Movement();
        PickBullets();
        
    }

    void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isRunning = Input.GetKey("left shift");
    }

    void Movement()
    {
        if (movLock == false)
        {
            if (isRunning)
            {
                speed = initialSpeed + 3.0f;
                animator.SetInteger("running", 1);
            }
            else
            {
                speed = initialSpeed;
                animator.SetInteger("running", 0);
            }
            if (horizontalInput != 0)
            {
                transform.Rotate(0, horizontalInput, 0);
            }
            if (verticalInput != 0)
            {
                transform.Translate(0, 0, verticalInput * Time.deltaTime * speed);
                animator.SetInteger("walk", 1);
            }
            else
            {
                animator.SetInteger("walk", 0);
            }
        }
    }

    public void PickBullets()
    {
        if (bala != null && pick == true && Input.GetKeyDown(KeyCode.E))
        {
            hudBullet.AtualizacaoBullet(Bullets += 5);
            Destroy(bala);
            pick.SetActive(false);
        }
    }

    void MovLock()
    {
        if (Input.GetKeyDown(KeyCode.P) && movLock == false)
        {
            movLock = true;
            animator.SetInteger("walk", 0);
            animator.SetInteger("running", 0);
        }
        else if (Input.GetKeyDown(KeyCode.P) && movLock == true)
        {
            movLock = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
         if (other.tag == "Amno")
        {
            bala = other.gameObject;
            pick.SetActive(true);
        }
       
        if (other.tag == "Casa")
        {
            pick.SetActive(true);
        }

        if(other.tag == "End")
        {
            pick.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Amno")
        {
            pick.SetActive(false);
            bala = null;
        }

        if (other.tag == "Casa")
        {
            pick.SetActive(false);
        }

        if (other.tag == "End")
        {
            pick.SetActive(false);
        }
    }
}
