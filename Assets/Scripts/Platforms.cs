using UnityEngine;

public class Platforms : MonoBehaviour
{
    public int score { get; private set; }

    private void Awake()
    {
        score = 0;
    }
    public void PlusScore(int val)
    {
        _plusScore(val);
    }

    private void _plusScore(int val)
    {
        score += val;
    }
}
