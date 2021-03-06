﻿using System;

// ReSharper disable once CheckNamespace
namespace DlibDotNet
{

    public static partial class Dlib
    {

        #region Methods

        public static void MessageBox(string title, string message)
        {
            var t = Encoding.GetBytes(title ?? "");
            var m = Encoding.GetBytes(message ?? "");
            NativeMethods.message_box(t, t.Length, m, m.Length);
        }

        public static void SaveFileBox(StringActionMediator mediator)
        {
            if (mediator == null)
                throw new ArgumentNullException(nameof(mediator));

            mediator.ThrowIfDisposed();

            NativeMethods.save_file_box(mediator.NativePtr);
            GC.KeepAlive(mediator);
        }

        #endregion

    }

}