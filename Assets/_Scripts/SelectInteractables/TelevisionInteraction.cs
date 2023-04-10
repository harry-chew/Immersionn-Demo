using UnityEngine;
using UnityEngine.Video;

public class TelevisionInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _videoRenderImage;
    [SerializeField] private VideoPlayer _videoPlayer;

    [SerializeField] private double _videoTime;

    private void Update()
    {
        if (_videoPlayer.isPlaying)
        {
            _videoTime = _videoPlayer.time;
        }
        if (_videoTime >= _videoPlayer.clip.length - 1f)
        {
            _videoPlayer.Stop();
            _videoRenderImage.SetActive(false);
        }
    }

    public void Interact()
    {
        _videoRenderImage.SetActive(true);
        _videoPlayer.Play();
    }
}
