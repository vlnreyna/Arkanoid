using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float limit = 6.5f;
    public float dir;
    public float moreSpeed = 0.4f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x <= limit ) {
            dir = 1f;
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x >= -limit)
        {
            dir = -1f;
        }
        else 
        {
            dir = 0f;
        }

        Vector2 move = new Vector2(dir, 0f) * speed * Time.deltaTime;
        transform.Translate(move);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ball"))
        {
            speed += moreSpeed;
        }    
    }
}