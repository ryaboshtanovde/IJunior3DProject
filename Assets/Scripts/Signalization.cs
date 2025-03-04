using UnityEngine;

public class Signalization : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private RobberDetector _robberDetector;
    private bool _isPlaying = false;

    private float _maxVolume = 1.0f;
    private float _minVolume = 0f;
    private float _volumeChangeSpeed = 0.001f;

    private void Start()
    {
        _audioSource.volume = 0;
    }

    private void FixedUpdate()
    {
        if (_isPlaying)
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolume, _volumeChangeSpeed);
        else
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _minVolume, _volumeChangeSpeed);
    }

    private void ChangeState()
    {
        _isPlaying = !_isPlaying;
    }

    private void OnEnable()
    {
        _robberDetector._robberDetected += ChangeState;
    }

    private void OnDisable()
    {
        _robberDetector._robberDetected -= ChangeState;
    }
}
