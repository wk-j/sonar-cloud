## Commands

```
dotnet tool install --global coverlet.console

coverlet tests/SonarCloud.Tests/bin/Debug/netcoreapp2.1/SonarCloud.Tests.dll --target "dotnet" --targetargs "test tests/SonarCloud.Tests --no-build"

dotnet test tests/SonarCloud.Tests/SonarCloud.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

dotnet-sonarscanner begin /k:"sonar-cloud" /d:sonar.organization="wk-j-github" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="940f6517a5a823b166a31a9173557dedbdbc9401" /d:sonar.cs.opencover.reportsPaths="tests/SonarCloud.Tests/coverage.opencover.xml"

dotnet test tests/SonarCloud.Tests/SonarCloud.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover

dotnet-sonarscanner end /d:sonar.login="940f6517a5a823b166a31a9173557dedbdbc9401"
```