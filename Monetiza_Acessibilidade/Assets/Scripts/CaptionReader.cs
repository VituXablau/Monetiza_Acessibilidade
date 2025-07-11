using UnityEngine;
using UnityEngine.Video;

public class CaptionReader : MonoBehaviour
{
    VideoPlayer videoPlayer;

    [SerializeField] VideoClip[] videoClips;

    bool isPaused;

    void Start()
    {
        GameEvents.Instance.OnMouseEnter += ReadCaption;
        GameEvents.Instance.OnMouseExit += RemoveCaption;

        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if (videoPlayer.isPaused && !isPaused)
        {
            videoPlayer.clip = null;
            isPaused = true;
        }
    }

    void ReadCaption(int id)
    {
        for (int i = 0; i < videoClips.Length; i++)
        {
            if (id == i)
            {
                videoPlayer.Stop();
                videoPlayer.clip = videoClips[i];
                videoPlayer.Play();
                isPaused = false;
            }
        }
    }

    void RemoveCaption()
    {

    }
}