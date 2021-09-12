using UnityEngine.UI;
using System;
[Serializable]
public class VIew
{
    public Text ScoreText;
    public bool shootClicked { get; private set; }
    public bool pauseClicked { get; private set; }

    public VIew()
    {
        //ScoreText.text = "0";
    }
    public void LateUpdate()
    {
        shootClicked = false;
        pauseClicked = false;
    }
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



    private void _shootClick()
    {
        shootClicked = true;
    }
    private void _pauseClick()
    {
        pauseClicked = true;
    }
}