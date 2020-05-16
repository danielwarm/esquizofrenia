
using UnityEngine;

public class Target : MonoBehaviour {
    
    public AudioSource audioData;
    public ParticleSystem destructParticle; 
    public float health = 50f;
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    
    // Update is called once per frame
    void Die()
    {

        audioData.Play();
        Destroy(gameObject);

       
    }
}