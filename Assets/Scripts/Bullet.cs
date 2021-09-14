using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField]private float Speed;

    private Collider _col;
    private Rigidbody _rb;
    private bool hited;
    private void Awake()
    {
        _col= GetComponent<Collider>();
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = Vector3.up * Speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        _rb.velocity = Vector3.zero;
        if (other.CompareTag("Platform"))
        {
            if (other.TryGetComponent(out TargetModel plat))
            {
                Subject.Notify(Notifications.TARGET_HITED);
                Physics.IgnoreCollision(_col, other);
                hited = true;
                enabled = false;
                transform.SetParent(other.transform);
            }
            else return;
        }
        else if (other.CompareTag("Bullet"))
        {
            Subject.Notify(Notifications.LOST_GAME);
            enabled = false;
            _rb.isKinematic = false;
        }
    }
    private void FixedUpdate()
    {
        if(!hited)
        _rb.MovePosition(transform.position + new Vector3(0, 1, 0) * Speed);
    }
}
