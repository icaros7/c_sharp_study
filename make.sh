#!/bin/bash

if [ $# == '0' ];then
	echo "Use $0 via format, what following :"
	echo "./make.sh [folder name] [build mode] [Run After build? default : 1(false)]"
	echo ""
	echo "Support [build mode] :"
	echo "pbdonly, release, debug, debug:full"
	echo ""
	echo "If you want to build all directory, using follow :"
	echo "./make.sh /all [build mode] [Run after build?]"
	read -n1 -r -p "Press any key to continue..."
	echo ""
	exit
fi

if [ $1 == "/all" ];then
	echo "Target : All"
	echo ""
	echo "Are you sure build all directory?"
	echo "If you want stop this task, Please press Ctrl + C(^C)"
	read -n1 -r -p "Press any key to continue..."
else
	echo "Target : $1"
fi

if [ "$2" == "pbdonly" ];then
	mode="debug:pbdonly"
	folder="Debug"
elif [ "$2" == "release" -o "$2" == "Release" ];then
	mode="release"
	folder="Release"
elif [ "$2" == "debug" -o "$2" == "Debug" ];then
	mode="debug"
	folder="Debug"
elif [ "$2" == "full" -o "$2" == "Full" ];then
	mode="debug:full"
	folder="Debug"
else
	echo "	Can't identify build mode. Default value is debug mode"
	mode="debug"
	folder="Debug"
fi

if [ ! -d "$1" ];then
	echo "Doesn't exist directory $1"
	read -n1 -r -p "Press any key to continue"
	echo ""
	exit
fi

echo "Mode : ${mode}"
echo ""
echo "msbuild for $1"
echo "====================================="
cd $1
msbuild /p:SignAssembly=true /p:AssemblyOriginatorKeyFile=../hominrhee.snk
cd ..
if [ "$3" == "0" ];then
	echo ""
	echo "Run $1 Project"
	echo "================================="
	cd ./$1/bin/${folder}/netcoreapp3.0
	./$1
	cd ../../../..
fi
