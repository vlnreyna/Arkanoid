using UnityEngine;

public class Block : MonoBehaviour
{
    public int hitpoints = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision.CompareTag("Ball"))
        {
            hitpoints--;
            
            if(hitpoints > 0)
            {
                GameManager.Instance.IncreasePlayerPointsBlocks();
            }
            

            if (hitpoints <= 0)
            {   
                GameManager.Instance.IncreasePlayerPointsBlocksDestroy();
                Destroy(gameObject);
            }
        }    
    }
}
