using System;
using UnityEngine.UI;

public class Controller : Observer
{
    public Platforms PlatformModel;
    public SpawnerModel SpawnerModel;
    public VIew View;
    
    //private PlayerModel PlayerModel;

    public Controller()
    {
        SpawnerModel = new SpawnerModel();
        //PlayerModel = new PlayerModel();
        Subject.AddObserver(this);
    }
    public void Update()
    {
        if (View.shootClicked)
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
        SpawnerModel.SpawnNewBullet();
    }
    private void _hit()
    {
        View.SetNewScore(PlatformModel.score);
    }
}
