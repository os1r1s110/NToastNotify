﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NToastNotify.Constants;

namespace NToastNotify
{
    public class ToastOption
    {
        public bool? TapToDismiss { get; set; }
        public string ToastClass { get; set; }
        public string ContainerId { get; set; }
        public bool? Debug { get; set; }
        public string ShowMethod { get; set; }
        public int? ShowDuration { get; set; }
        public string ShowEasing { get; set; }
        public string OnShown { get; set; }
        public string HideMethod { get; set; }
        public int? HideDuration { get; set; }
        public string HideEasing { get; set; }
        public string OnHidden { get; set; }
        public bool? CloseMethod { get; set; }
        public bool? CloseDuration { get; set; }
        public bool? CloseEasing { get; set; }
        public bool? CloseOnHover { get; set; }
        public int? ExtendedTimeOut { get; set; }
        /// <summary>
        /// Use the <see cref="NToastNotify.Constants.IconClasses"/> to set the available values
        /// </summary>
        public string IconClass { get; set; }
        /// <summary>
        /// Use the <see cref="NToastNotify.Constants.ToastPositions"/> to set the available values
        /// </summary>
        public string PositionClass { get; set; }
        public int? TimeOut { get; set; }
        public string TitleClass { get; set; }
        public string MessageClass { get; set; }
        public bool? EscapeHtml { get; set; }
        public string Target { get; set; }
        public string CloseHtml { get; set; }
        public string CloseClass { get; set; }
        public bool? NewestOnTop { get; set; }
        public bool? PreventDuplicates { get; set; }
        public bool? ProgressBar { get; set; }
        public bool? Rtl { get; set; }
        public bool? CloseButton { get; set; }
        public string Onclick { get; set; }

        public static string DefaultsJson => JsonConvert.SerializeObject(Defaults, new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver() });
        public static ToastOption Defaults
        {
            get
            {
                return new ToastOption()
                {
                    TapToDismiss = true,
                    ToastClass = "toast",
                    ContainerId = "toast-container",
                    Debug = false,
                    ShowMethod = "fadeIn",
                    ShowDuration = 300,
                    ShowEasing = "swing",
                    HideMethod = "fadeOut",
                    HideDuration = 1000,
                    HideEasing = "linear",
                    CloseMethod = false,
                    CloseDuration = false,
                    CloseEasing = false,
                    CloseOnHover = true,
                    ExtendedTimeOut = 1000,
                    IconClass = IconClasses.Info,
                    PositionClass = ToastPositions.TopRight,
                    TimeOut = 5000,
                    TitleClass = "toast-title",
                    MessageClass = "toast-message",
                    EscapeHtml = false,
                    Target = "body",
                    CloseHtml = "<button type='button'>&times;</button>",
                    CloseClass = "toast-close-button",
                    NewestOnTop = true,
                    PreventDuplicates = false,
                    ProgressBar = true,
                    Rtl = false,
                    CloseButton = true
                };


            }
        }
    }
}
