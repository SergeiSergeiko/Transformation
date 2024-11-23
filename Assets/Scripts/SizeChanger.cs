using DG.Tweening;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    private void Start()
    {
        ChangeScale();
    }

    private void ChangeScale()
    {
        transform.DOScale(_endScale, _duration)
            .SetLoops(-1, _loopType);
    }
}