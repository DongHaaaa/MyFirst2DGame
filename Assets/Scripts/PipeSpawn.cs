using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float maxTime = 3f;
    [SerializeField] private float heightRange = 0.5f;
    private float timer;
    private void Awake()
    {
        timer = 0f;
    }
    void Start()
    {
        SpawnPipe();
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxTime)
        {
            timer = 0;
            SpawnPipe();
        }
    }
    private void SpawnPipe()
    {
        float randomHeight = Random.Range(-heightRange, heightRange);
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + randomHeight, transform.position.z);
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, transform.rotation);
        Destroy(pipe, 5f);
    }
}
