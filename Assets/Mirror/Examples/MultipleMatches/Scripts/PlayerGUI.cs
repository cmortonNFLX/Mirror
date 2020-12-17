using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.MultipleMatch
{
    public class PlayerGUI : MonoBehaviour
    {
        [SerializeField] Text playerName;

        public void SetPlayerInfo(PlayerInfo info)
        {
            playerName.text = "Player " + info.playerIndex;
            playerName.color = info.ready ? Color.green : Color.red;
        }
    }
}