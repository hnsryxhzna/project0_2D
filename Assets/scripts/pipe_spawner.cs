using UnityEngine;

public class pipe_spawner : MonoBehaviour
{

    public GameObject pipe;

    public float spawn_rate = 1;

    public float height_offset = 10;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn_pipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawn_rate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawn_pipe();
            timer = 0;
        }
    }

    void spawn_pipe()
    {
        float lowest_point = transform.position.y - height_offset;
        float heighest_point = transform.position.y + height_offset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest_point, heighest_point), 0), transform.rotation);
    }
}
