using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public GameObject bala;
    public GameObject pick;
    public int Bullets = 0;
    public HUDManager hudBullet;
    private float horizontalInput;
    private float verticalInput;
    private bool isRunning;
    public float speed = 2.0f;
    private float initialSpeed;

    private CharacterController controller;

    Animator animator;

    private int walkAnimID;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        initialSpeed = speed;
        AnimIDS();
        
    }

    void Update()
    {
        
        MyInput();
        Movement();

        if (pick == true && Input.GetKey(KeyCode.E))
        {
            PickBullets();
            Destroy(pick);
            Destroy(bala);
        }
    }

    void AnimIDS()
    {

            walkAnimID = Animator.StringToHash("walk");
        Debug.Log("funciono");
    }

    void MyInput()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isRunning = Input.GetKey("left shift");

    }

    void Movement()
    {


        if (isRunning)
        {
            speed = initialSpeed + 5.0f;
        }
        else
        {
            speed = initialSpeed;
        }
        if (horizontalInput != 0)
        {
            transform.Rotate(0, horizontalInput, 0);
            
        }
        if (verticalInput != 0)
        {
            animator.SetInteger("walk", 1);
            transform.Translate(0, 0, verticalInput * Time.deltaTime * speed);
            //Vector3 move = new Vector3(verticalInput, 0, 0);
            //controller.Move(move * Time.deltaTime);

        }
        else
        {
            animator.SetInteger("walk", 0);
        }

    }

    public void PickBullets()
    {
        Bullets += 5;
        hudBullet.AtualizacaoBullet(Bullets);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Amno")
        {
            pick.SetActive(true);
            Debug.Log("ta ino");
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        pick.SetActive(false);
    }
}
