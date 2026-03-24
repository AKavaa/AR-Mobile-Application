using UnityEngine;

public class RoomListUI : MonoBehaviour
{
    public void OnSelectRoom(string roomName)
    {
        Debug.Log("Selected room: " + roomName);
        // change map image here based on roomName
    }
}
