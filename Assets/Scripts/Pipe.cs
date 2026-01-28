using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private Collider2D goodGameCollider;
    [SerializeField] private float moveSpeed = 3f;

    private void Awake()
    {
        goodGameCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.tag == "success")
            {
                // Do success things
            }
            
            //gg
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }
}
