using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private View View;
    [SerializeField] private GameObject Spawner;
    [SerializeField] private Text ScoreText;
    [SerializeField] private BallModel Ball;

    private Controller GameController;
    private void Awake()
    {
        GameController = new Controller();
        GameController.View = View;
        GameController.TargetModel = Ball;
        GameController.SpawnerModel.spawner = Spawner.GetComponent<Spawner>();
    }
    private void Update()
    {
        GameController.Update();
    }
}