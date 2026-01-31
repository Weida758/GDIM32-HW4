using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float yPosition;
    [SerializeField] private float pipeSpawnTime = 4;
    private float spawnTime;
    [SerializeField] private GameObject pipePrefab;

    private float topY;
    private float bottomY;
    private float halfHeight;
    
    private void Awake()
    {
        Camera cam = Camera.main;
        halfHeight = cam.orthographicSize;

        topY = cam.transform.position.y + halfHeight;
        bottomY = cam.transform.position.y - halfHeight;
    }
    
    
    
    private void Update()
    {
        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            SpawnPipe();
            spawnTime = pipeSpawnTime;
        }
    }


    private void SpawnPipe()
    {
        yPosition = Random.Range(-2.5f, 2);
        Instantiate(pipePrefab,  new Vector3(transform.position.x, yPosition, transform.position.z), Quaternion.identity);
    }
}
