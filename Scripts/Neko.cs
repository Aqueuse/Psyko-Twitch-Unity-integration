using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TwitchChatConnect.Client;
using TwitchChatConnect.Config;
using TwitchChatConnect.Data;
using TwitchChatConnect.Manager;
using UnityEngine;
using UnityEngine.UI;

public class Neko : MonoBehaviour {

    //OAuth = https://twitchapps.com/tmi
    void Start() {
        TwitchChatClient.instance.Init(() => {
            TwitchChatClient.instance.onChatMessageReceived += ShowMessage;
            TwitchChatClient.instance.onChatCommandReceived += ShowCommand;
            TwitchChatClient.instance.onChatRewardReceived += ShowReward;
        }, message => {
            Debug.LogError(message);
        });
    }

    void ShowCommand(TwitchChatCommand chatCommand) {
        if (chatCommand.Command == "Nom de la command qui trigger "){
            TwitchChatClient.instance.SendChatMessage("Miaou");
        }
    }

    void ShowReward(TwitchChatReward chatReward) {
    }

    void ShowMessage(TwitchChatMessage chatMessage) {
    }
}
