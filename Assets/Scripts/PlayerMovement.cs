using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private bool isRunning;
    public float speed = 2.0f;
    private float initialSpeed;

    void Start()
    {
        
        initialSpeed = speed;

    }

    void Update()
    {

        MyInput();
        Movement();

    }

    void MyInput()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        isRunning = Input.GetKey(KeyCode.LeftShift);

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
            transform.Rotate(0, horizontalInput, 0);
        if (verticalInput != 0)
            transform.Translate(0, 0, verticalInput * Time.deltaTime * speed);

    }
}
