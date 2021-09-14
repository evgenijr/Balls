using UnityEngine.UI;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField]private Text ScoreText;
    public bool shootClicked { get; private set; }
    public bool pauseClicked { get; private set; }

    public void ShootClick()
    {
        _shootClick();
    }
    public void PauseClick()
    {
        _pauseClick();
    }
    public void SetNewScore(int val)
    {
        ScoreText.text = val.ToString();
    }
    //-----------------
    private void LateUpdate()
    {
        shootClicked = false;
        pauseClicked = false;
    }
    private void _shootClick()
    {
        shootClicked = true;
    }
    private void _pauseClick()
    {
        pauseClicked = true;
    }
}