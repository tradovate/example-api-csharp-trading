cd Tradovate.WebSocket
./build.sh
cd -

cd services-api
./build.sh
cd -

frameworkVersion=net45
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp services-api/bin/*.dll bin;
cp Tradovate.WebSocket/bin/*.dll bin;

echo "[INFO] Run 'mcs' to build bin/Tradovate.Samples.exe"
mcs -sdk:${netfx} \
-r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
bin/SuperSocket.ClientEngine.dll,\
bin/Tradovate.Services.dll,\
bin/Tradovate.WebSocket.dll,\
bin/Websocket4Net.dll,\
System.Runtime.Serialization.dll,\
System.ComponentModel.DataAnnotations.dll \
-target:exe \
-out:bin/Tradovate.Samples.exe \
-recurse:'Tradovate.Samples/*.cs' \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Tradovate.Samples.exe was created successfully"
fi
