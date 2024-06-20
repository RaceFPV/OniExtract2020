using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using static EdiblesManager;
using static STRINGS.UI.UISIDESCREENS;

public class ExportEquipment : BaseExport
{
    public override string ExportFileName { get; set; } = "equipment";
    public List<EquipmentDef> EquipmentDefs = new List<EquipmentDef>();

    public ExportEquipment()
    {
    }

    public void AddEquipmentDef(IEquipmentConfig config)
    {
        if (!DlcManager.IsDlcListValidForCurrentContent(config.GetDlcIds()))
        {
            return;
        }
        this.EquipmentDefs.Add(config.CreateEquipmentDef());
    }
}
