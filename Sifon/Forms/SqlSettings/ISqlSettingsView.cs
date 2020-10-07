﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Sifon.Abstractions.Profiles;
using Sifon.Code.Events;

namespace Sifon.Forms.SqlSettings
{
    public interface ISqlSettingsView : ISynchronizeInvoke
    {
        event EventHandler<EventArgs<string>> SelectedRecordChanged;
        event EventHandler<EventArgs<string>> SqlRecordDeleted;
        event EventHandler<EventArgs<ISqlServerRecord>> TestClicked ;
        event EventHandler<EventArgs<ISqlServerRecord>> SqlRecordAdded;
        event EventHandler<EventArgs<Tuple<string, ISqlServerRecord>>> SqlRecordRenamed;
        event EventHandler<EventArgs> FormLoad;
        event EventHandler<EventArgs> ClosingForm;

        void ShowInfo(string caption, string message);
        void ShowError(string caption, string message);
        void ToggleControls(bool enabled);

        void SetSqlServerName(string name);
        void SetSqlInstance(string instanceName);
        void SetSqlUsername(string username);
        void SetSqlPassword(string password);

        void PopulateServersDropdown(IEnumerable<string> serverRecords, string selectedRecord);

        void CloseDialog();
    }
}
