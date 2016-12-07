#!/bin/bash

dotnet restore

dotnet build src/*

if [ $1 == "t" ]; then
  dotnet test test/*
fi
