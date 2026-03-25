using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

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
        // Image detected → show menu
        foreach (var added in args.added)
            roomListCanvas.SetActive(true);

        // Image updated → check if still being tracked
        foreach (var updated in args.updated)
        {
            if (updated.trackingState == TrackingState.Tracking)
                roomListCanvas.SetActive(true);   // still visible
            else
                roomListCanvas.SetActive(false);  // lost or limited tracking
        }

        // Image completely gone → hide menu
        foreach (var removed in args.removed)
            roomListCanvas.SetActive(false);
    }
}
