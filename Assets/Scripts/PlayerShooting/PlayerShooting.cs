﻿using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Rigidbody m_Lazer;

    public Transform m_FireTransform;

    public float m_LaunchForce = 30f;

   // public float coolDownTimer = 0f;

    private void Update()
    {
        if (Input.GetButtonUp("Jump"))// == true && coolDownTimer <= 0)
        {
            //coolDownTimer = 0.5f;
            Fire();
          
        }
    }

   
private void Fire()

    {
        Rigidbody lazerInstance = Instantiate(m_Lazer, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

        lazerInstance.velocity = m_LaunchForce * m_FireTransform.forward;
    }

}
