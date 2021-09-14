using UnityEngine;

public class SpawnerModel
{
    public Spawner spawner;

    public void SpawnNewBullet()
    {
        _spawnNewBullet();
    }
    private void _spawnNewBullet()
    {
        spawner.Spawn();
    }
}
