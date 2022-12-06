using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public int damage;
    public int range;
    public int ammo;
    public bool isPickedUp;
    //public int _maxAmmo;
    //public int _currAmmo;
    //public GameObject _muzzleFlash;

    public Camera fpsCam;

    private void Start()
    {
        //_currAmmo = (int)(.75f * _maxAmmo);
        //_muzzleFlash.transform.position = transform.position;
    }

    void Update()
    {
        if(ammo > 99)
        {
            ammo = 99;
        }    
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

        if (ammo > 0)
        {
            --ammo;

            //_muzzleFlash.SetActive(true);

            //StartCoroutine(MuzzleFlash());
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                //EnemyController target = hit.transform.GetComponent<EnemyController>();
                //if (target != null)
                //{
                //    hit.transform.GetComponent<EnemyController>().TakeDamage(damage);
                //}
            }
        }
    }

    IEnumerator MuzzleFlash()
    {
        yield return new WaitForSeconds(.1f);
        //_muzzleFlash.SetActive(false);
    }
}