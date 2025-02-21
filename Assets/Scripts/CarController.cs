using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
        private const string VERTICAL = "Vertical";


        //componentes da fisica da roda do carro
        [SerializeField] private WheelCollider frontLeftWheelTransform;
        [SerializeField] private WheelCollider frontRightWheelTransform;
        [SerializeField] private WheelCollider RearLeftWheelTransform;
        [SerializeField] private WheelCollider RearRightWheelTransform;


        //componentes da roda do carro
        [SerializeField] private Transform frontLeftWheelCollider;
        [SerializeField] private Transform frontRightWheelCollider;
        [SerializeField] private Transform RearLeftWheelCollider;
        [SerializeField] private Transform RearRightWheelCollider;

        //componentes do controller
        [SerializeField] private float motorForce;
        [SerializeField] private float breakForce;
        [SerializeField] private float maxSteeringAngle;
}
