using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private bool isThrown = false;

    public float moveSpeed = 2f;

    public float changeStrength = 1f;
    public float throwForce = 1000f;

    public float spinStrength = 0f;

    public float spinChangeStrength = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //gets the rigid body from the same object
    }

    void Update()
    {

        if (!isThrown)
        {
            if (Input.GetKey(KeyCode.Space))
            {

                rb.AddForce(Vector3.back * throwForce, ForceMode.Impulse);
                /**gives the rigid body a physical forward force same strength as throwforce
                //done when space is clicked
                //Add force obeys physics engine unlike transform
                //changed to .back as for some reason the ball was going the wrong way
                //changed the end to say ForceMode.Impulse casue sometimes multiple
                //space presses were needed to get the ball going,this should apply
                all the force insta **/

                rb.AddTorque(Vector3.forward *spinStrength, ForceMode.Impulse);
                //vecotor3.forward draws an inivisible line horizontally and rotates the ball on the line.

                isThrown = true;
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;

                //delta time here so ball moves left as fast as real world seconds.
                //direction is inversed cause ball is inversed for some reason.

            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
                //direction is inversed cause ball is inversed for some reason.
            }

            if (Input.GetKey(KeyCode.W))
            {
                throwForce += changeStrength * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.S))
            {
                throwForce -= changeStrength * Time.deltaTime;
            }

            if (throwForce < 0)
            {
                throwForce = 0;
                //so no issues happen
            }

            if (Input.GetKey(KeyCode.Q))
            {
                spinStrength -= spinChangeStrength * Time.deltaTime;
                //negative to spin counter clockwise
            }

            if (Input.GetKey(KeyCode.E))
            {
                spinStrength += spinChangeStrength * Time.deltaTime;
                //positive to spin clockwise
                
            }
        }
    }
}