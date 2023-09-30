
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed,body.velocity.y);
        
        
        // flip player when moving 
        
        if(horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        
        if(Input.GetKey(KeyCode.UpArrow))
        {
            body.velocity = new Vector2(body.velocity.x,speed);
        }
    
    }

}
