using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb = null;

    [SerializeField] private float moveSpeed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movePlayer();
        rotatePlayer();
    }

    private void movePlayer()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 moveForward = transform.forward * verticalMove;
        Vector3 moveLeftRight = transform.right * horizontalMove;

        rb.transform.position += moveForward;
        rb.transform.position += moveLeftRight;
    }

    private void rotatePlayer()
    {
        float mouseXRotation = Input.GetAxis("Mouse X") * 50f * Time.deltaTime;

        Vector3 playerRotation = new Vector3(0f, mouseXRotation, 0f);

        transform.Rotate(playerRotation);
    }
}
