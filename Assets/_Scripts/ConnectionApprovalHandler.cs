using Unity.Netcode;
using UnityEngine;

public class ConnectionApprovalHandler : MonoBehaviour
{
    private const int MaxPlayer = 1;

    private void Start()
    {
        NetworkManager.Singleton.ConnectionApprovalCallback += ApprovalCheck;
    }

    private void ApprovalCheck(NetworkManager.ConnectionApprovalRequest request, NetworkManager.ConnectionApprovalResponse response)
    {
        Debug.Log("Connection Approval");
        response.Approved = true;
        response.CreatePlayerObject = true;
        response.PlayerPrefabHash = null;
        if(NetworkManager.Singleton.ConnectedClients.Count >= MaxPlayer)
        {
            response.Approved = false;
            response.Reason = "Server is full";
        }
        response.Pending = false;
    }
}
