﻿using System;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Delegate)]
public class AdditionalInfoAttribute : Attribute
{
    string name; string update; string download;
    public AdditionalInfoAttribute(string name, string update)
    {
        this.name = name;
        this.update = update;
    }
    public string Name { get { return name; } }
    public string Update { get { return update; } }
    public string Download
    {
        set { download = value; }
        get { return download; }
    }
}