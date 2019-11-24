
<h1 align="center">
  <br><a href="https://github.com/kalilistic/starklogger"><img src="img/bannerIcon.png" alt="StarkLogger"></a>
  <br>StarkLogger<br>
</h1>
<h4 align="center">Basic Logger in XML format.</h4>

<p align="center">
  <a href="https://github.com/kalilistic/starklogger/releases/latest"><img src="https://img.shields.io/github/v/release/kalilistic/starklogger"></a>
  <a href="https://ci.appveyor.com/project/kalilistic/starklogger/branch/master"><img src="https://img.shields.io/appveyor/ci/kalilistic/starklogger"></a>
  <a href="https://ci.appveyor.com/project/kalilistic/starklogger/branch/master/tests"><img src="https://img.shields.io/appveyor/tests/kalilistic/starklogger"></a>
  <a href="https://codecov.io/gh/kalilistic/starklogger/branch/master"><img src="https://img.shields.io/codecov/c/gh/kalilistic/starklogger"></a>
  <a href="https://github.com/kalilistic/starklogger/blob/master/LICENSE"><img src="https://img.shields.io/github/license/kalilistic/starklogger?color=lightgrey"></a>
</p>

## Background

Very basic logger in XML format with no dependencies except .NET Framework.

## Key Features

* Log informational messages.
* Log exceptions and nested exceptions.
* No extra dependencies - light weight.
  
## How To Use

```csharp
// initialize with directory path and filename
Logger.Initialize(LogDirPath, LogFileName);

// write informational file to log
Logger.GetInstance().Info("message");

// write exception to log
Logger.GetInstance().Error(exception);

// deinitialize
Logger.GetInstance().DeInit();
```

## Log Format

### Info
```xml
<LogEntry>
  <Type>Info</Type>
  <Date>11/24/2019 2:13:58 AM</Date>
  <Message>Info</Message>
</LogEntry>
```

### Error
```xml
<LogEntry>
  <Type>Error</Type>
  <Date>11/24/2019 2:14:51 AM</Date>
  <Exception>
    <Data />
    <HelpLink />
    <HResult>-2146233088</HResult>
    <Message>message</Message>
    <Source />
    <Stack />
    <TargetSite />
    <InnerException>
      <Data />
      <HelpLink />
      <HResult>-2146233088</HResult>
      <Message>inner message</Message>
      <Source />
      <Stack />
      <TargetSite />
    </InnerException>
    <InnerException>
      <Data />
      <HelpLink />
      <HResult>-2146233088</HResult>
      <Message>inner most message</Message>
      <Source />
      <Stack />
      <TargetSite />
    </InnerException>
  </Exception>
</LogEntry>
```

## How To Contribute

Feel free to open an issue or submit a PR.