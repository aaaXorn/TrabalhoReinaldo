using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControl : MonoBehaviour
{
    public ParticleSystem fireweapon;
    public AudioSource source;

    private bool shoot;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (shoot)
        {
            fireweapon.Emit(1);
            source.Play();
        }
    }

    public void ShootInput()
    {
        shoot = true;
    }

    public void ShootRelease()
    {
        shoot = false;
    }
}
