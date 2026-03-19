using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverConInputAction : MonoBehaviour
{
    [SerializeField]
    private InputAction accionMover;  
    [SerializeField]
    private InputAction accionSaltar; 

    private float velocidadX = 7f;
    private float velocidadY = 7f;

    private Rigidbody2D rb;  
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        accionMover.Enable();
        rb=GetComponent<Rigidbody2D>(); 
    }

    void OnEnable() 
    {
        accionSaltar.Enable();
        accionSaltar.performed +=saltar; 
    }

    void OnDisable()
    {
        accionSaltar.Disable();
        accionSaltar.performed -=saltar; 
    }

    public void saltar (InputAction.CallbackContext context)
    {
        
        rb.linearVelocityY = velocidadY*1; 
    }
    // Update is called once per frame
    void Update()
    {
        //leer la entrada
        Vector2 movimiento = accionMover.ReadValue<Vector2>(); 
        rb.linearVelocityX= velocidadX*movimiento.x; 
    
    }
}
