using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class TargetModel : MonoBehaviour
{
    public int score { get; private set; }

    private TargetRotate _move;

    private void Awake()
    {
        if (TryGetComponent(out TargetRotate move))
            _move = move;
        else return;
        
        score = 0;
    }
    public void PlusScore(int val)
    {
        _plusScore(val);
    }
    public void restart()
    {
        _restart();
    }
    public void lose()
    {
        _move.enabled = false;
        score = 0;
    }

    private void _restart()
    {
        List<Transform> childs3 = transform.Cast<Transform>().ToList();
        foreach (var item in childs3)
        {
            Destroy(item.gameObject);
        }
        _move.enabled = true;
    }
    private void _plusScore(int val)
    {
        score += val;
    }
}
