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
            case Notifications.TERGE_HITED:
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
    }
    private void _lose()
    {
        isLose = true;
        TargetModel.lose();
        SpawnerModel.lose();
    }
    private void _hit()
    {
        View.SetNewScore(TargetModel.score);
    }
}
