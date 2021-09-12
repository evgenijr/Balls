using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public void Spawn()
    {
        Instantiate(BulletPrefab, transform.position, transform.rotation);
    }
}
