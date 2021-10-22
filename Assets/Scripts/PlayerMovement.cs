using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2000f;
    public float sidwaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
        //rb.AddForce(0, 800, 500);
    }

    // Update is called once per frame

    //changed update to FixedUpdate because
    //here we mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        // move player right
        if(Input.GetKey("d")) // if key "d" is pressed
        {
            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //move player left
        if (Input.GetKey("a")) //if key "a" is pressed
        {
            rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
