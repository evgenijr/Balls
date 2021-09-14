using UnityEngine;

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
    public void lose()
    {
        _move.enabled = false;
    }

    private void _plusScore(int val)
    {
        score += val;
    }
}
