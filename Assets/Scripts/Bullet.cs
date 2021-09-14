using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField]private float Speed;

    private Rigidbody _rb;
    private void Awake()
    {
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
                Subject.Notify(Notifications.TERGE_HITED);
                transform.SetParent(other.transform);
                plat.PlusScore(1);
                enabled = false;
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
        _rb.MovePosition(transform.position + new Vector3(0, 1, 0) * Speed);
    }
}
