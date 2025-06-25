using UnityEngine;

public class Jump : MonoBehaviour
{
    new Rigidbody rigidbody;
    public float jumpStrength = 2;
    public event System.Action Jumped;
      public float distanceThreshold = .15f;
          const float OriginOffset = .001f;
    [SerializeField, Tooltip("Prevents jumping when the transform is in mid-air.")]
    GroundCheck groundCheck;
       Vector3 RaycastOrigin => transform.position + Vector3.up * OriginOffset;
    float RaycastDistance => distanceThreshold + OriginOffset;
    bool Platmove;
   float distance;
    public Transform endPoint;
    private float speed;

    Rigidbody rb;
    void Reset()
    {
        // Try to get groundCheck.
        groundCheck = GetComponentInChildren<GroundCheck>();
    }

    void Awake()
    {
        // Get rigidbody.
        rigidbody = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        // Jump when the Jump button is pressed and we are on the ground.
        if (Input.GetButtonDown("Jump") && (!groundCheck || groundCheck.isGrounded))
        {
            rigidbody.AddForce(Vector3.up * 100 * jumpStrength);
            Jumped?.Invoke();

        }
    }

    void Update()
    {
        Physics.Raycast(RaycastOrigin, Vector3.down, distanceThreshold * 2);

    }

    void FixedUpdate()
    {
        // if statement to check if a bool is true

        // IF TRUE add force in the same direction of the platform
    }

    /*void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Child maker"))
        {
            //gameObject.transform.SetParent(other.transform, true);

            transform.parent = other.transform;
            bool Platmove=true ;
            // set a bool to true if has collided

        }
    }
    //void OnCollisionExit(Collision other)
    //{
        //gameObject.transform.SetParent(other.transform, false);

        //transform.parent = null;
        //bool Platmove=false;
        // set bool to false once exit

    //}
    //void Start()
    //{
        //bool Platmove=false;
   // }
    //Found this on googel hope it would
    // Example 2: Parent with worldPositionStays = false (default)
    // childObject.transform.SetParent(parentObject.transform, false);

    // Example 3: Parent with worldPositionStays = true
    //childObject.transform.SetParent(parentObject.transform, true);
    */
}


