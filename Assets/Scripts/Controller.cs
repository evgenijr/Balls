public class Controller : Observer
{
    public TargetModel TargetModel;
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
        if (View.shootClicked)
        {
            _shootClicked();
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
    private void _shootClicked()
    {
        if(!isLose)
        SpawnerModel.SpawnNewBullet();
        else
        {
            isLose = !isLose;
            TargetModel.restart();
            View.SetNewScore(TargetModel.score);
        }
    }
    private void _lose()
    {
        isLose = true;
        TargetModel.lose();
    }
    private void _hit()
    {
        TargetModel.PlusScore(1);
        View.SetNewScore(TargetModel.score);
    }
}
