using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]private GameObject PrefabToSpawn;
    public void Spawn()
    {
        Instantiate(PrefabToSpawn, transform.position, transform.rotation);
    }
}