using AppInfo = Orchestra.Connector.AppInfo.ConnectorInfo;

Console.WriteLine($"{AppInfo.Name} (V {AppInfo.Version}, {AppInfo.VersionDate.Date.ToLongDateString()})");
Console.WriteLine($"");
