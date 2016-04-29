using UnityEngine;
using System.Collections;

public class Lazer : MonoBehaviour
{
    public float m_MaxLifeTime = 3f;

    public float m_MaxDamage = 2;
	
}


/*private void Start()
{
    Destroy(gameObject, m_MaxLifeTime);
}

private void OnCollisionEnter(Collision other)

{
    // find the rigidbody of the collision object
    Rigidbody targetRigidbody = other.gameObject.GetComponent<Rigidbody>();

    // only tanks will have rigidbody scripts
    if (targetRigidbody != null)
    {
        // Add an explosion force
       // targetRigidbody.AddExplosionForce(m_ExplosionForce, transform.position, m_ExplosionRadius);

        // find the TankHealth script associated with the rigidbody
        /*TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();

      /  if (targetHealth != null)
        {
            // Calculate the amount of damage the target should take
            // based on it's distance from the shell.
            float damage = CalculateDamage(targetRigidbody.position);

            // Deal this damage to the tank
            targetHealth.TakeDamage(damage);*/


      

