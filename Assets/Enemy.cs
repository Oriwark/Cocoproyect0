using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector3 direction = (player2D.Instance.transform.position - transform.position).normalized;
        rb.AddForce(direction * speed);
    }
}


