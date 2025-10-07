using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //store the players health
    public float health = 20;
    float maxHealth;
    public Image healthBar;
    AudioSource audioSource;
    public AudioClip hitSound;
    //if we collide with something tagged as enemy, take damage
    //if health gets too low, we die (reload the level)
    //if we collide with something tagged health pack, increase health
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            if (audioSource != null & hitSound != null)
            {
                //play the hit sound
                audioSource.PlayOneShot(hitSound);
            }
            health--;
            healthBar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                //if health is to low, reload the level
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        maxHealth = health;
        healthBar.fillAmount = health / maxHealth;
    }
}