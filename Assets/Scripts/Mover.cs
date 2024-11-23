using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _endPosition;
    [SerializeField] private float _moveDuration;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        MoveToEndPosition();
    }

    private void MoveToEndPosition()
    {
        transform.DOMove(_endPosition.position, _moveDuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}