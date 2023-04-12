# Overview
This is a very basic .NET 6 microservice which is deployable in an Entando bundle. It runs on port 8081, has a basic health check, 
and the necessary elements to work in an Entando 7.1 environment including a base path configuration.

Three controllers are included
 * /api/health - the default health check path for readiness/liveness checks by K8s
 * /WeatherForecast - a standard reference microservice
 * /RandomNumber - another simple microservice

