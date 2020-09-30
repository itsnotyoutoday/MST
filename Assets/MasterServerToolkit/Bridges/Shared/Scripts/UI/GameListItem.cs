﻿using Aevien.UI;
using MasterServerToolkit.MasterServer;
using TMPro;
using UnityEngine;

namespace MasterServerToolkit.Games
{
    public class GameListItem : MonoBehaviour
    {
        #region INSPECTOR

#pragma warning disable 0649
        [SerializeField]
        private TextMeshProUGUI gameNameText;

        [SerializeField]
        private TextMeshProUGUI gameAddressText;
        [SerializeField]
        private TextMeshProUGUI gameRegionText;
        [SerializeField]
        private TextMeshProUGUI gamePlayersText;

        [SerializeField]
        private UIButton connectButton;
#pragma warning restore 0649

        #endregion

        public void SetInfo(GameInfoPacket gameInfo, GamesListView owner)
        {
            if (gameNameText)
            {
                gameNameText.text = gameInfo.IsPasswordProtected ? $"{gameInfo.Name} <color=yellow>[Password]</color>" : gameInfo.Name;
            }

            if (gameAddressText)
            {
                gameAddressText.text = gameInfo.Address;
            }

            if (gameRegionText)
            {
                string region = string.IsNullOrEmpty(gameInfo.Region) ? "International" : gameInfo.Region;
                gameRegionText.text = $"Region: <color=yellow>{region}</color>";
            }

            if (gamePlayersText)
            {
                string maxPleyers = gameInfo.MaxPlayers <= 0 ? "∞" : gameInfo.MaxPlayers.ToString();
                gamePlayersText.text = $"Players: <color=yellow>{gameInfo.OnlinePlayers} / {maxPleyers}</color>";
            }

            if (connectButton)
            {
                connectButton.AddOnClickListener(() => {
                    MatchmakingBehaviour.Instance.StartMatch(gameInfo);
                });
            }
        }
    }
}