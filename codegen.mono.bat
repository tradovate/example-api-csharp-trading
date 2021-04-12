wget https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.20/swagger-codegen-cli-3.0.20.jar -O swagger-codegen-cli.jar

java -jar swagger-codegen-cli.jar generate -i ./swagger/services.swagger.yaml ^
  -l csharp ^
  -o services-api ^
  --reserved-words-mappings base=@base,params=@params,readonly=@readonly ^
  --additional-properties ^
  packageName=Tradovate.Services,optionalProjectFile=true,excludeTests=false,packageGuid={1C715F6B-E613-4F6D-8B68-189A9CFABEA1}


java -jar swagger-codegen-cli.jar generate -i ./swagger/services.md.swagger.yaml ^
  -l csharp ^
  -o services-md-api ^
  --reserved-words-mappings base=@base,params=@params,readonly=@readonly ^
  --additional-properties ^
  packageName=Tradovate.MarketData.Services,optionalProjectFile=true,excludeTests=false,packageGuid={38362DB6-278F-4566-91D8-7D0275C5C4F2}

