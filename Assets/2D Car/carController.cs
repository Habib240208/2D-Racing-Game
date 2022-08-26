using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class carController : MonoBehaviour {

	
	public float fuel = 1;
	public float fuelconsumption = 0.1f;

	private float movement;
    public Image image;
    private Vector3 respawnPoint;

	public WheelJoint2D frontwheel;
	public WheelJoint2D backwheel;

	JointMotor2D motorFront;

	JointMotor2D motorBack;

	public float speedF;
	public float speedB;

	public float torqueF;
	public float torqueB;


	public bool TractionFront = true;
	public bool TractionBack = true;


	public float carRotationSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		
		


		if (Input.GetAxisRaw ("Vertical") > 0) {


			if (TractionFront) {
				motorFront.motorSpeed = speedF * -1;
				motorFront.maxMotorTorque = torqueF;
				frontwheel.motor = motorFront;
			}

			if (TractionBack) {
				motorBack.motorSpeed = speedF * -1;
				motorBack.maxMotorTorque = torqueF;
				backwheel.motor = motorBack;

			}

		} else if (Input.GetAxisRaw ("Vertical") < 0) {


			if (TractionFront) {
				motorFront.motorSpeed = speedB * -1;
				motorFront.maxMotorTorque = torqueB;
				frontwheel.motor = motorFront;
			}

			if (TractionBack) {
				motorBack.motorSpeed = speedB * -1;
				motorBack.maxMotorTorque = torqueB;
				backwheel.motor = motorBack;

			}

		} else {

			backwheel.useMotor = false;
			frontwheel.useMotor = false;

		}




		if (fuel > 0)
		{

			GetComponent<Rigidbody2D> ().AddTorque (carRotationSpeed * Input.GetAxisRaw ("Horizontal") * -1);

		}
		fuel -= fuelconsumption * Mathf.Abs(movement) * Time.fixedDeltaTime;

	}
}
