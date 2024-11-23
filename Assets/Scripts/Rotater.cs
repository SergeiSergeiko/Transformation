using DG.Tweening;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType = LoopType.Restart;
    [SerializeField] private RotateMode _rotateMode = RotateMode.FastBeyond360;

    private Vector3 _rotationAngle = new(360, 360, 0);

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(_rotationAngle, _duration, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetEase(Ease.Linear);
    }
}