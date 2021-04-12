frameworkVersion=net46
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Download nuget and packages"
wget -nc https://dist.nuget.org/win-x86-commandline/v4.5.0/nuget.exe
mozroots --import --sync
mono nuget.exe install packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.10.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.1.0/lib/net45/RestSharp.dll bin/RestSharp.dll;
cp packages/Websocket4Net.0.15.1/lib/net45/Websocket4Net.dll bin/Websocket4Net.dll;
cp packages/SuperSocket.ClientEngine.Core.0.9.0/lib/net45/SuperSocket.ClientEngine.dll bin/SuperSocket.ClientEngine.dll

echo "[INFO] Run 'mcs' to build bin/Tradovate.WebSocket.dll"
mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
bin/Websocket4Net.dll,\
bin/SuperSocket.ClientEngine.dll,\
System.Runtime.Serialization.dll,\
System.ComponentModel.DataAnnotations.dll \
-target:library \
-out:bin/Tradovate.WebSocket.dll \
-recurse:'*.cs' \
-doc:bin/Tradovate.WebSocket.xml \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Tradovate.WebSocket.dll was created successfully"
fi
