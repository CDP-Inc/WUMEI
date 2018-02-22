# Introduction 
CDP is working to help draft the initial Technical Specification for the latest 2018 version of the WIC Universal MIS-EBT Interface. To assist with this, a reference ASP<span>.NET</span> Core Web API has been built. This includes automatic generation of API documentation using Swagger.

# Getting Started
The following prerequisites are required:
* Visual Studio 2017
* .NET Core 2.0

To get started, clone this repository to your machine and open with Visual Studio.

# Build, Test, and Release
Automated CI builds are setup for the master branch:

[<img src="https://cdpinc.visualstudio.com/_apis/public/build/definitions/b60ff22e-6fe0-469e-b948-1a18c5a2ae5d/3/badge"/>](https://cdpinc.visualstudio.com/WUMEI/_build/index?definitionId=3)

Automated builds include execution of tests found in the solution. In addition to automated CI builds, automated CD releases are also setup as a trigger from CI build completion. Any commit that results in a successful build was also result in a release deployment.

# References
* [Live API Documentation](https://ebtkickoff.cdpehs.com/WUMEI/swagger/)
* [Swagger API Tooling](https://swagger.io/)
* [WIC EBT Operating Rules & Technical Implementation Guide](https://www.fns.usda.gov/wic/wic-ebt-operating-rules-technical-implementation-guide)