# How to run
- Go to bin directory
- Run Host.exe as administrator
- Once Host service is running, Run Client LeaderBoardClient.exe
- Follow command line

# Core Concept
Both web and PC application are supported
Clients are provided for reading data

Concept is to keep data and visualization segregated

# Design

A main service running on windows system is responsible for all business logics
Service publish a client which can be used for
 - Creating contest
 - Query for ongoing contest
 - Update scores
 - Read latest context info
 

# Host

A windows service which hosts main process for service

## ServiceLib 
A library which documents contracts and implements contracts

##
A proxy client to main service

## WebServer
Enables Web version of application, Used client provided to communicate with Host service




