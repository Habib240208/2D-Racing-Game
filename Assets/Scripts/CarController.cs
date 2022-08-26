using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CarController : MonoBehaviour
{
    public float fuel = 1;
    public float fuelconsumption = 0.1f;
    public Rigidbody2D carRigidbody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public float speed = 20;
    public float carTorque = 10;
    private float movement;
    public Image image;
    private Vector3 respawnPoint;


    //Use this for intialization
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        
        movement = Input.GetAxis("Horizontal");
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {
        if (fuel > 0)
        {
            movement = Input.GetAxis("Horizontal");
            backTire.AddTorque(-movement * speed * Time.deltaTime);
            frontTire.AddTorque(-movement * speed * Time.deltaTime);
            carRigidbody.AddTorque(-movement * carTorque * Time.deltaTime);
        }
       
        fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;

    }
   
}
