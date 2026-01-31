using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void playerDelegate();

    public event playerDelegate OnPlayerDeath;
    public event playerDelegate OnPlayerScore;


    private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 5;
    public int score { get; private set; }
    [SerializeField] private AudioSource audio;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
            audio.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Success"))
        {
            score++;
            OnPlayerScore?.Invoke();
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            OnPlayerDeath?.Invoke();
        }
    }
}
