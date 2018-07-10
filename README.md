# Introduction 

CDP is working to help draft the initial API for the latest 2018 version of the WIC Universal MIS-EBT Interface (WUMEI). To assist with this, a reference ASP<span>.NET</span> Core Web API has been built. This includes automatic generation of API documentation using Swagger. This API documentation includes all methods and files defined within the WUMEI along with full model definitions built from classes in code for each entry.

# Getting Started

The following prerequisites are required:
* Visual Studio 2017 (or Visual Studio Code)
* .NET Core 2.1

To get started, clone this repository to your machine and open with Visual Studio. To debug locally, be sure to update your local src\WUMEI\Properties\launchSettings.json file like so to enable the Swagger documentation site to display at runtime:

```
{
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:24041/WUMEISample/",
      "sslPort": 0
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "launchUrl": "swagger",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
```

# Build, Test, and Release

Automated CI builds are setup for the master branch. Automated builds include execution of tests found in the solution.

[<img src="https://cdpinc.visualstudio.com/_apis/public/build/definitions/b60ff22e-6fe0-469e-b948-1a18c5a2ae5d/3/badge"/>](https://cdpinc.visualstudio.com/WUMEI/_build/index?definitionId=3)

In addition to automated CI builds, automated CD releases are also setup as a trigger from CI build completion. Any commit that results in a successful build was also result in a release deployment.

[<img src="https://cdpinc.vsrm.visualstudio.com/_apis/public/Release/badge/b60ff22e-6fe0-469e-b948-1a18c5a2ae5d/1/1"/>](https://cdpinc.visualstudio.com/WUMEI/_release?definitionId=1&_a=releases)

# References

* [Live API Documentation](https://ebtkickoff.cdpehs.com/WUMEISample/swagger/)
* [Swagger API Tooling](https://swagger.io/)
* [WIC EBT Operating Rules & Technical Implementation Guide](https://www.fns.usda.gov/wic/wic-ebt-operating-rules-technical-implementation-guide)