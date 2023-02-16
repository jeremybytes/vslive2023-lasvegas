﻿namespace DefaultImplementation;

public enum LogLevel
{
    None,
    Info,
    Warning,
    Error,
}

internal interface ILogger
{
    void Log(LogLevel level, string message);

    void LogException(Exception ex) => Log(LogLevel.Error, ex.ToString());
}
