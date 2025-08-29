using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    string playerDirection;
    public float minX=-5;
    public float maxX=5;

    void FixedUpdate()
    {
        Vector3 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x, minX, maxX);
        transform.position = playerPosition;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);        
      
       
        //Move right using keyboard
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);          
        }

        //Move left using keyboard
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //game over condition if the cube fell down
        if (rb.position.y <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void Update() //using event trigger move the player
    {
        if (playerDirection == "d")
        {
            transform.position= transform.position+new Vector3(10f * Time.deltaTime, 0, 0);            
        }
        if (playerDirection == "a")
        {
            transform.position = transform.position + new Vector3(-10f * Time.deltaTime, 0, 0);
        }
    }
    public void MoveRightButton() 
    {
        //rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
         playerDirection = "d";
    }
    public void MoveLeftButton()
    {
        //rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        playerDirection = "a";
    }

    public void StopMove()
    {
        playerDirection = "no";
    }

}