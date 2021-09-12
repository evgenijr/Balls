using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    [SerializeField]private GameObject spawner;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField]private Text ScoreText;
    public Controller controller = new Controller();

    Manager()
    {  
        controller = new Controller();
        controller.view.ScoreText = ScoreText;
        controller.spawner.spawner = spawner.GetComponent<Spawner>();
        controller.spawner.spawner.BulletPrefab = bulletPrefab;
    }
    private void Awake()
    {
        
    }
    private void Update()
    {
        controller.Update();
    }
    private void LateUpdate()
    {
        controller.view.LateUpdate();
    }
}
