#!/bin/bash

if [ ! -x "dotnet" ];then
	echo "Please intall x

if [ $# -lt "2" ];then
	echo "Use following format :"
	echo "./init.sh [folder/project name] [Template] [Open Program.cs with nano. Default 1]"
	echo ""
	echo "Ex -> ./init.sh Hello_world console 0"
	read -n1 -r -p "Press any key to continue..."
	echo ""
	exit
fi

if [ -d "$1" ];then
	echo "Already exist directory $1"
	read -n1 -r -p "Press any key to continue..."
	echo ""
	exit
fi

echo "Name : $1"
echo "Template : $2"
echo ""
echo "Are you sure make $1 project with project directory?"
echo "If you want stop this work, press Ctrl+C(^C)"
read -n1 -r -p "Press any key to continue..."
echo "====================================="
mkdir $1
cd $1
dotnet new $2

if [ $3 == "0" ];then
	nano Program.cs
fi