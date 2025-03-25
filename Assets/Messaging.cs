using Firebase.Messaging;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Messaging : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FirebaseMessaging.TokenReceived += OnTokenReceived;
        FirebaseMessaging.MessageReceived += OnMessageReceived;
    }

    private void OnDestroy()
    {
        FirebaseMessaging.TokenReceived -= OnTokenReceived;
        FirebaseMessaging.MessageReceived -= OnMessageReceived;
    }

    public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
    {
        Debug.Log("Received Registration Token: " + token.Token);
    }

    public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
    {
        foreach (KeyValuePair<string, string> kvp in e.Message.Data)
        {
            Debug.LogWarning($"key: {kvp.Key}, value: {kvp.Value}");
        }

        Debug.LogError("Received a new message from: " + e.Message.Data);
    }
}
