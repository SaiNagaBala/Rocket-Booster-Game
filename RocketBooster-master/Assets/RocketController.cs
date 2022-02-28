using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RocketController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField]
    private float rocketRotationSpeed;
    private float rocketThrustSpeed;
    void Start()
    {
     rb=GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        MoveRocketUp();

    }

    private void MoveRocketUp()
    {
        RocketThrust();
        RocketRotate();

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NotAllowed")
        {
            string scene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(scene);
        }
    }

    private void RocketRotate()
    {
        float speed = 100f;
        //rb.freezeRotation = false;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocketRotationSpeed = speed * Time.deltaTime;
            transform.Rotate(Vector3.back*rocketRotationSpeed);
            Debug.Log("Forward Rotation");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocketRotationSpeed = speed * Time.deltaTime; 
            transform.Rotate(Vector3.forward*rocketRotationSpeed);
            Debug.Log("BackWard Rotation");
        }
    }

    private void RocketThrust()
    {
        float thrust = 100f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rocketThrustSpeed=thrust * Time.deltaTime;  
            rb.AddRelativeForce(Vector3.up);
            Debug.Log("Going Up");
        }
    }
   
}
