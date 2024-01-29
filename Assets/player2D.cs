using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player2D : MonoBehaviour
{
    public float velocidaddeMovimiento = 5f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float desplazamientoX, desplazamientoY;
    private Vector2 direcciondeMovimiento;
    private Rigidbody2D rbPersonaje;
    private PlayerInputAction playerinputActions;
    public static player2D Instance;
    private bool canshoot;
     
    
    

    // se le pone private
    void Start()
    {
        rbPersonaje = this.GetComponent<Rigidbody2D>();
        playerinputActions.Enable();
        playerinputActions.Standard.Shooting.performed += Shoot;
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
    private void Awake()
    {
        playerinputActions = new PlayerInputAction();
        rbPersonaje = GetComponent<Rigidbody2D>();
    }
    
    private void LateUpdate()
    {
        
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        

        
        {
            string buttonName = context.control.name;

            switch (buttonName)
            {
                case "upArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 90));
                    break;
                case "downArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, -90));
                    break;
                case "leftArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0, 0, 180));
                    break;
                case "rigthArrow":
                    Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                    break;
            }
        }
    }
}
