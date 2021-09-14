using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private View View;
    [SerializeField] private GameObject Spawner;
    [SerializeField] private Text ScoreText;
    [SerializeField] private TargetModel Platform;

    private Controller controller;
    private void Awake()
    {
        controller = new Controller();
        controller.View = View;
        controller.TargetModel = Platform;
        controller.SpawnerModel.spawner = Spawner.GetComponent<Spawner>();
    }
    private void Update()
    {
        controller.Update();
    }
}