# C# Trading Example
This example is designed to help you understand how trading using the C# language works. This is a complete project that will:
- Grant you the authority to access the Tradovate Web Services using your Tradovate account credentials.
- Attempt to make trades on your behalf using the Tradovate REST API and Real-Time WebSocket service.

## Run This Example (Mac/Linux)
Tools you'll need:
- [Mono](https://www.mono-project.com/download/stable/).
- Your favorite IDE. [VSCommunity](https://visualstudio.microsoft.com/vs/mac/) is recommended if you're using a Mac (VSCommunity is unavailable for Linux).
- `wget` URL fetch service. Mac users follow [this guide](https://www.fossmint.com/install-and-use-wget-on-mac/) to acquire `wget`.
- [Java Runtime Environment](https://www.java.com/en/download/manual.jsp).

Once you have your tools, clone this repository locally. Before you can run this example you must first generate and build the `Tradovate.Services`
project. This project is automatically created by the Swagger CLI tool when we run a code generation script provided with this repo. To generate
the code, follow these steps:
- Open a terminal and navigate to the directory into which you cloned this repository.
- run `sh codegen.sh`. You should see `wget` fetching the Swagger Codegen tools. Once this completes, you should see a lot of logging as the Swagger tool
generates code.
- Once this operation has succeeded, run `sh build-all.sh`. This should compile and link the projects into an executable. 
- Navigate to the `bin` folder created by the last operation. Run this command - `mono Tradovate.Samples.exe <your-tradovate-username> <your-tradovate-pass>`. Replace the angle-bracketed portions with your credentials, no brackets.
- You should see the program log your Authentication, send a SyncRequest and begin attempting to trade! Congratulations, you've successfully built and run the Tradovate C# sample project.

## Run This Example (Windows)
Tools you'll need:
- [VSCommunity IDE](https://visualstudio.microsoft.com/vs/).
- `wget` URL fetch service, get it [here](https://eternallybored.org/misc/wget/).
- [Java Runtime Environment](https://www.java.com/en/download/manual.jsp).
You also may need to add the `wget` and JRE tools to your system PATH. To do so, locate the `wget` and `java` executables on your machine and add them
to the system path using this command:
```
setx /M PATH "%PATH%;C:\path\to\wget;C:\path\to\java"
```

### 1) Generate the Code
Once you have your tools, clone this repository locally. Before you can run this example you must first generate and build 
the `Tradovate.Services`project. This project is automatically created by the Swagger CLI tool when we run a code generation 
script provided with this repo. To generate the code, follow these steps:

- Open a command line and navigate to the directory into which you cloned this repository.
- Run `codegen.mono.bat`. If it is working properly, you should see `wget` fetching the Swagger Codegen tool. Afterwards you should see a lot of logging while the code generation tool creates the Tradovate.Services project.

### 2) Compile Tradovate.Services
Once Tradovate.Services has been generated we need to compile it.

- Open VSCommunity and open the folder you cloned the repo into.
- On the right hand side, you should see the solution explorer. At the top bar select 'switch between solutions and available views'.
Switch to the generated Tradovate.Services solution. Attempt to build this file. It may succeed, however some users may experience
an issue linking dependencies. Should this happen, simply uninstall one of the dependencies using the NuGet manager, 
and then reinstall it*. This should update the VSCommunity metadata and link the dependencies correctly.

> *NOTE: make sure to install the same package and version originally included with the generated code.

### 3) Compile Tradovate.Samples
Now that we have the `Tradovate.Services.dll` file (which should be located in the `/bin` folder in Tradovate.Services) we should
simply be able to build the samples project. Right-click the Tradovate.Samples solution file and select Build.

### 4) Run it
Open a command line and navigate to the /bin/Debug/net5.0 folder in Tradovate.Samples and run the executable created by the previous
steps:

```sh
Tradovate.Samples.exe <your-tradovate-username> <your-tradovate-pass>
```
Replace the bracketet portions with your own Tradovate credentials (with no brackets). If this is successful, you should see the 
program log your Authentication, send a SyncRequest and begin attempting to trade! Congratulations, you've successfully built and 
run the Tradovate C# sample project.

