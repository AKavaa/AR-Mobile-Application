using UnityEngine;
using UnityEngine.UI;

public class RoomListUI : MonoBehaviour
{
    [SerializeField] private GameObject mapImageObject;
    [SerializeField] private Image mapImage;

    [SerializeField] private Sprite receptionMap;
    [SerializeField] private Sprite libraryMap;
    [SerializeField] private Sprite studyRoomMap;
    [SerializeField] private Sprite bathroomMap;
    [SerializeField] private Sprite elevatorMap;

    public void ShowReception()  { ShowMap(receptionMap); }
    public void ShowLibrary()    { ShowMap(libraryMap); }
    public void ShowStudyRoom()  { ShowMap(studyRoomMap); }
    public void ShowBathroom()   { ShowMap(bathroomMap); }
    public void ShowElevator()   { ShowMap(elevatorMap); }

    public void CloseMap()
    {
        mapImageObject.SetActive(false);
        gameObject.SetActive(true);
    }

    private void ShowMap(Sprite map)
    {
        mapImage.sprite = map;
        mapImageObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
