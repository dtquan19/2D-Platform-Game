using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AudioSource deathAudio;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        deathAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "trap")
        {
            animator.SetTrigger("death");
            GetComponent<PlayerMovement>().enabled = false;
            deathAudio.Play();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
