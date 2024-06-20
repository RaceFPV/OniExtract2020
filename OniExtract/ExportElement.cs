using OniExtract2;
using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using static EdiblesManager;

public class ExportElement : BaseExport
{
    public override string ExportFileName { get; set; } = "elements";
    public Dictionary<int, Element> elementTable;

    public ExportElement()
	{
        this.elementTable = ElementLoader.elementTable;
    }
}
