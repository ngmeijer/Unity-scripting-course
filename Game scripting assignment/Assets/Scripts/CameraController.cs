using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region

    [SerializeField] private Transform player = null;

    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, 0f);

    #endregion

    private void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        //transform.position = player.transform.position + offset;

        float verticalLook = Input.GetAxis("Mouse Y") * 50f * Time.deltaTime;

        transform.Rotate(-verticalLook, 0f, 0f);
    }
}
