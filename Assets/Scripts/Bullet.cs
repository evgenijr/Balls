using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private float Speed = 10f;

    private Rigidbody _rb;
    private Collider _col;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<Collider>();
        //_rb.AddForce(Vector3.up * Speed * Time.deltaTime, ForceMode.Impulse);
    }
    private void Start()
    {
        
        _rb.velocity = Vector3.up * Speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            if(other.TryGetComponent(out Platforms plat))
            {
                plat.PlusScore(1);
                Subject.Notify(Notifications.PLATFORM_HITED);
                Destroy(gameObject);
            }
        }
    }
    private void Update()
    {
        //_rb.AddForce(Vector3.up * Speed * Time.deltaTime, ForceMode.Impulse);
        Vector3 tempVect = new Vector3(0, 1, 0);
        tempVect = tempVect.normalized * Speed * Time.deltaTime;
        _rb.MovePosition(transform.position + tempVect);
    }
}
