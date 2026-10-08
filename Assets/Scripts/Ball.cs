using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 dir;
    public float moreSpeed = 0.2f;
    public float delay = 2f;
    public bool isMoving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BallStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            transform.Translate(dir * speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Roof"))
        {
            dir = new Vector2(dir.x, -dir.y);
            speed += moreSpeed;
            GameManager.Instance.IncreasePlayerPointsWalls();
        }
        
        if(other.CompareTag("Wall"))
        {
            dir = new Vector2(-dir.x, dir.y);
            speed += moreSpeed;
            GameManager.Instance.IncreasePlayerPointsWalls();
        }

        if (other.CompareTag("Player"))
        {
            //dir = new Vector2(-dir.x , dir.y); 

            float x = (transform.position.x - other.transform.position.x) / (other.bounds.size.x / 2f);
            dir = new Vector2(x, -dir.y);
            speed += moreSpeed;
        }

        if(other.CompareTag("BlockLat"))
        {
            dir = new Vector2(-dir.x, dir.y);
            speed += moreSpeed;
        }   

        if (other.CompareTag("BlockFron")) {
            dir = new Vector2 (dir.x, -dir.y);
            speed += moreSpeed;
        }

     }


    IEnumerator BallStart() //coroutine
    {
        isMoving = false;
        transform.position = Vector2.zero;
        float y = Random.Range(0f, 0.6f);
        float x = Random.Range(0.5f, -0.5f);
        dir = new Vector2(x,y).normalized;
        speed = 5f;
        yield return new WaitForSeconds(delay);
        
        isMoving = true;
    }
}
