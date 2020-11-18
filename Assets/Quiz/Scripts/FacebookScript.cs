using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;



public class FacebookScript : MonoBehaviour
{

    public Text FriendsText;

    private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {

                if (FB.IsInitialized)
                    FB.ActivateApp();
                else
                    Debug.Log("Couldn't Initialize");
            },
            isGameShown =>
            {
                if (!isGameShown)
                    Time.timeScale = 0;
                else
                    Time.timeScale = 1;
            });
        }
        else
            FB.ActivateApp();
    }

    #region Facebook Login/Logout
    public void FacebookLogin()
    {
        var permissions = new List<string>() { "public_profile", "email", "user_friends" };
        FB.LogInWithReadPermissions(permissions);
    }

    public void FacebookLogout()
    {
        FB.LogOut();
    }
    #endregion
    #region Facebook Share
    public void FacebookShare()
    {
        FB.ShareLink(new System.Uri("https://www.africanbank.co.za/"), "Check it out", "Great financial habits quiz game!", new System.Uri(""));
    }
    #endregion

    #region Facebook Invitation

    public void FacebookGameRequest()
    {
        FB.AppRequest("Hey! Come and Play this wonderful game! ", title: "AB Financial lIteracy Quiz");
    }

    /*
    public void FacebookInvite()
    {
        FB.Mobile.AppInvite(new System.Uri(""));
    }    */
    #endregion

    public void GetFriendsPlayingThisGame() 
    {
        string query = "/me/friends";
        FB.API(query, HttpMethod.GET, result =>
        {
            var dictionary = (Dictionary<string, object>)Facebook.MiniJSON.Json.Deserialize(result.RawResult);
            var friendsList = (List<object>)dictionary["data"];
            FriendsText.text = string.Empty;

            foreach (var dict in friendsList)
                FriendsText.text += ((Dictionary<string, object>)dict)["name"];
        });
    }


}
