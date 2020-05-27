using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ConfigureVehicle : MonoBehaviour
{
    private Rigidbody rb;

    private float force = 80f;

    [SerializeField] private Vector3 accellerateSpeed = new Vector3(0f, 0f, 10f);
    [SerializeField] private Vector3 rotateSpeed = new Vector3(0f, 0f, 0f);

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // We set the center of mass low, to make sure that we usually "land on our feet" when doing stunts:
        rb.centerOfMass = new Vector3(0, -0.5f, 0);
    }

    private void Update()
    {
        AccelleratePlayer();
        RotatePlayer();
    }

    private void AccelleratePlayer()
    {
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                accellerateSpeed = new Vector3(0f, 0f, 30f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                accellerateSpeed = new Vector3(0f, 0f, -30f);
            }
        }
        else
        {
            accellerateSpeed = new Vector3(0f, 0f, 0f);
        }

        rb.AddRelativeForce(accellerateSpeed);
    }

    private void RotatePlayer()
    {
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rotateSpeed = new Vector3(0f, -20f, 0f);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rotateSpeed = new Vector3(0f, 20f, 0f);
            }
        }
        else
        {
            rotateSpeed = new Vector3(0f, 0f, 0f);
        }

        rb.AddTorque(rotateSpeed);
    }

    private void OnCollisionStay(Collision collision)
    {
        if ((collision.gameObject.layer == 8) && (!isGrounded))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
