using UnityEngine;

public class SpawnerModel : Observer
{
    public Spawner spawner;

    public void SpawnNewBullet()
    {
        _spawnNewBullet();
    }
    public override void OnNotify(Notifications notification)
    {
        switch (notification)
        {
            case Notifications.PLATFORM_HITED:
                {
                    _spawnNewBullet();
                    break;
                }
        }
    }

    private void _spawnNewBullet()
    {
        spawner.Spawn();
    }
}
