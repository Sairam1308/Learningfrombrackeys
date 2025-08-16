using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    //public float minX;
    //public float maxX;

    void FixedUpdate()
    {
        //Vector3 playerPosition = transform.position;
        //playerPosition.x = Mathf.Clamp(playerPosition.x, minX, maxX);
        //transform.position = playerPosition;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);        
      
       

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
          
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    public void MoveRightButton()
    {
        rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    public void MoveLeftButton()
    {
        rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
