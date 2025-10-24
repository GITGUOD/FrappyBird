using UnityEngine;

public class MovingPipe : MonoBehaviour
{
    public float movement;
    public float deathZone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * movement * Time.deltaTime; // deltaTime gör så att framerate inte spelar någon roll
        if(transform.position.x < deathZone)
        {
            Destroy(gameObject);
        }
    }
}
