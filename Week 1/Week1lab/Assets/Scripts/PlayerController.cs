using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables

    [Range(40f, 200f)][SerializeField] private float rotateSpeed = 50f;

    [SerializeField] public float moveSpeed = 10f;

    [SerializeField] private float minX = -8f, maxX = 8f;
    [SerializeField] private float minZ = -8f, maxZ = 8f;

    private int scoreCount = 0;
    public int currentScore()
    {
        return scoreCount;
    }

    #endregion

    void Update()
    {
        MovePlayer();
        RotatePlayer();
        DefineBounds();
    }

    private void MovePlayer()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 moveForward = transform.forward * verticalMove;
        Vector3 moveLeftRight = transform.right * horizontalMove;

        transform.position += moveForward;
        transform.position += moveLeftRight;
    }

    private void RotatePlayer()
    {
        float xAxis = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;

        transform.Rotate(0f, xAxis, 0f);
    }

    private void DefineBounds()
    {
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }

        if (transform.position.z < minZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, minZ);
        }

        if (transform.position.z > maxZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, maxZ);
        }
    }

    public void killPlayer()
    {
        moveSpeed = 0;
    }
}
