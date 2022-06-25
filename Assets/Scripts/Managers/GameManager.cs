using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] BallManager resetpower;
    public static int horizontalSpeed = 5;



    void FixedUpdate()
    {
        MoveBall();

    }

    public void MoveBall()
    {
        Vector3 position = ball.transform.position;
        position += Vector3.right * Input.GetAxis("Horizontal") * Time.fixedDeltaTime * horizontalSpeed;
        position.x = Mathf.Clamp(position.x, -1.86f, 1.66f);
        ball.transform.position = position;
        ball.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.fixedDeltaTime * horizontalSpeed);
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
