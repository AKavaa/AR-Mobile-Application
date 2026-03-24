using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageTrackingUIHandler : MonoBehaviour
{
    [SerializeField] private ARTrackedImageManager trackedImageManager;
    [SerializeField] private GameObject roomListCanvas;

    void OnEnable()
    {
        trackedImageManager.trackablesChanged.AddListener(OnTrackablesChanged);
    }

    void OnDisable()
    {
        trackedImageManager.trackablesChanged.RemoveListener(OnTrackablesChanged);
    }

    void OnTrackablesChanged(ARTrackablesChangedEventArgs<ARTrackedImage> args)
    {
        foreach (var added in args.added)
            roomListCanvas.SetActive(true);

        foreach (var removed in args.removed)
            roomListCanvas.SetActive(false);
    }
}
