using UnityEngine;

public class bird_script : MonoBehaviour
{

    public Rigidbody2D rigid_body;
    public float flag_strength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "kun";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigid_body.linearVelocity = Vector2.up * flag_strength;
        }

    }
}
