using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2D : MonoBehaviour
{
    public float velocidaddeMovimiento = 5f ;
    [SerializeField]private float desplazamientoX, desplazamientoY;
    private Vector2 direcciondeMovimiento;
    private Rigidbody2D rbPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        rbPersonaje = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoH = Input.GetAxisRaw("Horizontal");
        rbPersonaje.velocity = new Vector2(movimientoH * desplazamientoX, rbPersonaje.velocity.y);
        Debug.Log(movimientoH);

        float movimientoV = Input.GetAxisRaw("Vertical");
        rbPersonaje.velocity = new Vector2(movimientoV * desplazamientoY, rbPersonaje.velocity.x);
        Debug.Log(movimientoV);
    }


    private void FixedUpdate()
    {
        
    }
    
}
