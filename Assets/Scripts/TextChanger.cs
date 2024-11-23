using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private string _targetText;

    private Text _text;
    private Sequence _sequence;

    private void Awake()
    {
        _text = GetComponent<Text>();
        _sequence = DOTween.Sequence();
    }

    private void Start()
    {
        _sequence.Append(_text.DOText(_targetText, _duration));
        _sequence.Append(_text.DOText(_targetText, _duration).SetRelative());
        _sequence.Append(_text.DOText(_targetText, _duration, true, ScrambleMode.All));
    }
}