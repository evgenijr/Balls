public class Controller : Observer
{
    public BallModel TargetModel;
    public SpawnerModel SpawnerModel;
    public View View;

    private bool isLose = false;
    public Controller()
    {
        SpawnerModel = new SpawnerModel();
        Subject.AddObserver(this);
    }
    public void Update()
    {
        if (View.isShootClicked)
        {
            ShootClicked();
        }
    }
    public override void OnNotify(Notifications notification)
    {
        switch (notification)
        {
            case Notifications.TARGET_HITED:
                {
                    _hit();
                    break;
                }
            case Notifications.LOST_GAME:
                {
                    _lose();
                    break;
                }
        }
    }
    private void ShootClicked()
    {
        if(!isLose)
        SpawnerModel.SpawnNewBullet();
        else
        {
            isLose = !isLose;
            TargetModel.Restart();
            View.SetNewScore(TargetModel.Score);
        }
    }
    private void _lose()
    {
        isLose = true;
        TargetModel.Lose();
    }
    private void _hit()
    {
        TargetModel.PlusScore(1);
        View.SetNewScore(TargetModel.Score);
    }
}
