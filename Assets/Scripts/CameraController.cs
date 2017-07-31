using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Enums
    #endregion

    #region Delegates
    #endregion

    #region Structures
    #endregion

    #region Classes
    #endregion

    #region Fields
    public float Speed = 3;
    [Range(0, 10)]
    public float smoothTime;
    [SerializeField]
    public GameObject Target { get; private set; }
    #endregion

    #region Events
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (Target == null)
            return;
        cameraMove();
    }

    private void cameraMove()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.z, Target.transform.position.z, ref Speed, smoothTime);
        transform.position = new Vector3(transform.position.x , transform.position.y, newPosition);
    }
    #endregion

    #region Event Handlers
    #endregion
}
