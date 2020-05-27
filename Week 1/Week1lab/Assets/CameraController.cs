using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private Vector3 offsetPosition;
    [SerializeField] private Vector3 offsetRotation;

    private Vector3 offset1 = new Vector3(1f, 2f, -1.5f);
    private Vector3 offset2 = new Vector3(1f, 3f, -3f);

    protected void LateUpdate()
    {
        ChangeOffset();
    }

    private void ChangeOffset()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.localPosition = offset1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.localPosition = offset2;
        }
    }

    //[SerializeField] private Transform target; //adds target slot to put player in

    //[SerializeField] public float smoothSpeed = 5f; //speed of camera movement

    //[SerializeField] public Vector3 offset; //for offsetting camera from player

    ////Change these values in the inspector for your own offsets
    //[SerializeField] private Vector3 offset1 = new Vector3(1f, 2f, -1.5f);
    //[SerializeField] private Vector3 offset2 = new Vector3(1f, 3f, -3f);

    //private Vector3 currentOffset;

    //private void Start()
    //{
    //    //Set the offset to a default value
    //    currentOffset = offset1;
    //}

    //void LateUpdate()
    //{
    //    FollowPlayer();
    //    ChangeOffset();
    //}

    //private void FollowPlayer()
    //{
    //    Vector3 desiredPosition = target.position + currentOffset; //seperates camera form player at a set distance or location

    //    Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); //makes camera move more smoothly

    //    transform.position = smoothedPosition; // updates camera position
    //}

    ////Seperate method for every purpose
    //private void ChangeOffset()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        //This changes the offset used in FollowPlayer to the first preset
    //        transform.localPosition = offset1;
    //        currentOffset = offset1;
    //    }

    //    if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        //This changes the offset used in FollowPlayer to the second preset
    //        transform.localPosition = offset2;
    //        currentOffset = offset2;
    //    }
    //}
}
