using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private VIew View;
    [SerializeField] private GameObject Spawner;
    [SerializeField] private Text ScoreText;
    [SerializeField] private Platforms Platform;

    private Controller controller;

    private void Awake()
    {
        controller = new Controller();
        controller.View = View;
        controller.PlatformModel = Platform;
        controller.SpawnerModel.spawner = Spawner.GetComponent<Spawner>();
    }
    private void Update()
    {
        controller.Update();
    }
}
