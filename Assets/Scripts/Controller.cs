using System;
using UnityEngine.UI;

public class Controller : Observer
{
    public SpawnerModel spawner;
    public PlayerModel player;
    public VIew view;

    public Controller()
    {
        spawner = new SpawnerModel();
        player = new PlayerModel();
        view = new VIew();
    }
    public void Update()
    {
        if (view.shootClicked)
        {
            _shootClicked();
        }
    }
    public override void OnNotify(Notifications notification)
    {
        switch (notification)
        {
            case Notifications.PLATFORM_HITED:
                {
                    _hit();
                    break;
                }

        }
    }

    private void _shootClicked()
    {
        spawner.SpawnNewBullet();
    }
    private void _hit()
    {
        view.SetNewScore(player.Hit());
    }
}
