## Ken AspnetCore Microservices:

## Prepare environment

	* Install dotnet core version in file `global.json`
	* Visual Studio 2022+
	* Docker Desktop
---
## How to run the project

Run command for build project 
```PowerShell
dotnet build
```
Go to folder container file `docker-compose`

1	. Using docker-compose
```PowerShell
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --remove-orphans
```

## Application URLs - LOCAL Environment (Docker Container):

## Docker Application URLs - LOCAL Environment (Docker Container):
	- Portainer: http://localhost:9000 - username: admin ; pass: admin123456789
	- Kibana: http://localhost:5601 - username: elastic ; pass: admin
	- RabbitMQ: http://localhost:15672 - username: guest ; pass: guest

2	. Using Visual Studio 2022
	- Open aspnetcore-microservices.sln - `aspnetcore-microservices.sln`
	- Run Compound to start multi projects
---
## Application URLs - DEVELOPMENT Environment:

---
## Application URLs - PRODUCTION Environment:

---
## Packages References

## Install Environment

	- https://dotnet.microsoft.com/download/dotnet/6.0
	- https://visualstudio.microsoft.com/
**Development Environment**
