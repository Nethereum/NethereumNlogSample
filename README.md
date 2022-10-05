# Nethereum Nlog Sample
Logging trace requests example using nlog



![image](https://user-images.githubusercontent.com/562371/194052239-bd1eb109-366a-4ff1-bccf-9762cf27527d.png)

Nethereum uses Trace to log requests and responses. 

Moore info on setup https://github.com/NLog/NLog/wiki/Getting-started-with-.NET-Core-2---Console-application#a-minimal-example

Example configuration file:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<!-- XSD manual extracted from package NLog.Schema: https://www.nuget.org/packages/NLog.Schema-->
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd" xsi:schemaLocation="NLog NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
      autoReload="true"
      internalLogFile="c:\temp\console-example-internal.log"
      internalLogLevel="Trace" >

	<!-- the targets to write to -->
	<targets>
		<!-- write logs to file -->
		<target xsi:type="File" name="logfile" fileName="c:\temp\console-example.log"
				layout="${longdate}|${level}|${message} |${all-event-properties} ${exception:format=tostring}" />
		<target xsi:type="Console" name="logconsole"
				layout="${longdate}|${level}|${message} |${all-event-properties} ${exception:format=tostring}" />
	</targets>

	<!-- rules to map from logger name to target -->
	<rules>
		<logger name="*" minlevel="Trace" writeTo="logfile,logconsole" />
	</rules>
</nlog>


```