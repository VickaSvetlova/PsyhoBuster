using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiroShoot : MonoBehaviour
{
    class gun
    {
        public float gunRate, gunTimeReload, gunCountAmmo, gunDamage, gunPayImpuse;
        public bool gunReady;
        public gun(float p1, float p2, float p3, float p4, bool p5, float p6)
        {
            gunRate = p1;
            gunTimeReload = p2;
            gunCountAmmo = p3;
            gunDamage = p4;
            gunReady = p5;
            gunPayImpuse = p6;
        }
    }
    #region Enums
    #endregion

    #region Delegates
    #endregion

    #region Structures
    #endregion

    #region Classes
    #endregion

    #region Fields
    [SerializeField]
    private Transform gunSpot;
    [SerializeField]
    private GameObject boolet;
    private gun guns1;

    #endregion

    #region Events
    #endregion

    #region Properties
    #endregion

    #region Methods
    private void Start()
    {
        guns1 = new gun(0.5f,0.5f,40,7,true,2);
    }
    private void Update()
    {
        controllKeys();
    }

    private void controllKeys()
    {
        if (Input.GetKey(KeyCode.RightControl))
        {
            guntShoot(guns1);
        }
    }

    private void guntShoot(gun gunCurrent)
    {
        if (gunCurrent.gunReady && gunCountAmmo(gunCurrent, gunCurrent.gunPayImpuse))
        {
            Instantiate(boolet, gunSpot.position, gunSpot.transform.rotation);
            gunCurrent.gunReady = false;
            StartCoroutine(gunReload(gunCurrent.gunTimeReload, gunCurrent));         
        }
    }

    IEnumerator gunReload(float time, gun gunCurrent)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Weapon redy toFire");
        gunCurrent.gunReady = true;
    }
    private bool gunCountAmmo(gun gunCurrent, float payImpuse)
    {
        if ((gunCurrent.gunCountAmmo - payImpuse) > 0)
        {
            gunCurrent.gunCountAmmo -= payImpuse;
            return true;
        }
        Debug.Log("Energo colls exhausted, wait regeneration");
        return false;
    }

    IEnumerator gunFireRate(float time, gun gunCurrent)
    {
        yield return new WaitForSeconds(time);        
    }
    #endregion

    #region Event Handlers
    #endregion
}
