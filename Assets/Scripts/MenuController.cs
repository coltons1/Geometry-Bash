using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;




//code courtesy of diving_squid on youtube.com
//https://www.youtube.com/watch?v=l2ybEFWHsz8
//https://www.youtube.com/watch?v=l2ybEFWHsz8

public class MenuController : MonoBehaviour
{

    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectPanel;
    [SerializeField] private InputField UsernameInput;
    [SerializeField] private InputField CreateGameInput;
    [SerializeField] private InputField JoinGameInput;
    [SerializeField] private GameObject StartButton;
    
    


    private void Awake()
    {
        //var appSettings = new AppSettings();
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected to: " + PhotonNetwork.CloudRegion);
 
    }

    public void ChangeUserNameInput(){
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
        PhotonNetwork.NickName = UsernameInput.text;
    }

    private void Start()
    {
        UsernameMenu.SetActive(true);
        PhotonNetwork.ConnectToServer();
    }

    public void OnJoinedLobby()
    {
        
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


    // Update is called once per frame
    void Update()
    {
        
    }
}
