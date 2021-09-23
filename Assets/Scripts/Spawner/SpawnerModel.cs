using UnityEngine;

public class SpawnerModel
{
    public Spawner spawner;

    public void SpawnNewBullet()
    {
        spawner.Spawn();
    }
}
