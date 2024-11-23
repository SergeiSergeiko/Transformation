using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _colorChangeDuration;

    private MeshRenderer _meshRendere;
    private Tween _colorChange;

    private void Awake()
    {
        _meshRendere = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        ChangeColor();
    }

    private void Update()
    {
        if (_colorChange.active == false)
            ChangeColor();
    }

    private void ChangeColor()
    {
        Color color = GetRandomColor();

        _colorChange = _meshRendere.material.DOColor(color, _colorChangeDuration);
    }

    private Color GetRandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}