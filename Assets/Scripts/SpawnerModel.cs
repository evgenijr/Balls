using UnityEngine;

public class SpawnerModel
{
    public Spawner spawner;

    public void SpawnNewBullet()
    {
        _spawnNewBullet();
    }
    public void lose()
    {
        spawner.gameObject.SetActive(false);
    }

    private void _spawnNewBullet()
    {
        spawner.Spawn();
    }
}
