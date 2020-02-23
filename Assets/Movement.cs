
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody rb; 
    // Start is called before the first frame update
   public float forwardForce = 20f;
    public float lateralForce = 20f;

    bool firstHit = true;




    // Update is called once per frame
    void FixedUpdate()
    {

       

        if (Input.GetKey("d"))
        {
            //Debug.Log("d is pressed");
            rb.AddForce(lateralForce * Time .deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(-lateralForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
             rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }



        // rb.AddForce( 0,0,forwardForce * Time.deltaTime) ;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(firstHit && collisionInfo.collider.name == "Ground")
        {
            Debug.Log(collisionInfo.collider.name);
            firstHit = false;
        }


        if(collisionInfo.collider.tag == "Obstacle")
        {
            //Destroy();

            
            collisionInfo.gameObject.GetComponent<ParticleSystem>().Play();

            Debug.Log(collisionInfo.collider.name);
            
        }
        
        
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
    
}
