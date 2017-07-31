using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booletScript : MonoBehaviour 
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
    #endregion

    #region Events
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        Destroy(gameObject, 2);
    }
    private void Update()
    {
        transform.position +=Vector3.forward*Time.deltaTime*100;
    }
    #endregion

    #region Event Handlers
    #endregion
}
