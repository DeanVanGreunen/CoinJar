# Overview

This is a simple **Coin Jar** API, which can be used to store, count and empty the Coin Jar.


# API Usage

This API was design using C# dot net core runtime injunction with ASP.NET web api framework.
Once run this will then also open swagger, which can be used for testing of the API

## APIS
____
POST **/coin/add**
```
This api endpont allows you to add a coin to the jar, however you are required to apply an ammount and a vlumn for the coin
```
____
GET **/coin/total**
```
This api endpont allows you to get the total amount of coins within the coin jar
```
____
GET **/coin/reset**
```
This api endpont allows you to empty the coin jar
```
____

## Database

I'm using [LiteDB](https://www.litedb.org/), which is a C# NoSQL Document based database system, this is an open source file database system.

The database is created within the same path as the executable. you will find it next to `CoinJar\CoinJar\CoinJar.db` if ran from within Visual Studio.


## Tools

Developed with the following tech:

- Microsoft Visual Studio Community 2022 (64-bit) - Version 17.3.2
- C#
- ASP.NET
- LiteDB

## Author

Created by Dean Van Greunen, All Rights Reserved.

