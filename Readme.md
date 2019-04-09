[![Build status](https://ci.appveyor.com/api/projects/status/2x0x8yugaj0fa1mq?svg=true)](https://ci.appveyor.com/project/lillheaton/Graphify.EPiServer-api)
[![NuGet](https://img.shields.io/nuget/v/Graphify.EPiServer.Api.svg)](https://www.nuget.org/packages/Graphify.EPiServer.Api/)

Adding [Facebook's GraphQL](https://github.com/facebook/graphql) for [EPiServer's](https://www.episerver.com/) platform. This tool automates creation of Graphs based on the defined available content types.

This project builds on top of [GraphQL .NET](https://github.com/graphql-dotnet/graphql-dotnet) library written by [Joe McBride](https://github.com/joemcbride) (MIT licence)

## Installation
You can install the latest version via [NuGet](https://www.nuget.org/packages/Graphify.EPiServer.Api/).

`PM> Install-Package Graphify.EPiServer.Api`

## Basic Usage
This project is meant to be a plug and play, this creates a simple API controller to handle incoming requests and run it through Graphify.EPiServer.

This projects builds on top of the core library [Graphify.EPiServer.Core](https://github.com/lillheaton/Graphify.EPiServer.Core) which in turns builds on top of [GraphQL .NET](https://github.com/graphql-dotnet/graphql-dotnet)

Read more on core library [Graphify.EPiServer.Core](https://github.com/lillheaton/Graphify.EPiServer.Core)
