using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipes;
    public float spawnRate;
    private float timer = 0;
    public float highOffSet;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    private void spawnPipe()
    {
        float highestPoint = transform.position.y - highOffSet;
        float lowestPoint = transform.position.y + highOffSet;
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
