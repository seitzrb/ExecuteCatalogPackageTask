using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;

// 7d99f73f76fa51df
[DtsTask(DisplayName = "xecuteCatalogPackageTask", Description = "A Task to execute packages stored in the SSIS Catelog")]
public class ExecuteCatalogPackageTask : Task
{
    private string _serverName;
    private string _packageCatalog = "SSISDB";
    private string _packageFolder;
    private string _packageProject;
    public string ServerName
    {
        get { return _serverName; }
        set { _serverName = value; }
    }
    public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
    {
        
    }
    public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
    {
        return DTSExecResult.Success;
    }
    public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
    {
        return DTSExecResult.Success;
    }
}

