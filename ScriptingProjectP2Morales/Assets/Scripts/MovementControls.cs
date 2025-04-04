using System.Collections;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float forwardMovment = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
