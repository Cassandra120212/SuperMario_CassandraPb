using UnityEngine;

public class MovimientoIzquierda : MonoBehaviour
{
    private float velocidadX = 2f;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocityX = -velocidadX;
    }
}
