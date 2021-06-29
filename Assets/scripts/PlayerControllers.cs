using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed, runSpeed;
    public float mouseSpeedX, mouseSpeedY;
    public float jumpSpeed;
    public float minAngleY, maxAngleY;
    public Transform CamTransform;
    private Rigidbody rb;
    public bool FootCollision;
    bool IsJumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    float angle = 0;
    // Update is called once per frame
    void Update()
    {
        Vector2 MouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        transform.rotation *= Quaternion.Euler(0, MouseInput.x * mouseSpeedX * Time.deltaTime, 0);
        angle = Mathf.Clamp(angle - MouseInput.y * mouseSpeedY * Time.deltaTime, -minAngleY, maxAngleY);
        CamTransform.localRotation = Quaternion.Euler(angle, 0, 0);
        if (FootCollision)
        {
            IsJumping |= Input.GetButtonDown("Jump");
        }
    }
    Vector3 MotionInput;
    float speed;
    private void FixedUpdate()
    {
        float maxSpeed = 1;
        MotionInput = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        speed = Input.GetButton("Fire3") ? runSpeed : moveSpeed;
        if (rb.velocity.magnitude > speed)
            MotionInput*=0; 
        if (IsJumping)
        {
            MotionInput.y = jumpSpeed;
            IsJumping = false;
        }
        if(FootCollision)
            rb.velocity += MotionInput * moveSpeed * maxSpeed;
    }
}
