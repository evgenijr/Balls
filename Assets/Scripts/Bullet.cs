using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField]private float Speed;

    private Collider Collider;
    private Rigidbody RigidBody;
    private bool isHited;
    private void Awake()
    {
        Collider= GetComponent<Collider>();
        RigidBody = GetComponent<Rigidbody>();
        RigidBody.velocity = Vector3.up * Speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        RigidBody.velocity = Vector3.zero;
        if (other.CompareTag("Platform"))
        {
            if (other.TryGetComponent(out BallModel plat))
            {
                Subject.Notify(Notifications.TARGET_HITED);
                Physics.IgnoreCollision(Collider, other);
                isHited = true;
                enabled = false;
                transform.SetParent(other.transform);
            }
            else return;
        }
        else if (other.CompareTag("Bullet"))
        {
            Subject.Notify(Notifications.LOST_GAME);
            enabled = false;
            RigidBody.isKinematic = false;
        }
    }
    private void FixedUpdate()
    {
        if(!isHited)
        RigidBody.MovePosition(transform.position + new Vector3(0, 1, 0) * Speed);
    }
}
