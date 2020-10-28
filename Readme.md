# Message App

This is a demo for Azure Service Bus Queue.

This is the Forms version of the console app from the Azure course.
I believe that console apps are something from the past.
A Forms app offers a nice GUI and is only marginally more complex.
And why not demo a feature with code that is more like real code 
than in a console app that nobody uses for real work?

You will need a connection string to access an Azure queue.
On the Azure portal, when viewing the queue details,
click under **Settings** on **Shared Access Policies**.
There, **(+)add** a policy if none yet exists.
Open the policy by clicking on it to view the SAS Policy.
Copy the **Primary Connection String** in the format like:

```
Endpoint=sb://[yourqueuename].servicebus.windows.net/;SharedAccessKeyName=mypolicy;SharedAccessKey=[yourqueuekey]+EU20YgOVm5Eez+7E2rQ8WmTLyf0=;EntityPath=queue1
```

by clicking the Copy To Clipboard button.

Paste this connection string in your application to access the Queue.

------------------
Currently, a build problem may occur because the nuget packages are not archived to github
and the paths to the packages in the .proj file are possibly invalid for you.
The .Proj file references local folder ../packages/ for the NuGet packages, 
instead of C:\Program Files (x86)\Microsoft SDKs\NuGetPackages\
or C:\Users\yourname\.nuget\packages\

For now, the fix is to reinstall all NuGet packages with this command in the Tools / NuGet Package Manager Console:

---- Update-Package -reinstall



