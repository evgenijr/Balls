using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class BallModel : MonoBehaviour
{
    public int Score { get; private set; }

    private Rotator BallRotator;

    private void Awake()
    {
        if (TryGetComponent(out Rotator rotator))
            BallRotator = rotator;
        else return;
        
        Score = 0;
    }
    public void PlusScore(int val)
    {
        _plusScore(val);
    }
    public void Restart()
    {
        _restart();
    }
    public void Lose()
    {
        BallRotator.enabled = false;
        Score = 0;
    }

    private void _restart()
    {
        List<Transform> childs3 = transform.Cast<Transform>().ToList();
        foreach (var item in childs3)
        {
            Destroy(item.gameObject);
        }
        BallRotator.enabled = true;
    }
    private void _plusScore(int val)
    {
        Score += val;
    }
}
