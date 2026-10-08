using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public static GameManager Instance;
    public int playerPoints = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    } 

    public void IncreasePlayerPointsWalls()
    {
        playerPoints += 10;
    }
    
    public void IncreasePlayerPointsBlocks()
    {
        playerPoints += 15;
    }
    
    public void IncreasePlayerPointsBlocksDestroy()
    {
        playerPoints += 20;
    }
}
