using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] public BallManager resetpower;
    public static float horizontalSpeed = 5f;
    public float xRange;
    private float horizontalInput;
    
    
    void FixedUpdate()
    {
        MoveBall();
    }

    public void MoveBall()
    {
        
      if(transform.position.x >xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y,transform.position.z);
        }
      if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = CrossPlatformInputManager.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalSpeed * horizontalInput * Time.deltaTime);
    }
    public void ResetBallPosition()
    {
        var resetPos = new Vector3(0.011f,0.466f, -11.496f);
        ball.transform.position = resetPos;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.transform.rotation = Quaternion.identity;
        resetpower.power = 25000f;
        horizontalSpeed = 5;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pin" || collision.gameObject.tag == "Obstacle")
        {
            
            Invoke("ResetBallPosition", 1);

            if (collision.gameObject.tag == "Pin")
            {
               ScoreSystem.score += 50;

            }

        }


    }
   







}
