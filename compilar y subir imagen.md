#!/bin/bash

# Compilar la imagen de Docker
docker build -t andresgarcia0313/csconsole:1 .

# Iniciar sesión en Docker Hub
docker login

# Subir la imagen a Docker Hub
docker push andresgarcia0313/csconsole:1


1689  dotnet run
 1690  dotnet build
 1691  docker build csapp .
 1692  docker build csapp:latest .
 1693  docker build -t hello-world-csharp:latest .
 1694  docker run hello-world-csharp
 1695  docker build -t hello-world-csharp:latest .
 1696  docker run hello-world-csharp:latest .
 1697  docker build -t hello-world-csharp:latest .
 1698  docker run hello-world-csharp:latest .
 1699  docker build -t hello-world-csharp:latest .
 1700  docker run hello-world-csharp:latest .
 1701  dotnet build && dotnet run
 1702  docker build -t hello-world-csharp:latest . && docker run hello-world-csharp:latest .
 1703  docker login
 1704  docker build -t andresgarcia0313/csconsole:1 .
 1705  docker push andresgarica0313/csconsole:1
 1706  docker build -t andresgarcia0313/csconsole:1 .
 1707  docker push andresgarcia0313/csconsole:1
 1708  history