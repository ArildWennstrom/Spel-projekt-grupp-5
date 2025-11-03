using UnityEngine;

public class GameManager : MonoBehaviour
{
    int StepsToSpawn;
    
    [SerializeField] GameObject ObstaclePrefab;
    GameObject obstacle;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        print("StepsToSpawn = " + StepsToSpawn);
        if (StepsToSpawn <= 0)  
        {
            obstacle = Instantiate(ObstaclePrefab);
            obstacle.transform.position = new Vector2(15, Random.Range(-2,-5));
            StepsToSpawn = 200;
        }
        StepsToSpawn -= 1;
    }
}
