/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//code courtesy of diving_squid on youtube.com
//https://www.youtube.com/watch?v=l2ybEFWHsz8
//https://www.youtube.com/watch?v=l2ybEFWHsz8

public class MenuController : MonoBehaviour
{

    [SerializeField] private string VersionName = "0.1";
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;

    [SerializeField] private InputField UsernameInput;
    [SerializeField] private InputField CreateGameInput;
    [SerializeField] private InputField JoinGameInput;

    [SerializeField] private GameObject StartButton;
    //private static PhotonView ScenePhotonView;

    private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(VersionName);
    }

    private void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected");
    }

    public void ChangeUserNameInput()
    {
        if(UsernameInput.text.Length >= 3)
        {
            StartButton.SetActive(true);
        } 
        else 
        {
            StartButton.SetActive(false);
        }
    }

    public void SetUserName()
    {
        UsernameMenu.SetActive(false);
        PhotonNetwork.playerName = UsernameInput.text;
    }

    public void CreateGame()
    {
        PhotonNetwork.CreateRoom(CreateGameInput.text, new RoomOptions() {MaxPlayers = 4}, null);
    }

    public void JoinGame()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text, roomOptions, TypedLobby.Default);
    } 

    private void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Stage1");
    }
    // Start is called before the first frame update
    void Start()
    {
        //ScenePhotonView = this.GetComponent<PhotonView>();
        UsernameMenu.SetActive(true);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}*/
