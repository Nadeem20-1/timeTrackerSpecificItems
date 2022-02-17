using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;

public class TabletController : MonoBehaviour
{
    public Text currentRoom;

    public InputActionReference toggleReference;
    public TMP_Text Header;

    private PageManager pageManager;

    private bool testing = true;

    private void Awake()
    {
        pageManager = GetComponentInChildren<PageManager>();

        gameObject.SetActive(false);
        toggleReference.action.started += ToggleMenu;

        if(testing == false)
        {
            Header.text = GameManager.Instance.activeRoom.RoomName;
            return;
        }
        else
        {
            Header.text = "Home";
            return;
        }
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= ToggleMenu;
    }

    private void ToggleMenu(InputAction.CallbackContext obj)
    {
        if (gameObject.activeSelf)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);

        Debug.Log(gameObject.activeSelf);
    }

    public void ChangeRoom(string room) {
        GameManager.Instance.ChangeRooms(room);
        SetHeader(room);
        currentRoom.text = room;

        // Disable tablet after changing rooms
        gameObject.SetActive(false);
    }

    private void SetHeader(string room) => Header.text = room.ToUpper();
    private void ChangePages(string room) => pageManager.OpenPage(room);
}
