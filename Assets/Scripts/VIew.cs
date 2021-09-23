using UnityEngine.UI;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField]private Text ScoreText;
    public bool isShootClicked { get; private set; }
    public bool isPauseClicked { get; private set; }

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
        isShootClicked = false;
        isPauseClicked = false;
    }
    private void _shootClick()
    {
        isShootClicked = true;
    }
    private void _pauseClick()
    {
        isPauseClicked = true;
    }
}