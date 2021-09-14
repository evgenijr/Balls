using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject BulletPrefab;
    public void Spawn()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}