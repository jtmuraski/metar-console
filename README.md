# Metar API Consumer

## Introduction
This console based application is a simple applicatin designed to pull recent **Met**eorlogical **A**erodrome **R**eports (METARS) from the United States National Oceanic and Atmosphere Administration (NOAA) open data API. After the data is pulled from NOAA, the application then updates a local SqlLite database.

## What is a METAR?
A METAR is a aviation weather report that pilots receive before, during and after a flight. It is transmitted and recieved as a simple line of text, but that simple line of text contains a lot of information. If you are curious on how to read a METAR, check out this article: https://pilotinstitute.com/metar-and-taf-reports/

## Purpose
The purpose of this project was to learn and get some practice with the following technologies:
  1) Entity Framework COre
  2) Calling and retrieving data from a 3rd Party API
  3) Deserializing the received data (in this case an XML document)

This simple application is also meant to serve as a sandbox to figure out process and data flow for a upcoming project that I will be doing on AWS. The AWS project will consist of a serverless function that will call this API and retrieve a list of METARS over the last 24 hours, and then upload it to a Amazon RDS database. A user facing website will then allow a visitor to interact with and explire the collected weather data.

## Planned Updates
 As of 18Jan2022, there are no planned updates to this application.
