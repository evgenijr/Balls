using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private float Speed = 10f;

    private Rigidbody _rb;
    private Collider _col;

    public bool isPlatformHited;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            Subject.Notify(Notifications.PLATFORM_HITED);
            isPlatformHited = true;
        }
        Destroy(gameObject);
    }
    private void LateUpdate()
    {
        isPlatformHited = false;
    }
    private void Update()
    {
        _rb.MovePosition(transform.position + Vector3.up * Speed * Time.deltaTime);
    }
}
