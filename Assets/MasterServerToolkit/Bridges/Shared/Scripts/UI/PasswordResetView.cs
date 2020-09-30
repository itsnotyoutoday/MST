﻿using Aevien.UI;
using MasterServerToolkit.Logging;
using MasterServerToolkit.MasterServer;
using MasterServerToolkit.Networking;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace MasterServerToolkit.Games
{
    public class PasswordResetView : UIView
    {
        [Header("Components"), SerializeField]
#pragma warning disable 0649
        private TMP_InputField resetCodeInputField;
        [SerializeField]
        private TMP_InputField newPasswordInputField;
        [SerializeField]
        private TMP_InputField newPasswordConfirmInputField;
#pragma warning restore 0649

        public string ResetCode
        {
            get
            {
                return resetCodeInputField != null ? resetCodeInputField.text : string.Empty;
            }
        }

        public string NewPassword
        {
            get
            {
                return newPasswordInputField != null ? newPasswordInputField.text : string.Empty;
            }
        }

        public string NewPasswordConfirm
        {
            get
            {
                return newPasswordConfirmInputField != null ? newPasswordConfirmInputField.text : string.Empty;
            }
        }

        protected override void Awake()
        {
            base.Awake();

            // Listen to show/hide events
            Mst.Events.AddEventListener(MstEventKeys.showPasswordResetView, OnShowPasswordResetEventHandler);
            Mst.Events.AddEventListener(MstEventKeys.hidePasswordResetView, OnHidePasswordResetEventHandler);
        }

        private void OnShowPasswordResetEventHandler(EventMessage message)
        {
            Show();
        }

        private void OnHidePasswordResetEventHandler(EventMessage message)
        {
            Hide();
        }

        /// <summary>
        /// Send request to master server to change password
        /// </summary>
        public void ResetPassword()
        {
            if (!Mst.Options.Has(MstDictKeys.resetPasswordEmail)) throw new Exception("You have no reset email");

            AuthBehaviour.Instance.ResetPassword(Mst.Options.AsString(MstDictKeys.resetPasswordEmail), ResetCode, NewPassword);
        }

        /// <summary>
        /// Shows sing in view by sending event
        /// </summary>
        public void ShowSignInView()
        {
            Mst.Events.Invoke(MstEventKeys.showSignInView);
        }
    }
}