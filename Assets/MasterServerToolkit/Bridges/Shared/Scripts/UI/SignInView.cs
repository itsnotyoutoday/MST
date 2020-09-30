﻿using Aevien.UI;
using MasterServerToolkit.Logging;
using MasterServerToolkit.MasterServer;
using MasterServerToolkit.Networking;
using System;
using TMPro;
using UnityEngine;

namespace MasterServerToolkit.Games
{
    public class SignInView : UIView
    {
#pragma warning disable 0649
        [Header("Components"), SerializeField]
        private TMP_InputField usernameInputField;
        [SerializeField]
        private TMP_InputField passwordInputField;
#pragma warning restore 0649

        public string Username
        {
            get
            {
                return usernameInputField != null ? usernameInputField.text : string.Empty;
            }
        }

        public string Password
        {
            get
            {
                return passwordInputField != null ? passwordInputField.text : string.Empty;
            }
        }

        protected override void Awake()
        {
            base.Awake();

            // Listen to show/hide events
            Mst.Events.AddEventListener(MstEventKeys.showSignInView, OnShowSignInEventHandler);
            Mst.Events.AddEventListener(MstEventKeys.hideSignInView, OnHideSignInEventHandler);
            Mst.Events.AddEventListener(MstEventKeys.setSignInDefaultCredentials, OnSetDefaultCredentialsEventHandler);
        }

        private void OnShowSignInEventHandler(EventMessage message)
        {
            Show();
        }

        private void OnHideSignInEventHandler(EventMessage message)
        {
            Hide();
        }

        private void OnSetDefaultCredentialsEventHandler(EventMessage message)
        {
            if (!message.HasData()) throw new Exception("No message data defined");

            var credentials = message.GetData<MstProperties>();

            if (credentials.Has(MstDictKeys.userName) && credentials.Has(MstDictKeys.userPassword))
                SetInputFieldsValues(credentials.AsString(MstDictKeys.userName), credentials.AsString(MstDictKeys.userPassword));
        }

        /// <summary>
        /// Sets default credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void SetInputFieldsValues(string username, string password)
        {
            if (usernameInputField)
                usernameInputField.text = username;

            if (passwordInputField)
                passwordInputField.text = password;
        }

        /// <summary>
        /// Sends sign in request to master server
        /// </summary>
        public void SignIn()
        {
            AuthBehaviour.Instance.SignIn(Username, Password);
        }

        /// <summary>
        /// Sends sign in as guest request to master server
        /// </summary>
        public void SignInAsGuest()
        {
            AuthBehaviour.Instance.SignInAsGuest();
        }

        /// <summary>
        /// Shows sing up view by sending event
        /// </summary>
        public void ShowSignUpView()
        {
            Mst.Events.Invoke(MstEventKeys.showSignUpView);
        }

        /// <summary>
        /// Shows reset password code view by sending event
        /// </summary>
        public void ShowResetPasswordCodeView()
        {
            Mst.Events.Invoke(MstEventKeys.showPasswordResetCodeView);
        }

        /// <summary>
        /// Quits the application
        /// </summary>
        public void Quit()
        {
            Mst.Runtime.Quit();
        }
    }
}